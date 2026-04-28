using System;
using System.Windows.Forms;

class Login : Form
{
    TextBox user = new TextBox();
    TextBox pass = new TextBox();
    Button login = new Button();

    public Login()
    {
        pass.Top = 30;
        login.Top = 60;
        login.Text = "Login";

        login.Click += (s,e)=>
        {
            if(user.Text=="admin" && pass.Text=="123")
                MessageBox.Show("Success");
            else
                MessageBox.Show("Fail");
        };

        Controls.Add(user);
        Controls.Add(pass);
        Controls.Add(login);
    }

    static void Main()
    {
        Application.Run(new Login());
    }
}