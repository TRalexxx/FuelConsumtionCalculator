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
            //calcList.SelectedIndexChanged += calclist_SelectedIndexChanged;
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
            //txtBxFirst.KeyDown += new KeyEventHandler(TxtBxFirst_KeyDown);
            //txtBxFirst.KeyPress += new KeyPressEventHandler(TxtBxFirst_KeyPress);
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
            //txtBxSecond.KeyDown += new KeyEventHandler(TxtBxSecond_KeyDown);
            //txtBxSecond.KeyPress += new KeyPressEventHandler(TxtBxSecond_KeyPress);
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
            //btnCalc.Click += btnCalc_Click;

            result = new TextBox();
            result.Size = new Size(300, 70);
            result.Location = new Point(50, 270);
            result.Font = new Font("Times new roman", 15);
            result.ReadOnly = true;
            this.Controls.Add(result);

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
