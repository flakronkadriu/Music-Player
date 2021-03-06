﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NAudio.Wave;
using System.Windows.Controls;
using System.Drawing;

namespace VizuelnoProject
{
    public partial class Form1 : Form
    {

        List<AudioFileInfo> playList = new List<AudioFileInfo>();
        List<AudioFileInfo> playedList = new List<AudioFileInfo>();
        Random random = new Random();
        WaveOut waveOut = new WaveOut(); // or WaveOutEvent()        
        AudioFileInfo selectedSong = null;
        AudioFileInfo playingSong = null;
        System.Timers.Timer timer = new System.Timers.Timer();
        Mp3FileReader reader;
        int songProgress = 0;
        int repeat = 0;
        bool first = true;
        bool shuffle = false;
        bool isDragDrop = false;
        bool scrollingMax = false;
        public Form1()
        {
            InitializeComponent();
            this.listBox1.AllowDrop = true;
            this.songTrackBar.Value = 0;
            listBox1.SelectedIndexChanged += selectedMusicChanged;
            this.waveOut.PlaybackStopped += waveOut_PlaybackStopped;
            openFileDialog1.Filter = "All Supported Audio | *.mp3; *.wma | MP3s | *.mp3 | WMAs | *.wma";
            openFileDialog1.AutoUpgradeEnabled = false;
            volumeTrack.Value = (int)this.waveOut.Volume * 100;
            this.timer.Elapsed += (o, e) =>
            {
                if (InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                    {
                        this.songTrackBar.Value += 1;
                        this.songProgress++;
                        this.timeLabel.Text = String.Format("{0:00}:{1:00}", this.reader.CurrentTime.Minutes, this.reader.CurrentTime.Seconds);
                    }));
                }
                else
                {
                    this.songTrackBar.Value += 1;
                    this.songProgress++;
                    this.timeLabel.Text = String.Format("{0:00}:{1:00}", this.reader.CurrentTime.Minutes, this.reader.CurrentTime.Seconds);
                }
            };
        }

        private void waveOut_PlaybackStopped(object sender, StoppedEventArgs e)
        {

        }

        private void selectedMusicChanged(object sender, EventArgs e)
        {
            if (!isDragDrop)
            {
                AudioFileInfo mp3File = (AudioFileInfo)this.listBox1.SelectedItem;
                this.selectedSong = mp3File;
            }
        }

        private void playSelectedFile()
        {
            if (this.selectedSong == null) return;
            if (waveOut.PlaybackState == PlaybackState.Playing)
            {
                waveOut.Stop();
                this.timer.Stop();
            }
            waveOut.Dispose();
            waveOut = null;
            this.playingSong = selectedSong;
            this.reader = new Mp3FileReader(this.selectedSong.filePath);
            waveOut = new WaveOut(); // or WaveOutEvent()
            waveOut.Init(this.reader);
            filenameLabel.Text = this.playingSong.fileName;
            durationField.Text = String.Format("{0:00}:{1:00}", playingSong.fileDuration.Minutes, playingSong.fileDuration.Seconds);
            this.songTrackBar.Minimum = 0;
            this.songTrackBar.Maximum = Convert.ToInt32(Math.Round(this.selectedSong.fileDuration.TotalSeconds));
            this.songTrackBar.TickFrequency = 1;
            this.songTrackBar.Value = 0;
            this.timer.Interval = 1000;
            waveOut.Play();
            this.songProgress = 0;
            this.timer.Start();
            playButton.BackColor = Color.Black;

        }
        private void Seeking(int value)
        {
            waveOut.Stop();
            this.timer.Stop();
            waveOut.Dispose();
            waveOut = null;
            double seconds = Convert.ToDouble(value);
            this.reader = null;
            this.reader = new Mp3FileReader(this.selectedSong.filePath);
            this.reader.Position = 0;
            this.reader.CurrentTime = TimeSpan.FromSeconds(seconds);
            waveOut = new WaveOut(); // or WaveOutEvent()
            waveOut.Init(reader);
            waveOut.Play();
            this.timer.Start();
        }
        private void Loop()
        {
            waveOut.Dispose();
            waveOut = null;
            this.reader = null;
            this.reader = new Mp3FileReader(this.selectedSong.filePath);
            this.reader.Position = 0;
            LoopStream loop = new LoopStream(reader);
            waveOut = new WaveOut(); // or WaveOutEvent()
            waveOut.Init(loop);
            filenameLabel.Text = this.playingSong.fileName;
            durationField.Text = String.Format("{0:00}:{1:00}", playingSong.fileDuration.Minutes, playingSong.fileDuration.Seconds);
            this.songTrackBar.Minimum = 0;
            this.songTrackBar.Maximum = Convert.ToInt32(Math.Round(this.selectedSong.fileDuration.TotalSeconds));
            this.songTrackBar.TickFrequency = 1;
            this.songTrackBar.Value = 0;
            this.timer.Interval = 1000;
            waveOut.Play();
            this.songProgress = 0;
            this.timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null)
            {
                foreach (string file in files)
                {
                    if (playList.Any(x => x.filePath == file)) continue;
                    else
                    {
                        string name = Path.GetFileNameWithoutExtension(file);
                        Mp3FileReader reader = new Mp3FileReader(file);
                        playList.Add(new AudioFileInfo { filePath = file, fileName = name, fileDuration = reader.TotalTime });
                        updateListBox();
                    }
                }
                if (first)
                {

                    this.selectedSong = playList.ElementAt(0);
                    listBox1.SelectedItem = this.selectedSong;
                    listBox1.Focus();
                    listBox1.Update();
                    first = false;
                    this.playSelectedFile();

                }
            }
        }
        void updateListBox()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(playList.Select(x => (object)x).ToArray());
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (this.waveOut.PlaybackState == PlaybackState.Paused && selectedSong == playingSong)
            {
                this.waveOut.Play();
                this.timer.Start();
                this.playButton.BackColor = Color.Black;
                this.pauseButton.BackColor = Color.White;
                this.stopButton.BackColor = Color.White;
            }
            else if (this.waveOut.PlaybackState != PlaybackState.Playing)
            {
                this.playSelectedFile();
                this.pauseButton.BackColor = Color.White;
                this.stopButton.BackColor = Color.White;
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            this.waveOut.Pause();
            this.timer.Stop();
            pauseButton.BackColor = Color.Black;
            this.playButton.BackColor = Color.White;
            this.stopButton.BackColor = Color.White;
        }

        private void backTrackButton_Click(object sender, EventArgs e)
        {
            if (playingSong != null)
            {
                int indexOf = playList.IndexOf(playingSong);
                if (indexOf > 0)
                {
                    this.waveOut.Stop();
                    this.timer.Stop();
                    this.selectedSong = playList.ElementAt(indexOf - 1);
                    listBox1.SelectedItem = this.selectedSong;
                    listBox1.Focus();
                    listBox1.Update();
                    this.playSelectedFile();

                }
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.waveOut.Stop();
            this.timer.Stop();
            stopButton.BackColor = Color.Black;
            this.playButton.BackColor = Color.White;
            this.pauseButton.BackColor = Color.White;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (playingSong != null)
            {
                int indexOf = playList.IndexOf(playingSong);
                if (indexOf < playList.Count - 1)
                {
                    this.waveOut.Stop();
                    this.timer.Stop();
                    this.selectedSong = playList.ElementAt(indexOf + 1);
                    listBox1.SelectedItem = this.selectedSong;
                    listBox1.Focus();
                    listBox1.Update();
                    this.playSelectedFile();
                }
            }
        }

        private void volumeTrack_ValueChanged(object sender, EventArgs e)
        {
            this.waveOut.Volume = (float)volumeTrack.Value / 100;
        }

        private void songTrackBar_Scroll(object sender, EventArgs e)
        {
            if (playingSong != null)
            {
                if (songTrackBar.Value < songTrackBar.Maximum)
                {
                    this.waveOut.Pause();
                    Seeking(songTrackBar.Value);
                }
                else if (songTrackBar.Value == songTrackBar.Maximum)
                {
                    scrollingMax = true;
                    int indexOf = playList.IndexOf(playingSong);
                    if (indexOf < playList.Count - 1)
                    {
                        this.waveOut.Stop();
                        this.timer.Stop();
                        this.selectedSong = playList.ElementAt(indexOf + 1);
                        listBox1.SelectedItem = this.selectedSong;
                        listBox1.Focus();
                        listBox1.Update();
                        this.playSelectedFile();
                    }
                    else
                    {
                        this.waveOut.Stop();
                        this.timer.Stop();
                        this.songTrackBar.Value = 0;
                    }
                }
            }
        }

        private void songTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (songTrackBar.Value == songTrackBar.Maximum)
            {
                if (shuffle)
                {
                    playedList.Add(playingSong);
                    if (playList.Count == playedList.Count)
                    {
                        this.waveOut.Stop();
                        this.timer.Stop();
                    }
                    else
                    {
                        int index = random.Next(0, playList.Count);
                        while (playedList.Contains(playList.ElementAt(index)))
                        {
                            index = random.Next(0, playList.Count);
                        }
                        this.selectedSong = playList.ElementAt(index);
                        listBox1.SelectedItem = this.selectedSong;
                        listBox1.Focus();
                        listBox1.Update();
                        this.waveOut.Stop();
                        this.timer.Stop();
                        playSelectedFile();
                    }

                }
                else
                {
                    if (!scrollingMax)
                    {
                        int indexOf = playList.IndexOf(playingSong);
                        if (indexOf == playList.Count - 1)
                        {
                            if (repeat == 1)
                            {
                                this.waveOut.Stop();
                                this.timer.Stop();
                                this.selectedSong = playList.ElementAt(0);
                                listBox1.SelectedItem = this.selectedSong;
                                listBox1.Focus();
                                listBox1.Update();
                                this.playSelectedFile();
                            }
                            else if (repeat == 2)
                            {
                                this.waveOut.Stop();
                                this.timer.Stop();
                                this.Loop();
                            }
                            else
                            {
                                this.waveOut.Stop();
                                this.timer.Stop();
                            }
                        }
                        else if (repeat == 2)
                        {
                            this.waveOut.Stop();
                            this.timer.Stop();
                            this.Loop();
                        }
                        else if (indexOf < playList.Count)
                        {
                            this.waveOut.Stop();
                            this.timer.Stop();
                            this.selectedSong = playList.ElementAt(indexOf + 1);
                            listBox1.SelectedItem = this.selectedSong;
                            listBox1.Focus();
                            listBox1.Update();
                            this.playSelectedFile();
                        }
                    }
                }
            }
            scrollingMax = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            repeat++;
            if (repeat == 1)
            {
                button3.BackColor = Color.Black;
                loopingStatus.Text = "On";

            }
            else if (repeat == 2)
            {
                button3.BackColor = Color.Red;
                loopingStatus.Text = "Song Repeating";
            }
            else
            {
                button3.BackColor = SystemColors.Control;
                loopingStatus.Text = "Off";
                repeat = 0;
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.waveOut.PlaybackState == PlaybackState.Paused && selectedSong == playingSong)
            {
                this.waveOut.Play();
                this.timer.Start();
            }
            else
            {
                this.selectedSong = (AudioFileInfo)listBox1.SelectedItem;
                this.playSelectedFile();
            }
            Invalidate(true);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!shuffle)
            {
                button7.BackColor = Color.Black;
                shuffle = true;
            }
            else
            {
                button7.BackColor = Color.White;
                shuffle = false;
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                if (this.listBox1.SelectedItem == null) return;
                isDragDrop = true;
                this.listBox1.DoDragDrop(this.listBox1.SelectedItem, DragDropEffects.Move);
            }
            Invalidate(true);
        }

        private void listBox1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                Point point = listBox1.PointToClient(new Point(e.X, e.Y));
                int index = this.listBox1.IndexFromPoint(point);
                if (index < 0) index = this.listBox1.Items.Count - 1;
                AudioFileInfo data = (AudioFileInfo)listBox1.SelectedItem;
                this.listBox1.Items.Remove(data);
                this.playList.Remove(data);
                this.playList.Insert(index, data);
                this.listBox1.Items.Insert(index, data);
                listBox1.SelectedItem = this.selectedSong;
                listBox1.Focus();
                listBox1.Update();
                isDragDrop = false;
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string file = openFileDialog1.FileName;
                string name = Path.GetFileNameWithoutExtension(file);
                Mp3FileReader reader = new Mp3FileReader(file);
                playList.Add(new AudioFileInfo { filePath = file, fileName = name, fileDuration = reader.TotalTime });
                updateListBox();
                if (first)
                {

                    this.selectedSong = playList.ElementAt(0);
                    listBox1.SelectedItem = this.selectedSong;
                    listBox1.Focus();
                    listBox1.Update();
                    first = false;
                    this.playSelectedFile();

                }
                else
                {
                    listBox1.SelectedItem = this.selectedSong;
                    listBox1.Focus();
                    listBox1.Update();
                }

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            AudioFileInfo deleteObject = (AudioFileInfo)this.listBox1.SelectedItem;
            if (playingSong == deleteObject) return;
            listBox1.Items.Remove(deleteObject);
            playList.Remove(deleteObject);
            if (playedList.Count > 0)
            {
                playedList.Remove(deleteObject);
            }
            listBox1.SelectedItem = this.selectedSong;
            listBox1.Focus();
            listBox1.Update();
        }
    }
}