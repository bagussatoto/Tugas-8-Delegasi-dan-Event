using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCalculator
{
    public partial class FormCalculator : Form
    {
        private IList<Calculator> listOfCalculator = new List<Calculator>();
        public FormCalculator()
        {
            InitializeComponent();
        }
        private void FormEntry_OnCreate(Calculator cal)
        {
            listOfCalculator.Add(cal);
            listBox1.Items.Add(cal.Hasil);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ForrmEntryCalculator formEntry = new ForrmEntryCalculator("Calculator");
            formEntry.OnCreate += FormEntry_OnCreate;
            formEntry.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
