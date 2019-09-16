using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Test.stepDef.api3
{
    class APITestingVariable
    {
        public static string URL = "https://reqres.in";
        public struct JsonDataForNumberOfUsersWithStatusCode
        {
            public int page;
            public int per_Page;
            public int Total;
            public int statusCode;
        }
    }
}
