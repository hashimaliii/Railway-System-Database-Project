using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G13_Railway_Management_System
{
    public partial class AdminDashboard : UserControl
    {
        string connectionString = string.Empty;
        public AdminDashboard(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }
    }
}
