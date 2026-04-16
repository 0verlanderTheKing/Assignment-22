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

        private void shape_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLabels();
            firstInputBox.Clear();
            secondInputBox.Clear();
            resultLabel.Text = "";
            firstInputBox.Focus();
        }
        private void UpdateLabels()
        {
            string selectedShape = shape.SelectedItem.ToString();

            if (selectedShape == "Circle")
            {
                firstLabel.Text = "Radius:";
                secondLabel.Text = "";
                secondInputBox.Enabled = false;
                secondInputBox.Visible = false;
                secondLabel.Visible = false;
            }
            else if (selectedShape == "Rectangle")
            {
                firstLabel.Text = "Width:";
                secondLabel.Text = "Length:";
                secondInputBox.Enabled = true;
                secondInputBox.Visible = true;
                secondLabel.Visible = true;
            }
            else if (selectedShape == "Cylinder")
            {
                firstLabel.Text = "Radius:";
                secondLabel.Text = "Height:";
                secondInputBox.Enabled = true;
                secondInputBox.Visible = true;
                secondLabel.Visible = true;
            }
        }
        private bool TryGetValue(TextBox box, string name, out double value)
        {
            value = 0;

            if (string.IsNullOrWhiteSpace(box.Text))
            {
                MessageBox.Show("Invalid input");
                box.Focus();
                return false;
            }
            if (!double.TryParse(box.Text, out value))
            {
                MessageBox.Show("Invalid input");
                box.Focus();
                return false;
            }
            if (value < 0)
            {
                MessageBox.Show("Invalid input");
                box.Focus();
                return false;
            }

            return true;
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            string selectedShape = shape.SelectedItem.ToString();
            double firstValue;
            double secondValue;
            double answer;

            if (selectedShape == "Circle")
            {
                if (TryGetValue(firstInputBox, "radius", out firstValue))
                {
                    answer = Area.CalculateArea(firstValue);
                    resultLabel.Text = "Circle area: " + answer.ToString("F2");
                }
            }
            else if (selectedShape == "Rectangle")
            {
                if (TryGetValue(firstInputBox, "width", out firstValue) &&
                    TryGetValue(secondInputBox, "length", out secondValue))
                {
                    answer = Area.CalculateArea(firstValue, secondValue);
                    resultLabel.Text = "Rectangle area: " + answer.ToString("F2");
                }
            }
            else if (selectedShape == "Cylinder")
            {
                if (TryGetValue(firstInputBox, "radius", out firstValue) &&
                    TryGetValue(secondInputBox, "height", out secondValue))
                {
                    answer = Area.CalculateArea(firstValue, secondValue, true);
                    resultLabel.Text = "Cylinder area: " + answer.ToString("F2");
                }
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            firstInputBox.Clear();
            secondInputBox.Clear();
            resultLabel.Text = "";
            shape.SelectedIndex = 0;
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}