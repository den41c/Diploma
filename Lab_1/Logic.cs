using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ZedGraph;

namespace Lab_1
{
    public static class GrafParams
    {
        public static double Step = 1;
        public static Func<double, double> MaxNFunc = (a) => { return a * 2.7; };

        public static void FillGraf(ZedGraphControl graf, Result result)
        {
            
            var panel = graf.GraphPane;

            panel.CurveList.Clear();
            panel.GraphObjList.Clear();
            panel.Title.Text = "Графік";
            panel.XAxis.Title.Text = "N";
            panel.YAxis.Title.Text = "T";


            //для первой табл.
            panel.XAxis.Scale.Max = MaxNFunc(result.N);

            //Устанавливаем интересующий нас интервал по оси Y 
            //для первой табл.
            var max = result.Graf.Values.Where(x => !double.IsPositiveInfinity(x)).Max();
            panel.YAxis.Scale.Max = max + max*0.05;

            // Установим цвет осей
            panel.XAxis.Color = Color.Gray;
            panel.YAxis.Color = Color.Gray;

            // Включим сетку
            //panel.XAxis.MajorGrid.IsVisible = true;
            //panel.YAxis.MajorGrid.IsVisible = true;
            PointPairList list = new PointPairList();
            foreach (var n in result.Graf.Keys)
            {
                list.Add(n, result.Graf[n]);
            }
            panel.AddCurve("", list, Color.Black, SymbolType.None);

            // Установим цвет заголовка над графиком
            panel.Title.FontSpec.FontColor = Color.Black;
            panel.Title.FontSpec.IsBold = true;

            //Вызываем метод AxisChange(), чтобы обновить данные  об осях
            //В противном случае на рисунке будет показана только часть графика,
            //которая уменшается в интервалы по осям, установленные по умолчанию
            graf.AxisChange();

            //Обновляем график
            graf.Invalidate();
        }
    }

    internal abstract class AParams
    {
        public double TimeToSearch { get; set; }

        public double TimeToRun { get; set; }

        public double AmoutOfRecords { get; set; }

        public int R { get; set; }
    }

    public interface IFiller
    {
        void Fill(Form form);
    }
    public class Result
    {
        public double N;
        public double L;
        public Dictionary<double, double> Graf;
    }

    class Hierarhy : AParams, IFiller
    {
        private Result calc()
        {
            var n_opt = (int)Math.Truncate(
                         AmoutOfRecords *
                         TimeToSearch *
                         Math.Log(R) /
                         (2*TimeToRun));//todo formula 
            var res = new Result()
            {
                N = n_opt,
                L = (int) (Math.Ceiling(Math.Log(n_opt)/Math.Log(R)))
            };
			
            res.Graf = new Dictionary<double, double>();

            for (double n = 1; n < GrafParams.MaxNFunc(n_opt); n += GrafParams.Step)
			{
                res.Graf.Add(n,(AmoutOfRecords*TimeToSearch/n) + (Math.Ceiling((Math.Log(n)/Math.Log(R))+1) * 2 * TimeToRun));
			}
            
            return res;
        }

        public void Fill(Form form)
        {
            var res = calc();
            var N = form.Controls.Find("N_h", true).First() as TextBox;
            var L = form.Controls.Find("L_h", true).First() as TextBox;
            var graf = form.Controls.Find("g_h", true).First() as ZedGraphControl;

            N.Text = res.N.ToString();
            L.Text = res.L.ToString();
            GrafParams.FillGraf(graf, res);

        }
    }

    class Circle : AParams, IFiller
    {
        private Result calc()
        {
            var n_opt = (int)Math.Sqrt((2 * (AmoutOfRecords * TimeToSearch - TimeToRun)) / TimeToRun);
            var res = new Result()
            {
                N = n_opt
            };
            res.Graf = new Dictionary<double, double>();

            for (double n = 1; n < GrafParams.MaxNFunc(n_opt); n += GrafParams.Step)
            {
                res.Graf.Add(n,
                    (AmoutOfRecords * TimeToSearch / n) + (((Math.Floor((double)n / 2) + 1) * (n + 1)) * TimeToRun / n));
            }
            
            return res;
        }

        public void Fill(Form form)
        {
            var res = calc();
            var N = form.Controls.Find("N_c", true).First() as TextBox;
            var graf = form.Controls.Find("g_c", true).First() as ZedGraphControl;
            N.Text = res.N.ToString();
            GrafParams.FillGraf(graf, res);
        }
    }
}
