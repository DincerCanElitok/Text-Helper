using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace Text_Helper
{
    public partial class FormGraphic : Form
    {
        Concrete.Text_Manager text_Manager = new Concrete.Text_Manager();
        public FormGraphic()
        {
            InitializeComponent();
        }

        private void FormGraphic_Load(object sender, System.EventArgs e)
        {

            //cheking files, must be used analyze section and result section
            if (File.Exists(text_Manager.path_counts) && File.Exists(text_Manager.path_sites))
            {
                string txt = File.ReadAllText(text_Manager.path_data);
                string[] source = txt.Split(text_Manager.determiner);
                string your_text_count = source[2];

                //adding site word counts and sites to array 
                string[] sites = File.ReadAllLines(text_Manager.path_sites);
                string[] counts = File.ReadAllLines(text_Manager.path_counts);

                //resizing counts array for adding users word counts
                Array.Resize(ref counts, counts.Length + 1);
                counts[counts.Length-1]= your_text_count;

                //finding max number to determine max value of trackbars
                int[] count_numbers = Array.ConvertAll(counts, int.Parse);
                int max = count_numbers.Max();

                //resize counts array to orginal size
                counts = counts.Take(counts.Count() - 1).ToArray();

                //finding all trackbars and labels in their spesific panels
                List<TrackBar> pillars = graphic_Panel_pillars.Controls.OfType<TrackBar>().OrderBy(x => x.Name).ToList();
                List<Label> countLabels = graphic_Panel_counts.Controls.OfType<Label>().OrderBy(x => x.Name).ToList();
                
                //removing users trackbar and label from lists
                pillars.Remove(graphic_TrackBar_yourtext);
                countLabels.Remove(graphic_lbl_count_yourtext);

                //setting values to labels and trackbars
                graphic_TrackBar_yourtext.Maximum = max;
                graphic_TrackBar_yourtext.Value = Convert.ToInt32(your_text_count);
                graphic_lbl_count_yourtext.Text = your_text_count;
                for (int i=0;i<counts.Length;i++)
                {
                    pillars[i].Maximum = max;
                    pillars[i].Value =Convert.ToInt32(counts[i]);
                    countLabels[i].Text = counts[i];
                }
            }
            else
            {
                MessageBox.Show("You have to analyze at least one keyword in analyze section than use calculate button in result section");
            }
        }


    }
}
