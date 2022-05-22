using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace Text_Helper
{
    public partial class FormAnalyze : Form
    {
        Concrete.Text_Manager text_Manager = new Concrete.Text_Manager();
        Abstract.Apis apis = new Abstract.Apis();

        public FormAnalyze()
        {
            InitializeComponent();
            
        }
        private void FormAnalyze_Load(object sender, System.EventArgs e)
        {
            //checking saved file exist
            if (File.Exists(text_Manager.path_data)) 
            {
                string txt = File.ReadAllText(text_Manager.path_data);
                string[] source = txt.Split(text_Manager.determiner);
                analyze_textbox_keyword.Text = source[0];
                analyze_textbox.Text = source[1];
            }
            else
            {
                analyze_textbox.Text = "You can put your text here"; 
            }
        }
        private void analyze_button_Click(object sender, System.EventArgs e)
        {
            //keyword counting in source text
            string count = text_Manager.WordCount(analyze_textbox.Text, analyze_textbox_keyword.Text).ToString(); 
            //saving keyword, source text and keyword count number
            File.WriteAllText(text_Manager.path_data, analyze_textbox_keyword.Text + text_Manager.determiner + 
                analyze_textbox.Text + text_Manager.determiner + count);

            // Your google API KEY
            string APIkey = apis.API;
            //Google programmable search engine identifier
            string cx = apis.cx;  

            //Json api request
            var request = WebRequest.Create("https://www.googleapis.com/customsearch/v1?key=" + APIkey + "&cx=" + cx + "&q=" + analyze_textbox_keyword.Text);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseString = reader.ReadToEnd();
            dynamic jsonData = JsonConvert.DeserializeObject(responseString);

            //if you wanna check json data comment out the code below
            //analyze_textbox.Text = responseString; 

            //clearing saved data if it is exists
            File.WriteAllText(text_Manager.path_sites, "");

            //for saving json data
            var results = new List<Abstract.Search_Engine_Format>(); 
            foreach (var item in jsonData.items)
            {
                //Maybe you would like to save some part of json data you can use this class 
                results.Add(new Abstract.Search_Engine_Format                                                              
                {
                    Title = item.title, 
                    Link = item.link,
                    Snippet = item.snippet,
                    FormattedUrl = item.formattedurl
                });
                //saving websites from google search
                File.AppendAllText(text_Manager.path_sites, item.link.ToString() + "\r\n");               
            }
            MessageBox.Show("Analyze is completed");
        }
        
    }
    
}
