using System;
using System.Windows.Forms;
using WMPLib;

class Player : Form
{
    WindowsMediaPlayer wmp = new WindowsMediaPlayer();
    Button play = new Button();

    public Player()
    {
        play.Text = "Play";

        play.Click += (s,e)=>
        {
            wmp.URL = "song.mp3";
            wmp.controls.play();
        };

        Controls.Add(play);
    }

    static void Main()
    {
        Application.Run(new Player());
    }
}