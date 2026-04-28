using System;
using System.Windows.Forms;

class Todo : Form
{
    ListBox list = new ListBox();
    TextBox input = new TextBox();
    Button add = new Button();

    public Todo()
    {
        input.Top = 10;
        add.Text = "Add";
        add.Top = 40;
        list.Top = 80;

        add.Click += (s,e)=> list.Items.Add(input.Text);

        Controls.Add(input);
        Controls.Add(add);
        Controls.Add(list);
    }

    [STAThread]
    static void Main()
    {
        Application.Run(new Todo());
    }
}