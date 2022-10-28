using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Threading
{
    public partial class FrmBasicThread : Form
    {
        private Thread ThreadA, ThreadB;
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before start thread-");

            ThreadStart threadstart = new ThreadStart(MyThreadClass.Thread1);

            ThreadA = new Thread(threadstart);
            ThreadA.Name = "Thread A Process";

            ThreadB = new Thread(threadstart);
            ThreadB.Name = "Thread B Process";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine("-End of Thread-");

            label1.Text = "-End of Thread-";

        }
    }
}
