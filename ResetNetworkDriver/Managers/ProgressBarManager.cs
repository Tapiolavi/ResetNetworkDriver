using ResetNetworkDriver.Interfaces;
using System.Windows.Forms;

namespace ResetNetworkDriver.Managers
{
    public class ProgressBarManager : IProgresBarManager
    {
        private ProgressBar progressBar;
        private Label statusLabel;

        public ProgressBarManager(ProgressBar progressBar, Label statusLabel)
        {
            this.progressBar = progressBar;
            this.statusLabel = statusLabel;
        }

        public void Start()
        {
            progressBar.Value = 0;
            statusLabel.Text = "Status";
        }

        public void Update(int progress, string status)
        {
            progressBar.Value = progress;
            statusLabel.Text = status;
        }

        public void Finish(string message)
        {
            progressBar.Value = 100;
            statusLabel.Text = message;
        }
    }

}
