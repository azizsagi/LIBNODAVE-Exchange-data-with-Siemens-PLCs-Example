using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace LibnoDave
{
    public partial class Form1 : Form
    {

        [DllImport("libnodave.dll", CharSet = CharSet.Auto)]



        public static libnodave.daveOSserialType fds;
        public static libnodave.daveInterface di;
        public static libnodave.daveConnection dc;
        public static int rack = 0;
        public static int slot = 2;
        string ipadres = "192.168.0.2";


        byte[] boy = new byte[256];
        // int[] tag = new int[64];
        double[] tag = new double[64];
        int[] res = new int[16];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try // ip adresine 102.
                {
                fds.rfd = libnodave.openSocket(102, ipadres);
                }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
    }
}
