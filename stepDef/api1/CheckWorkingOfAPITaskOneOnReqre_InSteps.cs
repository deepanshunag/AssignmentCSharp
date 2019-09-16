using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace Test.stepDef.api1
{
    [Binding]
    public class CheckWorkingOfAPITaskOneOnReqre_InSteps
    {
        APITestingConstant.JsonDataForSucessfulWithStatuscode sucessfullReg;
        string idd = "QpwL5tke4Pnpja7X4";
        [Given(@"the Address of the website")]
        public void GivenTheAddressOfTheWebsite()
        {
            Assert.AreEqual(APITestingConstant.URL, "https://reqres.in");
        }
        
        [When(@"I perform POST request on the given address (.*) and pass the  Email (.*) and enter Password (.*)")]
        public void WhenIPerformPOSTRequestOnTheGivenAddressApiRegisterAndPassTheEmailEve_HoltReqres_InAndEnterPasswordPistol(string reqAddress, string paylEmail, string paylPassword)
        {
            var client = new RestClient("https://reqres.in");
            var request = new RestRequest(reqAddress, Method.POST);
            request.AddParameter("email", paylEmail);
            request.AddParameter("password", paylPassword);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            sucessfullReg = JsonConvert.DeserializeObject<APITestingConstant.JsonDataForSucessfulWithStatuscode>(content);
            sucessfullReg.statusCode = (int)response.StatusCode;
        }
        
        [Then(@"I get as output the response code (.*), token QpwL(.*)tke(.*)Pnpja(.*) and the id (.*)")]
        public void ThenIGetAsOutputTheResponseCodeTokenQpwLtkePnpjaAndTheId(int p0, int p1, int p2, string p3, int p4)
        {
            Assert.AreEqual(sucessfullReg.statusCode, p0);
            Assert.AreEqual(sucessfullReg.id, p4);
            Assert.AreEqual(sucessfullReg.token, idd);
        }
    }
}
