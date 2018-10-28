using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using ZedGraph;

namespace Lab_1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		

		private void Form1_Load(object sender, EventArgs e)
		{
		}

        private void Calc_h_Click(object sender, EventArgs e)
        {
            var hier = new Hierarhy()
            {
                AmoutOfRecords = Double.Parse(c_h.Text),
                TimeToRun = Double.Parse(tn_h.Text),
                TimeToSearch = Double.Parse(tc_h.Text),
                R = Int32.Parse(r_h.Text),
            };
            hier.Fill(this);
        }

        private void Calc_c_Click(object sender, EventArgs e)
        {
            var circle = new Circle()
            {
                AmoutOfRecords = Double.Parse(c_c.Text),
                TimeToRun = Double.Parse(tn_c.Text),
                TimeToSearch = Double.Parse(tc_c.Text)
            };
            circle.Fill(this);
        }

	    private void Click()
	    {
	        
	    }
		

      
	}
}
