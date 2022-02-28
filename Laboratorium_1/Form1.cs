using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorium_1
{
    public partial class Form : System.Windows.Forms.Form
    {
        Dictionary<float, float> CirclePositions = new Dictionary<float, float>();
        Dictionary<float, float> SquarePositions = new Dictionary<float, float>();

        bool ifControlOn = false;
        bool ifLeftMouseButtonOn = false;
        bool ifCircle = false;
        bool ifSquare = false;

        public Form()
        {
            InitializeComponent();
            controlBox.Text = "Off";
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = Panel.CreateGraphics();
            foreach (var circle in CirclePositions)
            {
                g.FillEllipse(Brushes.Red, circle.Key - 40, circle.Value- 40, 80, 80);
            }
            foreach (var square in SquarePositions)
            {
                g.FillRectangle(Brushes.Blue, square.Key - 40, square.Value - 40, 80, 80);
            }
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            coordBox.Text = $"X: {e.X}, Y: {e.Y}";
            mouseBox.Text = $"{e.Button}";

            if (e.Button == MouseButtons.Left)
            {
                ifLeftMouseButtonOn = true;
            }
            else
            {
                ifLeftMouseButtonOn = false;
            }

            if (ifControlOn && ifLeftMouseButtonOn)
            {
                Graphics g = Panel.CreateGraphics();
                try
                {
                    foreach (var circle in CirclePositions)
                    {
                        if (e.X >= circle.Key - 40 && e.X <= circle.Key + 40 && e.Y >= circle.Value - 40 && e.Y <= circle.Value + 40)
                        {
                            g.FillEllipse(Brushes.White, circle.Key - 40, circle.Value - 40, 80, 80);
                            CirclePositions.Remove(circle.Key);
                            ifSquare = false;
                        }
                    }
                    foreach (var square in SquarePositions)
                    {
                        if (e.X >= square.Key - 40 && e.X <= square.Key + 40 && e.Y >= square.Value - 40 && e.Y <= square.Value + 40)
                        {
                            g.FillRectangle(Brushes.White, square.Key - 40, square.Value - 40, 80, 80);
                            SquarePositions.Remove(square.Key);
                            ifSquare = true;
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                ErrorBox.Text = "";
                try
                {
                    Graphics g = Panel.CreateGraphics();
                    g.FillEllipse(Brushes.Red, e.X - 40, e.Y - 40, 80, 80);
                    CirclePositions.Add(e.X, e.Y);
                }
                catch (Exception)
                {
                    ErrorBox.Text = "Figures cant be painted in the same positions";
                }
            }

            if ((e.Button & MouseButtons.Right) == MouseButtons.Right || (e.Button & MouseButtons.Left) == MouseButtons.Left && ifSquare)
            {
                ErrorBox.Text = "";
                try
                {
                    Graphics g = Panel.CreateGraphics();
                    g.FillRectangle(Brushes.Blue, e.X - 40, e.Y - 40, 80, 80);
                    SquarePositions.Add(e.X, e.Y);
                }
                catch (Exception)
                {
                    ErrorBox.Text = "Figures cant be painted in the same positions";
                }
            }
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.ControlKey)
            {
                ifControlOn = true;
                controlBox.Text = "On";
            }
            else
            {
                ifControlOn = false;
                controlBox.Text = "Off";
            }
        }

        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
