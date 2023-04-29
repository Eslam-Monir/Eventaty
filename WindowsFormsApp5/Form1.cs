using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace WindowsFormsApp5
{
    public partial class cr : Form
    {
        CrystalReport4 CR;
        CrystalReport3 AR;
        CrystalReport2 RR;
        CrystalReport1 ER;
        public cr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, category.Text);
            crystalReportViewer1.ReportSource = CR;

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport4();
            foreach (ParameterDiscreteValue v in CR.ParameterFields[0].DefaultValues)
                category.Items.Add(v.Value);
            AR = new CrystalReport3();
            ER = new CrystalReport1();
            RR = new CrystalReport2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = ER;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = RR;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = AR;
        }
    }
}
