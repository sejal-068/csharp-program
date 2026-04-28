using System;
using System.IO;
using System.Windows.Forms;

class NotepadApp : Form
{
    TextBox txt = new TextBox();

    public NotepadApp()
    {
        txt.Multiline = true;
        txt.Dock = DockStyle.Fill;

        MenuStrip menu = new MenuStrip();
        var save = new ToolStripMenuItem("Save");

        save.Click += (s,e)=>
        {
            File.WriteAllText("note.txt", txt.Text);
        };

        menu.Items.Add(save);

        Controls.Add(txt);
        Controls.Add(menu);
    }

    [STAThread]
    static void Main()
    {
        Application.Run(new NotepadApp());
    }
}