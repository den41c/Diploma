using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Serialization;

namespace Diplom
{

    public enum TypeOfWeb
    {
        Hierarhy = 0,
        Circle = 1
    }

    public class CalcParams : IParams
    {
        private MainWindow window;

        public CalcParams(MainWindow mainWindow)
        {
            window = mainWindow;
        }

        public TypeOfWeb Type
        {
            get { return (TypeOfWeb) window.tabs.SelectedIndex; }
        }

        public double TimeToRun
        {
            get { return Double.Parse(window.tn_tb_c.Text); }
        }

        public double TimeToSearch
        {
            get
            {
                ((ContentControl) ((TabItem) window.tabs.SelectedItem).Content).FindName("");

                return Double.Parse(window.tc_tb_h.Text);
            }
        }

        public double AmoutOfRecords
        {
            get { return Int32.Parse(window.r_tb.Text); }
        }

        public int R
        {
            get { return Int32.Parse(window.r_tb.Text); }
        }

        void IParams.Calc()
        {
            switch (Type)
            {
                case TypeOfWeb.Hierarhy:
                    calcHierarhy();
                    break;
                case TypeOfWeb.Circle:
                    calcCircle();
                    break;
            }
        }

        private void calcCircle()
        {
            N = (int) Math.Round(Math.Sqrt((2*AmoutOfRecords*TimeToSearch/TimeToRun)));
        }

        private void calcHierarhy()
        {
            var n = (int)Math.Truncate(
                        AmoutOfRecords *
                        TimeToSearch *
                        Math.Log(R) /
                        TimeToRun);

            N = n;
            L = (int) (Math.Ceiling(Math.Log(n)/Math.Log(R)));

        }

        private int N
        {
            set { window.result_n_h.Text = value.ToString(); }
        }

        private int L
        {
            set
            {
                var name = Enum.GetName(typeof (TypeOfWeb), Type);
                window.result_l.Text = value.ToString();
            }
        }
    }

}