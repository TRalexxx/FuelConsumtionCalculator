using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelConsumtionCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            lChoose = new Label();
            lChoose.Text = "Сhoose what you want to calculate";
            lChoose.TextAlign = ContentAlignment.TopCenter;
            lChoose.Size = new Size(300, 20);
            lChoose.Location = new Point(50, 10);
            this.Controls.Add(lChoose);

            calcList = new ComboBox();
            calcList.Items.Add("Distance, km");
            calcList.Items.Add("Average consumption, l/100 km");
            calcList.Items.Add("Fuel volume, l");
            calcList.Size = new Size(300, 70);
            calcList.Location = new Point(50, 30);
            calcList.Font = new Font("Times new roman", 15);
            calcList.SelectedIndex = 0;
            calcList.SelectedIndexChanged += calclist_SelectedIndexChanged;
            this.Controls.Add(calcList);


            litres_L = new Label();
            litres_L.Text = "Fuel volume, l";
            litres_L.TextAlign = ContentAlignment.TopCenter;
            litres_L.Size = new Size(300, 20);
            litres_L.Location = new Point(50, 90);
            this.Controls.Add(litres_L);

            txtBxFirst = new TextBox();
            txtBxFirst.ShortcutsEnabled = false;
            txtBxFirst.ContextMenu = new ContextMenu();
            txtBxFirst.Size = new Size(300, 70);
            txtBxFirst.Location = new Point(50, 110);
            txtBxFirst.Font = new Font("Times new roman", 15);
            txtBxFirst.KeyDown += new KeyEventHandler(TxtBxFirst_KeyDown);
            txtBxFirst.KeyPress += new KeyPressEventHandler(TxtBxFirst_KeyPress);
            this.Controls.Add(txtBxFirst);

            consumption_L = new Label();
            consumption_L.Text = "Fuel consumption, l/100 km";
            consumption_L.TextAlign = ContentAlignment.TopCenter;
            consumption_L.Size = new Size(300, 20);
            consumption_L.Location = new Point(50, 170);
            this.Controls.Add(consumption_L);

            distance_L = new Label();
            distance_L.Text = "Distance, km";
            distance_L.TextAlign = ContentAlignment.TopCenter;
            distance_L.Size = new Size(300, 20);
            distance_L.Location = new Point(50, 170);
            distance_L.Visible = false;
            this.Controls.Add(distance_L);

            txtBxSecond = new TextBox();
            txtBxSecond.ShortcutsEnabled = false;
            txtBxSecond.ContextMenu = new ContextMenu();
            txtBxSecond.Size = new Size(300, 70);
            txtBxSecond.Location = new Point(50, 190);
            txtBxSecond.Font = new Font("Times new roman", 15);
            txtBxSecond.KeyDown += new KeyEventHandler(TxtBxSecond_KeyDown);
            txtBxSecond.KeyPress += new KeyPressEventHandler(TxtBxSecond_KeyPress);
            this.Controls.Add(txtBxSecond);

            lAnswer = new Label();
            lAnswer.Text = "Result";
            lAnswer.TextAlign = ContentAlignment.TopCenter;
            lAnswer.Size = new Size(300, 30);
            lAnswer.Font = new Font("Times new roman", 15);
            lAnswer.Location = new Point(50, 240);
            this.Controls.Add(lAnswer);


            btnCalc = new Button();
            btnCalc.Text = "Calculate";
            btnCalc.ForeColor = Color.Black;
            btnCalc.Size = new Size(120, 60);
            btnCalc.Location = new Point(140, 320);
            btnCalc.Font = new Font("Times new roman", 16);
            this.Controls.Add(btnCalc);
            btnCalc.Click += btnCalc_Click;

            result = new TextBox();
            result.Size = new Size(300, 70);
            result.Location = new Point(50, 270);
            result.Font = new Font("Times new roman", 15);
            result.ReadOnly = true;
            this.Controls.Add(result);

        }

        private bool nonNumberEntered = false;

        private void TxtBxSecond_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
        }

        private void TxtBxFirst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (txtBxFirst.Text != "" && txtBxSecond.Text != "")
            {
                if (calcList.SelectedIndex == 0)
                {
                    result.Text = (Double.Parse(txtBxFirst.Text) / Double.Parse(txtBxSecond.Text) * 100).ToString();
                }
                else if (calcList.SelectedIndex == 1)
                {
                    result.Text = (Double.Parse(txtBxFirst.Text) * 100 / Double.Parse(txtBxSecond.Text)).ToString();
                }
                else
                {
                    result.Text = (Double.Parse(txtBxFirst.Text) * Double.Parse(txtBxSecond.Text) / 100).ToString();
                }

            }
        }

        private void TxtBxSecond_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        if (e.KeyCode != Keys.Oemcomma || (sender as TextBox).Text.IndexOf(',') > -1 || ((sender as TextBox).Text.Length == 0 && e.KeyCode == Keys.Oemcomma))
                            nonNumberEntered = true;
                    }
                }
            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void TxtBxFirst_KeyDown(object sender, KeyEventArgs e)
        {

            nonNumberEntered = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        if (e.KeyCode != Keys.Oemcomma || (sender as TextBox).Text.IndexOf(',') > -1 || ((sender as TextBox).Text.Length == 0 && e.KeyCode == Keys.Oemcomma))
                        {
                            if (e.Control == true || e.Modifiers == Keys.Control)
                                e.Handled = true;
                            nonNumberEntered = true;
                        }
                    }
                }
            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void calclist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (calcList.SelectedIndex == 0)
            {
                litres_L.Visible = true;
                consumption_L.Visible = true;
                distance_L.Visible = false;
            }
            else if (calcList.SelectedIndex == 1)
            {
                consumption_L.Visible = false;
                litres_L.Visible = true;
                distance_L.Location = new Point(consumption_L.Location.X, consumption_L.Location.Y);
                distance_L.Visible = true;
            }
            else
            {
                litres_L.Visible = false;
                consumption_L.Visible = true;
                distance_L.Location = new Point(litres_L.Location.X, litres_L.Location.Y);
                distance_L.Visible = true;
            }
        }

        Label lChoose;
        Label litres_L;
        Label consumption_L;
        Label distance_L;
        Label lAnswer;

        ComboBox calcList;
        TextBox txtBxFirst;
        TextBox txtBxSecond;
        TextBox result;

        Button btnCalc;
    }

}
