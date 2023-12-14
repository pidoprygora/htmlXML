using System.Collections.Generic;
using System.Xml;

namespace htmlXML
{
    public class DOM : IParse
    {
        XmlDocument doc = new XmlDocument();
        //private List<Search> find = null;

        public List<Search> AnalyzeFile(Search mySearch, string path)
        {
            doc.Load(path);
            List<List<Search>> info = new List<List<Search>>();

            if (mySearch.faculty == null && mySearch.day == null && mySearch.orientation == null && mySearch.leader == null)
            {
                return ErrorCatch(doc);
            }

            if (mySearch.faculty != null) info.Add(SearchByAttribute("Club", "FACULTY", mySearch.faculty, doc));
            if (mySearch.faculty != null) info.Add(SearchByAttribute("Club", "DAY", mySearch.day, doc));
            if (mySearch.faculty != null) info.Add(SearchByAttribute("Club", "LEADER", mySearch.leader, doc));
            if (mySearch.faculty != null) info.Add(SearchByAttribute("Club", "ORIENTATION", mySearch.orientation, doc));

            return Cross(info, mySearch);
        }

        public List<Search> SearchByAttribute(string nodeName, string attribute, string myTemplate, XmlDocument doc)
        {
            List<Search> find = new List<Search>();

            if (myTemplate != null)
            {
                XmlNodeList lst = doc.SelectNodes("//" + nodeName + "[@" + attribute + "=\"" + myTemplate + "\"]");

                foreach (XmlNode e in lst)
                {
                    find.Add(Info(e));
                }
            }
            return find;
        }
        public List<Search> ErrorCatch(XmlDocument doc)
        {
            List<Search> result = new List<Search>();
            XmlNodeList lst = doc.SelectNodes("//" + "Club");

            foreach (XmlNode elem in lst)
            {
                result.Add(Info(elem));
            }
            return result;
        }

        public Search Info(XmlNode node)
        {
            Search search = new Search();

            search.nameC = node.Attributes.GetNamedItem("NAME").Value;
            search.faculty = node.Attributes.GetNamedItem("FACULTY").Value;
            search.day = node.Attributes.GetNamedItem("DAY").Value;
            search.leader = node.Attributes.GetNamedItem("LEADER").Value;
            search.orientation = node.Attributes.GetNamedItem("ORIENTATION").Value;
            return search;
        }

        public List<Search> Cross(List<List<Search>> list, Search myTemplate)
        {
            List<Search> result = new List<Search>();
            List<Search> clear = CheckNodes(list, myTemplate);

            foreach (Search elem in clear) 
            {
                bool isIn = false;
                foreach (Search s in result) 
                {
                    if (s.Compare(elem))
                    { isIn = true; }
                }

                if(!isIn) { result.Add(elem); } 
            }
            return result;
        }

        public List<Search> CheckNodes(List<List<Search>> list, Search myTemplate)
        {
            List<Search> newResult = new List<Search>();
            foreach(List<Search> elem in list)
            {
                foreach (Search s in elem)
                {
                    if ((myTemplate.faculty == s.faculty || myTemplate.faculty == null)&&
                        (myTemplate.day == s.day || myTemplate.day == null) &&
                        (myTemplate.leader == s.leader || myTemplate.leader == null) &&
                        (myTemplate.orientation == s.orientation || myTemplate.orientation == null))
                    {
                        newResult.Add(s);
                    }
                }
            }
            return newResult;
        }

        public List<Search> AnalazeFiles(Search MySearch, string path)
        {
            throw new System.NotImplementedException();
        }
    }
}
