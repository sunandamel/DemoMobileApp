//using Allure.Commons;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TechTalk.SpecFlow;

//namespace DemoMobileApp.Hooks
//{
//    [Binding]
//    public class AllureHooks
//    {
//        private readonly ScenarioContext _scenarioContext;
//        private readonly AllureLifecycle _allure;
//        private string _uid;

//        public AllureHooks(ScenarioContext scenarioContext)
//        {
//            _scenarioContext = scenarioContext;
//            _allure = AllureLifecycle.Instance;
//        }

//        [BeforeScenario]
//        public void BeforeScenario()
//        {
//            var scenarioName = _scenarioContext.ScenarioInfo.Title;
//            _uid = Guid.NewGuid().ToString();

//            _ = _allure.StartTestCase(_uid, new TestResult
//            {
//                uuid = _uid,
//                name = scenarioName,
//                fullName = scenarioName,
//                //labels = new[]
//                //{
//                //    Label.TestClass("SpecFlow"),
//                //    Label.Suite("BDD Tests")
//                //}
//            });
//        }

//        [AfterStep]
//        public void AfterStep()
//        {
//            var stepName = _scenarioContext.StepContext.StepInfo.Text;
//            var status = _scenarioContext.TestError == null ? Status.passed : Status.failed;

//            string stepUid = Guid.NewGuid().ToString();
//            _allure.StartStep(_uid, stepUid, new StepResult { name = stepName });
//            _allure.StopStep(step => step.status = status);
//        }

//        [AfterScenario]
//        public void AfterScenario()
//        {
//            var status = _scenarioContext.TestError == null ? Status.passed : Status.failed;
//            _allure.UpdateTestCase(_uid, test => test.status = status);

//            _allure.StopTestCase(_uid);
//            _allure.WriteTestCase(_uid);
//        }
//    }

//}
