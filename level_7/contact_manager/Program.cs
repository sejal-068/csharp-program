using System;
using System.Windows.Forms;

class Contact : Form
{
    ListBox list = new ListBox();
    TextBox name = new TextBox();
    Button add = new Button();

    public Contact()
    {
        add.Text = "Add";
        add.Top = 30;

        add.Click += (s,e)=> list.Items.Add(name.Text);

        Controls.Add(name);
        Controls.Add(add);
        Controls.Add(list);
    }

    static void Main()
    {
        Application.Run(new Contact());
    }
}