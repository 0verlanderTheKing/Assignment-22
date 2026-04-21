using System;
using System.Windows.Forms;

namespace Assignment_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();         
            shape.SelectedIndex = 0;      
            UpdateLabels();
        }

        private void selectChange(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            firstInputBox.Clear();
            secondInputBox.Clear();          
            firstInputBox.Focus();
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            if (SelectedShape == "Circle")
            {
                firstLabel.Text = "Radius:";
                secondLabel.Text = "";
                secondInputBox.Enabled = false;
                secondInputBox.Visible = false;
                secondLabel.Visible = false;
            }
            else if (SelectedShape == "Rectangle")
            {
                firstLabel.Text = "Width:";
                secondLabel.Text = "Length:";
                secondInputBox.Enabled = true;
                secondInputBox.Visible = true;
                secondLabel.Visible = true;
            }
            else if (SelectedShape == "Cylinder")
            {
                firstLabel.Text = "Radius:";
                secondLabel.Text = "Height:";
                secondInputBox.Enabled = true;
                secondInputBox.Visible = true;
                secondLabel.Visible = true;
            }
        }

        private bool emptySpace(string text)
        {
            return text == null || text.Trim() == "";
        }

        private string SelectedShape => shape.SelectedItem?.ToString() ?? "Circle";

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double firstValue = 0;
            double secondValue = 0;
            double answer = 0;

            try
            {
                if (emptySpace(firstInputBox.Text))
                {
                    MessageBox.Show("Invalid input");
                    firstInputBox.Focus();
                    return;
                }

                firstValue = double.Parse(firstInputBox.Text);

                if (firstValue < 0)
                {
                    MessageBox.Show("Invalid input");
                    firstInputBox.Focus();
                    return;
                }

                if (SelectedShape == "Circle")
                {
                    answer = Area.CalculateArea(firstValue);
                    resultLabel.Text = "Circle area: " + Math.Round(answer, 1);
                }
                else if (SelectedShape == "Rectangle")
                {
                    if (emptySpace(secondInputBox.Text))
                    {
                        MessageBox.Show("Invalid input");
                        secondInputBox.Focus();
                        return;
                    }

                    secondValue = double.Parse(secondInputBox.Text);

                    if (secondValue < 0)
                    {
                        MessageBox.Show("Invalid input");
                        secondInputBox.Focus();
                        return;
                    }

                    answer = Area.CalculateAreaRectangle(firstValue, secondValue);
                    resultLabel.Text = "Rectangle area: " + Math.Round(answer, 1);
                }
                else if (SelectedShape == "Cylinder")
                {
                    if (emptySpace(secondInputBox.Text))
                    {
                        MessageBox.Show("Invalid input");
                        secondInputBox.Focus();
                        return;
                    }

                    secondValue = double.Parse(secondInputBox.Text);

                    if (secondValue < 0)
                    {
                        MessageBox.Show("Invalid input");
                        secondInputBox.Focus();
                        return;
                    }

                    answer = Area.CalculateAreaCylinder(firstValue, secondValue);
                    resultLabel.Text = "Cylinder area: " + Math.Round(answer, 1);
                }
            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            shape.SelectedIndex = 0;
            firstInputBox.Clear();
            secondInputBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}