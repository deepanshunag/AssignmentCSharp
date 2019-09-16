﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Test.File
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Validation of price and details Searching the flight for 3 Trips")]
    public partial class ValidationOfPriceAndDetailsSearchingTheFlightFor3TripsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "BookFlight.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Validation of price and details Searching the flight for 3 Trips", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search the Flight")]
        [NUnit.Framework.TestCaseAttribute("MLA", "LON", "ROM", "12/12/2019", "12/15/2019", "12/19/2019", "4", "Malta Intl. (MLA)", "Gatwick (LGW)", "Gatwick (LGW)", "Fiumicino - Leonardo da Vinci Intl. (FCO)", "Fiumicino - Leonardo da Vinci Intl. (FCO)", "Malta Intl. (MLA)", null)]
        public virtual void SearchTheFlight(string fIRST, string sECOND, string tHIRD, string date1, string date2, string date3, string n, string trip1From, string trip1To, string trip2From, string trip2To, string trip3From, string trip3To, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search the Flight", null, exampleTags);
#line 3
   this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
   testRunner.Given("go to expedia website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
   testRunner.And("select multiflight option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 6
   testRunner.When(string.Format("I search the flight between airports {0}, {1}, {2} on dates {3}, {4}, {5} for {6}" +
                        " Adults", fIRST, sECOND, tHIRD, date1, date2, date3, n), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
   testRunner.And("click on search flight", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
   testRunner.Then(string.Format("The Total price should be equal to {0} multiplied by price of single person", n), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 9
   testRunner.And(string.Format("Trip details as FirstTrip from {0} to {1} SecondTrip from {2} to {3} ThirdTrip fr" +
                        "om {4} to {5}", trip1From, trip1To, trip2From, trip2To, trip3From, trip3To), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
   testRunner.And("Close all Windows of Expedia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

