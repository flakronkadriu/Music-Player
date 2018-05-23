# Music-Player
Mini Windows Media Player

Апликацијата која го имам направено е инспирирано од Windows Media Player и е сосема сличен на windows media player.

![alt text](https://github.com/flakronkadriu/Music-Player/blob/master/VizuelnoProject/music-p.PNG)


Апликацијата ги содржи следните функционалности: Drag and Drop на песни, Open File Dialog за да се внесе песна во плејлиста, Play-Pause-Stop-Next-Back копчиња, Repeat копче за повторување на плејлиста со еден клик или со повторување на песна со двоен-клик, shuffle копче која служи за програмата да почне рандом песни кои се на плејлистата и доколку сите песни се поминати тогаш застанува програмата,track bar за следење на која минута се наоѓа песната и можност за да се прескокне песната напред или назад со движење на trackbar, намалување или давање на глас со volume trackbarot. Можност за да се смени плејлистата т.е распоредот на песните со Drag and Drop и бришење на песна од плејлиста со клик на копчето X во главното мени.

Апликацијата го имам направено користејќи готов пакет <strong>NAudio</strong> кој ги овозможува сите функционалности како play,pause,stop. Користејќи овој пакет ги имам направено другите функционалности како движење на песната понапред или поназадат од моменталната минута, додавање или намалување на гласот, повторување на плејлиста или песна и shuffle. 

Користени се следните компоненти на Windows Forms:
<ul>
  <li>ToolStrip - Главното Мени</li>
  <li>GroupBox - Групирање на компонентите во Playing и Playlist</li>
  <li>ТеxtBox - Прикажување на моменталната песна која се слуша, времетрање на песната, состојба на повторување</li>
  <li>Label - Прикажување на информаци за TextBox-ot</li>
  <li>TrackBar - Контрола врз звукот и песната</li>
  <li>Button - Копчиња за Play,Pause,Stop,Back,Next,Repeat,Shuffle</li>
  <li>ListBox - Креирање на плејлистата</li>
  <li>OpenFileDialog - Отвори датотека за внес на песни</li>
  <li>Тimer</li>
</ul>

За имплетација на мојата програма имам користено само една класа и тоа е <strong>AudioFileInfo</strong> за да зачувам податоци за .mp3 фајлот. Другите методи и функционалности ги имам направено на .cs фајлот на самата форма.
```
List<AudioFileInfo> playList = new List<AudioFileInfo>();
List<AudioFileInfo> playedList = new List<AudioFileInfo>();
```
Во playList чувам листа од објекти каде го креирам плејлистата со песни кои ке бидат почнати а playedList го користам во случај User-ot има избрано опцијата shuffle за песните да се стартуват по случаен избор тогаш за секоја стартувана песна го зачувам во playedList за да се одбегне повторување на истата песна.

На следнот метод е имплементиран стартување на песна.
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
<strong> Опис на методот </strong>

Секој метод во програма има повик до овој метод бидејки тука се инициализират песните и се стартуват. Во почеток на методот проверувам дали има некој селектирана песна од плејлистата т.е дали има SelectedItem od listBox па доколку има провери дали има некоја песна која е во playing состојба доколку има таква песна тогаш гаси го, стопирај го тимерот и waveOut.Dispose() за да ослободи меморијаta и потоа playingSong(објект од класата AudioFileInfo) ке биде селектираната песна и Mp3FileReader reader е всушност објект надвор од функцијата каде што го инициализирам внатре во функцијата за да ми ги прочита податоците за песната. Waveout го инициализирам и потоа лабелот и text field-ot го поставувам и трак барот како што можете да видите е поставено на вкупните минути и секунди на песната пресметано математички со Round. И за да почне песната само правам повик до waveOut.Play() и го стартувам песната и тајмерот.
