using System;
using System.Windows.Forms;

class Quiz : Form
{
    Label q = new Label();
    Button a = new Button();

    public Quiz()
    {
        q.Text = "2+2=?";
        a.Text = "4";

        a.Top = 30;

        a.Click += (s,e)=> MessageBox.Show("Correct!");

        Controls.Add(q);
        Controls.Add(a);
    }

    [STAThread]
    static void Main()
    {
        Application.Run(new Quiz());
    }
}