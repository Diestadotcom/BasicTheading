namespace BasicThreading
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
        }


        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before starting thread-");
            Thread ThreadA = new Thread(new ThreadStart(MyThreadClass.Thread1));
            Thread ThreadB = new Thread(new ThreadStart(MyThreadClass.Thread1));
            ThreadA.Name = "Thread A";
            ThreadB.Name = "Thread B";
           
            ThreadA.Start();
            ThreadB.Start();
         
            ThreadA.Join();
            ThreadB.Join();
            Console.WriteLine("-End of Thread-");
    
            lblStatus.Text = "-End of Thread-";
        }
    }
}
