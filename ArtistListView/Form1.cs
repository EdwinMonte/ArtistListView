using System.Data.SqlTypes;
using System.Xml;

namespace ArtistListView
{
    public partial class Form1 : Form
    {
        String URLString;
        XmlTextReader reader;
        public Form1()
        {
            InitializeComponent();
            URLString = "https://www.w3schools.com/xml/cd_catalog.xml";
            lstvartist.View = View.Details;
            reader = new XmlTextReader(URLString);

            AddValue(URLString);
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:

                        if (lstvartist.Columns.Count < 8)
                        {
                            lstvartist.Columns.Add(reader.Name);

                            if (lstvartist.Columns.Count > 6)
                            {
                                lstvartist.Columns.RemoveAt(0);
                            }
                        }





                        break;


                }
            }
        }


        private void AddValue(String path)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            XmlNodeList nodeList = xmlDoc.SelectNodes(" / CATALOG / CD");
            foreach (XmlNode node in nodeList)
            {

                string artist = node.SelectSingleNode("ARTIST").InnerText; ;
                string title = node.SelectSingleNode("TITLE").InnerText; ;
                string year = node.SelectSingleNode("YEAR").InnerText; ;
                string company = node.SelectSingleNode("COMPANY").InnerText; ;
                string price = node.SelectSingleNode("PRICE").InnerText; ;
                string country = node.SelectSingleNode("COUNTRY").InnerText; ;




                ListViewItem item = new ListViewItem(new string[] { artist, title, year, company, price, country });
                lstvartist.Items.Add(item);
            }

            foreach (ColumnHeader column in lstvartist.Columns)
            {
                column.Width = 5;
            }
        }
    }
}
        

        
    

