using Amazon.DynamoDBv2.DocumentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace htmlXML
{
    public interface IParse
    {
        List<Search> AnalazeFiles(Search MySearch, string path);
    }
}
