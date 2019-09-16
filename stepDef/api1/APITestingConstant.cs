using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.stepDef.api1
{
    class APITestingConstant
    {
        public static string URL = "https://reqres.in";
        public struct JsonDataForSucessfulWithStatuscode
        {
            public int id;
            public string token;
            public int statusCode;
        }

    }
}
