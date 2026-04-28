using System;
using System.Windows.Forms;

class Expense : Form
{
    ListBox list = new ListBox();
    TextBox amount = new TextBox();
    Button add = new Button();

    public Expense()
    {
        add.Text = "Add";
        add.Top = 30;

        add.Click += (s,e)=> list.Items.Add(amount.Text);

        Controls.Add(amount);
        Controls.Add(add);
        Controls.Add(list);
    }

    [STAThread]
    static void Main()
    {
        Application.Run(new Expense());
    }
}