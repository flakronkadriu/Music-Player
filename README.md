# Music-Player
Mini Windows Media Player

This desktop application is inspired by Windows Media Player and is very similar to it.

![alt text](https://github.com/flakronkadriu/Music-Player/blob/master/VizuelnoProject/music-p.PNG)

This application is created with C# Windows Forms.

The application contains the following functionality: Drag and drop for songs, Open File Dialog for adding songs to playlist, Play-Pause-Stop-Next-Back buttons, Repeat button or you can repeat a song with double-clicking, shuffle, track-bar for tracking the song and forwarding or backwarding, volume and interaction with the playlist deleting or adding a song.

For making all this possible i used a package called <strong>NAudio</strong> which offers reading and playing .mp3 files.

This method is used for playing a selected song.
```
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
```
