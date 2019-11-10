using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // This line is added for prod issue fix immediately..
            Console.WriteLine("This is current prod issue fixed");

            // this line is added to fix production release fix...
            Console.WriteLine("This is prod release issue fixed");

            // this line is added to fix another production release issue after fixing current prod issue..
            Console.WriteLine("This is another prod release issue fixed");
        }
    }
}
