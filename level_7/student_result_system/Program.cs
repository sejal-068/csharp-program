using System;
using System.Windows.Forms;

class Result : Form
{
    TextBox marks = new TextBox();
    Button calc = new Button();

    public Result()
    {
        calc.Text = "Check";
        calc.Top = 30;

        calc.Click += (s,e)=>
        {
            int m = int.Parse(marks.Text);
            MessageBox.Show(m >= 40 ? "Pass" : "Fail");
        };

        Controls.Add(marks);
        Controls.Add(calc);
    }

    [STAThread]
    static void Main()
    {
        Application.Run(new Result());
    }
}