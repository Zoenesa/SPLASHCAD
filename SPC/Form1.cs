using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region ResetObjects
        public void ResetObjects()
        {
            this.PropertyGrid1.SelectedObject = null;
        }
        #endregion

        #region SetObjects
        public void SetObjects(Object obj)
        {
            this.PropertyGrid1.SelectedObject = obj;
            this.Text = obj.GetType().ToString();
        }
        #endregion

        #region OnResize
        override protected void OnResize(System.EventArgs e)
        {
            this.PropertyGrid1.Height = this.ClientSize.Height;
            this.PropertyGrid1.Width = this.ClientSize.Width;
            this.button1.Top = this.ClientSize.Height - 40;
            this.button1.Left = this.ClientSize.Width - 216;
            this.button2.Top = this.ClientSize.Height - 40;
            this.button2.Left = this.ClientSize.Width - 104;
        }
        #endregion
    }
}

