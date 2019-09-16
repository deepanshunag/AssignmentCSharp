using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace Test.stepDef.api2
{
    [Binding]
    public class CheckTheWorkingOfAPIForSecondTaskOnReqres_InSteps
    {
        APITestingConstant.JsonDataForSecondAPITask data;
        [Given(@"Address of the registration API on the website for task(.*)")]
        public void GivenAddressOfTheRegistrationAPIOnTheWebsiteForTask(int p0)
        {
            Assert.AreEqual(APITestingConstant.URL, "https://reqres.in");
        }
        
        [When(@"I perform the POST operation request on address (.*) and give the payload Email (.*)")]
        public void WhenIPerformThePOSTOperationRequestOnAddressApiRegisterAndGiveThePayloadEmailSydneyFife(string reqAddress, string paylEmail)
        {
            var client = new RestClient(APITestingConstant.URL);
            var request = new RestRequest(reqAddress, Method.POST);
            request.AddParameter("email", paylEmail);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            data = JsonConvert.DeserializeObject<APITestingConstant.JsonDataForSecondAPITask>(content);
            data.response_code = (int)response.StatusCode;
        }
        
        [Then(@"I get the output response code (.*) and output response (.*)")]
        public void ThenIGetTheOutputResponseCodeAndOutputResponseMissingPassword(int resCode, string resp)
        {
            Assert.AreEqual(data.response_code, resCode);
        }
    }
}
