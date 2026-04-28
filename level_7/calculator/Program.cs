using System;
using System.Windows.Forms;

public class Calculator : Form
{
    TextBox txt = new TextBox();
    Button btn = new Button();

    public Calculator()
    {
        txt.Width = 200;
        btn.Text = "Calculate";
        btn.Top = 30;

        btn.Click += (s, e) =>
        {
            txt.Text = new System.Data.DataTable().Compute(txt.Text, "").ToString();
        };

        Controls.Add(txt);
        Controls.Add(btn);
    }

    [STAThread]
    static void Main()
    {
        Application.Run(new Calculator());
    }
}