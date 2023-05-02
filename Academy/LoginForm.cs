using System.Diagnostics;

namespace Academy
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event of clicking on the canceling button.
        /// <paramref name="e"/>
        /// <paramref name="sender"/>
        /// </summary>
        /// <param name="e">Base class of the information o the event.</param>
        /// <param name="sender">The object that calls this event.</param>
        private void lblCancelClick(object sender, EventArgs e)
        {
            Process currentProcess = Process.GetCurrentProcess();

            if (currentProcess != null)
            {
                currentProcess.CloseMainWindow();
            }
        }

        private void FormLoad(object sender, EventArgs e)
        {
            this.lblTitle.Left = (this.Width - this.lblTitle.Width) / 2;
        }
    }
}