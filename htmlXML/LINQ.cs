using Amazon.DynamoDBv2.DocumentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace htmlXML
{
    public class LinqToXml : IParse
    {
        private List<Search> find = null;

        XDocument doc = new XDocument();

        public List<Search> AnalazeFiles(Search MySearch, string path)
        {
            throw new NotImplementedException();
        }

        public List<Search> AnalyzerFile(Search mySearch, string path)
        {
            doc = XDocument.Load(path);
            find = new List<Search>();
            List<XElement> matches = (from val in doc.Descendants("Club")
                                      where ((mySearch == null || mySearch.nameC == val.Attribute("NAME").Value) &&
                                      (mySearch == null || mySearch.faculty == val.Attribute("FACULTY").Value) &&
                                      (mySearch == null || mySearch.day == val.Attribute("DAY").Value) &&
                                      (mySearch == null || mySearch.leader == val.Attribute("LEADER").Value) &&
                                      (mySearch == null || mySearch.orientation == val.Attribute("ORIENTATION").Value))
                                      select val).ToList();

            foreach (XElement match in matches)
            {
                Search res = new Search();
                res.nameC = match.Attribute("NAME").Value;
                res.faculty = match.Attribute("FACULTY").Value;
                res.day = match.Attribute("DAY").Value;
                res.leader = match.Attribute("LEADER").Value;
                res.orientation = match.Attribute("ORIENTATION").Value;
                find.Add(res);
            }
            return find;
        }
    }
}
