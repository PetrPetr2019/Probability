using Numerical_method;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace CalculateProbability
{
    public partial class Form1 : Form
    {
        private Calculator calculator;

        public Form1()
        {
            var Tn = 20.0;
            var To = 0.9;
            var S = 3;
            var ParameterF = 1.0;
            var ParameterFv = 1.5;
            var Eps = 10e-3;
            InitializeComponent();
            textBoxParameterTn.Text = Tn.ToString();
            textBoxParameterTo.Text = To.ToString();
            textBoxParameterS.Text = S.ToString();
            textBoxParameterF.Text = ParameterF.ToString();
            textBoxParameterFv.Text = ParameterFv.ToString();
            textBoxParameterEps.Text = Eps.ToString();
            labelResult.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                button3.Enabled = false;
                var Tn = Convert.ToDouble(textBoxParameterTn.Text);
                var To = Convert.ToDouble(textBoxParameterTo.Text);
                var S = Convert.ToInt32(textBoxParameterS.Text);
                var ParameterF = Convert.ToDouble(textBoxParameterF.Text);
                var ParameterFv = Convert.ToDouble(textBoxParameterFv.Text);
                var Eps = Convert.ToDouble(textBoxParameterEps.Text);
                Functions.Lambda = ParameterF;
                Functions.Mu = ParameterFv;
                progressBar.Maximum = 2 * (S + 1);
                progressBar.Value = 0;
                labelResult.Text = "Запущен расчет. Это может занять некоторое время.";
                calculator = new Calculator(S, Eps, To, Tn, 100);
                calculator.OnProgress += calculator_OnProgress;
                calculator.OnError += calculator_OnError;
                calculator.OnCalculation += calculator_OnCalculation;
                calculator.RunCalculation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calculator_OnCalculation(double value)
        {
            Invoke((MethodInvoker) delegate
            {
                labelResult.Text = "Результат вычисления = " + calculator.CurrentP;
                button3.Enabled = true;
            });
        }

        private void calculator_OnError(string message)
        {
            Invoke((MethodInvoker) delegate
            {
                MessageBox.Show(message);
                calculator.CancelCalculation();
                labelResult.Text = "Результат вычисления = ОШИБОЧНЫЙ РАСЧЕТ";
                progressBar.Value = 0;
            });
        }

        private void calculator_OnProgress(string message, int iteration)
        {
            Invoke((MethodInvoker) delegate
            {
                if (message == "Iteration") progressBar.Value += 1;
                else if (message == "Reset") progressBar.Value = 0;
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (calculator != null && calculator.IsRuning) calculator.CancelCalculation();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (calculator == null) return;
            var dlg = new SaveFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dlg.FilterIndex = 1;
            dlg.RestoreDirectory = true;
            dlg.Title = "Сохранение расчета в файл";
            if (dlg.ShowDialog() == DialogResult.OK)
                if (dlg.FileName != string.Empty)
                    try
                    {
                        var file = new StreamWriter(dlg.FileName);
                        var data = calculator.SaveToText();
                        file.WriteLine(data);
                        file.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не удалось сохранить расчет.");
                    }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int wX;
            int hX;
            double xF, yF;
            double step;
            wX = pictureBox1.Width;
            hX = pictureBox1.Height; //Значение высоты

            // Система Координат
            var flag = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            var flagGraphics = Graphics.FromImage(flag);
            Pen myPen;
            myPen = new Pen(Color.Blue);
            flagGraphics.DrawLine(myPen, 0, hX / 2, wX, hX / 2);
            flagGraphics.DrawLine(myPen, wX / 2, 0, wX / 2, hX);

            // График
            for (step = 0; step <= 2 * Math.PI; step += 0.001)
            {
                xF = step * 25 + wX / 2;
                var tmp = Math.Sin(step);
                tmp *= 50;
                yF = hX / 2 - tmp;
                flag.SetPixel((int) xF, (int) yF, Color.Red);
            }

            pictureBox1.Image = flag;
        }
    }
}

