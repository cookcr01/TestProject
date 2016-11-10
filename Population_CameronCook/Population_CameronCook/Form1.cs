using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Population_CameronCook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void citiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.citiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.population);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'population.Cities' table. You can move, or remove it, as needed.
            this.citiesTableAdapter.Fill(this.population.Cities);

        }

        private void btnAverage_Click(object sender, EventArgs e)
        {

            int average = (int) this.citiesTableAdapter.AveragePopulation();
            statLblDisplay.Text = average.ToString("N0");
        }

        private void btnTotalPopulation_Click(object sender, EventArgs e)
        {
            int sum = (int)this.citiesTableAdapter.SumPopulation();
            statLblDisplay.Text = sum.ToString("N0");
            
        }

        private void btnCityHighPop_Click(object sender, EventArgs e)
        {
            int max = (int)this.citiesTableAdapter.MaxPopulation();
            citiesDataGridView.DataSource = citiesTableAdapter.GetDataBySearch(max);
        }

        private void btnCityofLowPop_Click(object sender, EventArgs e)
        {
            int min = (int)this.citiesTableAdapter.MinPopulation();
            citiesDataGridView.DataSource = citiesTableAdapter.GetDataBySearch(min);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {

            citiesDataGridView.DataSource = citiesTableAdapter.GetData();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radBtnMaxPopulation_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void btnSearchByPopulation_Click(object sender, EventArgs e)
        {
            int temp;
            if (!int.TryParse(txtBoxPopulation.Text, out temp))
            {
                statLblDisplay.Text = "invalid input";
            }

            if (radBtnMaxPopulation.Checked == true)
            {
                citiesDataGridView.DataSource = citiesTableAdapter.MxPopulation(temp);
            }else
            {
                citiesDataGridView.DataSource = citiesTableAdapter.MnPopulation(temp);
            }
        }

        private void btnSearchByCityName_Click(object sender, EventArgs e)
        {
            String temp = txtBoxLetter.Text;

            if(radBtnExactMatch.Checked == true)
            {
                citiesDataGridView.DataSource = citiesTableAdapter.ExactMatch(temp);
            }else
            {
                citiesDataGridView.DataSource = citiesTableAdapter.StartsWith(temp);
            }
        }
    }
}
