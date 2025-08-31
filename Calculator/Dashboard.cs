using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
  public partial class Dashboard : Form
  {
    Form stopwatchFrm = new StopwatchForm();
    Form standardCalculator = new frmDashboard();
    public Dashboard()
    {
      InitializeComponent();
    }

    private void Dashboard_Load(object sender, EventArgs e)
    {
      stopwatchFrm = new Form();
      stopwatchFrm.MdiParent = this;
      stopwatchFrm.Show();

      if(standardCalculator != null)
      {
        standardCalculator.Close();
      }
    }

    private void stopwatchToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
    {      
      standardCalculator = new frmDashboard();
      standardCalculator.MdiParent = this;
      standardCalculator.Show();

      if (stopwatchFrm != null)
      {
        stopwatchFrm.Close();
      }
    }

    private void unitConverterToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }
  }
}
