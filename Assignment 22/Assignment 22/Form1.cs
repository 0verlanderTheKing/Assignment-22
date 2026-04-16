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
        }

        private void shape_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectShape = shape.SelectedItem.ToString();

            if (selectShape == "Circle")
            {
                inputLabel.Text = "Enter radius:";
            }
            else if (selectShape == "Rectangle")
            {
                inputLabel.Text = "Enter width and length seperated by a comma:";
            }
            else if (selectShape == "Cylinder")
            {
                inputLabel.Text = "Enter radius and height seperated by a comma:";
            }

            textInput.Clear();
            resultLabel.Text = " ";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string selectShape = shape.SelectedItem.ToString();
            string input = textInput.Text.Trim();

            if (selectShape == "Circle")
            {
                if (double.TryParse(input, out double radius))
                {
                    double area = Area.CalculateArea(radius);
                    resultLabel.Text = "Circle area: " + area.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Enter one valid number for the radius.");
                }
            }
            else if (selectShape == "Rectangle")
            {
                string[] parts = input.Split(',');

                if (parts.Length == 2 &&
                    double.TryParse(parts[0].Trim(), out double width) && double.TryParse(parts[1].Trim(), out double length))
                {
                    double area = Area.CalculateArea(width, length);
                    resultLabel.Text = "Rectangle area: " + area.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Enter width and length");
                }
            }
            else if (selectShape == "Cylinder")
            {
                string[] parts = input.Split(',');

                if (parts.Length == 2 &&
                    double.TryParse(parts[0].Trim(), out double radius) && double.TryParse(parts[1].Trim(), out double height))
                {
                    double area = Area.CalculateArea(radius, height, true);
                    resultLabel.Text = "Cylinder result: " + area.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Enter radius and height.");
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            shape.SelectedIndex = 0;
            textInput.Clear();
            resultLabel.Text = " ";
            textInput.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
