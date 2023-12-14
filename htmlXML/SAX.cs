using Amazon.DynamoDBv2.DocumentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace htmlXML
{
    public class SAX : IParse
    {
        private List<Search> lastResult = null;
        public List<Search> AnalazeFiles(Search mySearch, string path)
        {
            XmlReader reader = XmlReader.Create(path);

            List<Search> results = new List<Search>();

            Search find = null;
            string name = null;

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element :
                        if (reader.Name == "Club")
                        {
                            find = new Search();
                            while (reader.MoveToNextAttribute())
                            {
                                if (reader.Name == "NAME")
                                {
                                    find.name = reader.Value;
                                }
                                if (reader.Name == "FACULTY")
                                {
                                    find.name = reader.Value;
                                }
                                if (reader.Name == "DAY")
                                {
                                    find.name = reader.Value;
                                }
                                if (reader.Name == "LEADER")
                                {
                                    find.name = reader.Value;
                                }
                                if (reader.Name == "ORIENTATION")
                                {
                                    find.name = reader.Value;
                                }
                                result.Add(find);

                            }
                            
                        }
                        break;

                }
            }
            lastResult = Filter(results, mySearch);
            return lastResult;
        }

        private List<Search> Filter(List<Search> results, Search mySearch)
        {
            throw new NotImplementedException();
        }
    }

    private List<Search> Filter(List<Search> allRes, Search myTemplate)
    {
        List<Search> newResult = new List<Search>();
        if (allRes != null)
        {
            foreach (Search i in allRes)
            {
                if ((myTemplate.faculty == i.faculty || myTemplate.faculty == null) &&
                    (myTemplate.nameC == i.nameC || myTemplate.nameC == null) &&
                    (myTemplate.day == i.day || myTemplate.day == null) &&
                    (myTemplate.leader == i.leader || myTemplate.leader == null) &&
                (myTemplate.orientation == i.orientation || myTemplate.orientation == null))
                {
                    newResult.Add(i);
                }
            }
        }
        return newResult;
    }
}
