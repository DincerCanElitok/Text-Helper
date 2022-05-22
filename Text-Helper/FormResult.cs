using System.Windows.Forms;
using System.IO;
using System.Data;
using System;

namespace Text_Helper
{
    public partial class FormResult : Form
    {
        DataTable dataTable = new DataTable();
        Concrete.Text_Manager text_Manager = new Concrete.Text_Manager();
        public FormResult()
        {
            InitializeComponent();
        }
        private void FormResult_Load(object sender, System.EventArgs e)
        {
            if(File.Exists(text_Manager.path_data))
            {
                string txt = File.ReadAllText(text_Manager.path_data);
                string[] source = txt.Split(text_Manager.determiner);
                string analyze_keyword = source[0];
                string count = source[2];

                //data grid view format
                dataTable.Columns.Add("Keyword"); 
                dataTable.Columns.Add("Source");
                dataTable.Columns.Add("Approximate Count");
                dataTable.Columns.Add("Ratio");

                string[] row = {analyze_keyword, "Your Text", count, "1" };
                dataTable.Rows.Add(row);
                result_dataGrid.DataSource = dataTable;
            }
            else
            {
                result_Label_info.Text = "You have to analyze at least one keyword in analyze section";
            }
            

        }

        private void resultBtn_calculate_Click(object sender, System.EventArgs e)
        {
            
            if (File.Exists(text_Manager.path_sites) && File.Exists(text_Manager.path_data))
            {
                lbl_Result_title.Text = "Calculating...";
                string txt = File.ReadAllText(text_Manager.path_data);
                string[] source = txt.Split(text_Manager.determiner);
                string analyze_keyword = source[0];
                string count = source[2];
                string[] sites = File.ReadAllLines(text_Manager.path_sites);
                string webSiteCount = "";
                File.WriteAllText(text_Manager.path_counts, webSiteCount);
                for (int i = 0; i < sites.Length; i++)
                {
                    if (File.Exists(text_Manager.path_counts) && File.ReadAllText(text_Manager.path_counts) != null)
                    {
                        webSiteCount = text_Manager.WebSiteWordCount(sites[i]).ToString();
                        File.AppendAllText(text_Manager.path_counts, webSiteCount + "\r\n");
                        string[] row = {analyze_keyword,sites[i],webSiteCount,
                            (Convert.ToDouble(webSiteCount)/Convert.ToDouble(count)).ToString() };
                        dataTable.Rows.Add(row);
                    }
                    else
                    {
                        webSiteCount = text_Manager.WebSiteWordCount(sites[i]).ToString();
                        File.WriteAllText(text_Manager.path_counts, webSiteCount + "\r\n");
                        string[] row = {analyze_keyword,sites[i],webSiteCount,
                            (Convert.ToDouble(webSiteCount)/Convert.ToDouble(count)).ToString() };
                        dataTable.Rows.Add(row);
                    }
                }
                lbl_Result_title.Text = "Result";
            }
            else
            {
                MessageBox.Show("You have to analyze at least one keyword in analyze section");
            }
        }
    }
}
