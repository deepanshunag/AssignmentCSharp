using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace Test.stepDef.api3
{
    [Binding]
    public class CheckWorkingOfAPITaskThreeOnReqres_InWebsiteSteps
    {
        APITestingVariable.JsonDataForNumberOfUsersWithStatusCode ListOfUsers;
        [Given(@"Address of the registration is entered")]
        public void GivenAddressOfTheRegistrationIsEntered()
        {
            Assert.AreEqual(APITestingVariable.URL, "https://reqres.in");
        }
        
        [When(@"I perform the GET request on address (.*) and entered with no payload")]
        public void WhenIPerformTheGETRequestOnAddressApiUsersPageAndEnteredWithNoPayload(string p0)
        {
            var client = new RestClient(APITestingVariable.URL);
            var request = new RestRequest(p0, Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            ListOfUsers = JsonConvert.DeserializeObject<APITestingVariable.JsonDataForNumberOfUsersWithStatusCode>(content);
            ListOfUsers.statusCode = (int)response.StatusCode;
        }
        
        [Then(@"I should get the response code (.*), pagenumber (.*),  total no of users (.*) and no of users on page as (.*)")]
        public void ThenIShouldGetTheResponseCodePagenumberTotalNoOfUsersAndNoOfUsersOnPageAs(int p0, int p1, int p2, int p3)
        {
            Assert.AreEqual(ListOfUsers.statusCode, p0);
            Assert.AreEqual(ListOfUsers.page, p1);
            Assert.AreEqual(ListOfUsers.Total, p2);
            Assert.AreEqual(ListOfUsers.page, p3);
        }
    }
}
