using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class themloaigiay : Form
    {
        
        public themloaigiay()
        {
            InitializeComponent();
            
        }
       
        public themloaigiay(frm_nh u)
        {
            InitializeComponent();
           
        }
       
        public delegate void updatedelegate(object sender, UpdateEventArgs args);
        public event updatedelegate UpdateEventHandler;
        public class UpdateEventArgs : EventArgs
        {
            public string data
            {
                get;
                set;
            }
        }
        protected void insert()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }
        frm_nh nhaphang = new frm_nh();
        private void buttonX1_Click(object sender, EventArgs e)
        {
           
            insert();
        }
        
        private void themloaigiay_Load(object sender, EventArgs e)
        {

        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         int newLocationX, newLocationY;

        private void themloaigiay_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            newLocationX = e.X;
            newLocationY = e.Y;
        }

        private void themloaigiay_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            Left = Left + (e.X - newLocationX);
            Top = Top + (e.Y - newLocationY);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            themloaigiay_MouseDown(sender, e);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            themloaigiay_MouseMove(sender, e);
        }
    }
}
