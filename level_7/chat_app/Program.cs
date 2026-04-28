using System;
using System.Windows.Forms;

class Chat : Form
{
    TextBox input = new TextBox();
    ListBox chat = new ListBox();
    Button send = new Button();

    public Chat()
    {
        send.Text = "Send";
        send.Top = 30;

        send.Click += (s,e)=> chat.Items.Add(input.Text);

        Controls.Add(input);
        Controls.Add(send);
        Controls.Add(chat);
    }

    static void Main()
    {
        Application.Run(new Chat());
    }
}