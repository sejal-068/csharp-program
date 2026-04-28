using System;
using System.Windows.Forms;

class Viewer : Form
{
    PictureBox pic = new PictureBox();
    Button load = new Button();

    public Viewer()
    {
        load.Text = "Load";
        load.Click += (s,e)=>
        {
            pic.ImageLocation = "image.jpg";
        };

        Controls.Add(load);
        Controls.Add(pic);
    }

    static void Main()
    {
        Application.Run(new Viewer());
    }
}