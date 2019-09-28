using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace usercontrol_thietke
{
    public partial class UserControl1_Themptb : UserControl
    {  
        private string _message;
        public UserControl1_Themptb(string Message)
        {
            InitializeComponent();
            this._message = Message;
            vebanco();
        }
        int x_1 = 40;
        int y_1 = 40;
        int d = 0;
        public void vebanco()
        {
            Button btn = new Button();
            {
                btn.Width = 0;
                btn.Location = new Point(0, 0);
            }
            Button btn1 = new Button();
            {
                btn1.Width = x_1;
                btn1.Height = y_1;
                btn1.BackColor = Color.Aqua;
                btn1.Text = _message;
                btn1.Location = new Point(btn.Location.X + btn.Width, btn.Location.Y);
                d++;
            }
            bunifuGradientPanel1.Controls.Add(btn1);
            btn = btn1;
            if (d == 5)
            {
                btn.Location = new Point(0, btn.Location.Y + y_1);
                btn.Width = 0;
                btn.Height = 0;
            }


        }
    }
}
