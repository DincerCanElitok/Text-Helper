using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Text_Helper.Concrete
{
    public class Text_Manager
    {
        static string saved_data = "saved_data.txt";
        static string saved_sites = "saved_sites.txt";
        static string saved_counts = "saved_counts.txt";
        public string path_data = Path.Combine(Environment.CurrentDirectory, @"Data\", saved_data);
        public string path_sites = Path.Combine(Environment.CurrentDirectory, @"Data\", saved_sites);
        public string path_counts = Path.Combine(Environment.CurrentDirectory, @"Data\", saved_counts);
        public string determiner = "/??//*+/#21*//";
        
        public int WordCount(string source, string keyword)  
        {
            //counting in source text
            int word_count=0;
            string lower_keyword = keyword.ToLower();
            string lower_source = source.ToLower();
            string[] splitsource = lower_source.Split(' ');
            foreach (var word   in splitsource)
            {
                if (word == lower_keyword)
                    word_count += 1;
            }
            return word_count;
        }
        public int WebSiteWordCount(string site) 
        {

            string txt = File.ReadAllText(path_data);
            string[] source = txt.Split(determiner);
            string analyze_keyword = source[0];

            //Downloading raw html file and with HtmlAgilityPack library finding word count
            try
            {
                Uri url = new Uri(site);
                WebClient client = new WebClient();
                client.Encoding = System.Text.Encoding.UTF8;
                client.Headers.Add("User-Agent: Other");
                string html = client.DownloadString(url);
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);

                var nodes = doc.DocumentNode.DescendantsAndSelf();
                string word = analyze_keyword.ToLower();
                int count = 0;
                foreach (var node in nodes)
                {
                    if (node.NodeType == HtmlAgilityPack.HtmlNodeType.Text && node.ParentNode.Name != "script" && node.InnerText.ToLower().Contains(word))
                    {
                        count++;
                    }
                }
                return count;
            }
            catch
            {
                MessageBox.Show("Unableto get data from this site: " + site);
                return 0;
            }
            
        }
    }
}
