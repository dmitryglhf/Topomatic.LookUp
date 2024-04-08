using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topomatic.LookUp.UI
{
    public partial class MainMenu : Form
    {
        bool mouseDown;
        private Point offset;
        public MainMenu(object obj)
        {
            InitializeComponent();
            labelObject.Text = obj.ToString();
            List<object> list = new List<object>();
            try
            {
                foreach (var prop in obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
                {
                    list.Add(prop);
                    dataGridView.Rows.Add(prop.Name, prop.GetValue(obj, null));
                }
            }
            catch (Exception)
            {

            }
        }
        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }
        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }
        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
