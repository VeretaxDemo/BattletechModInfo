namespace BattletechModInfo.Library.SpecFlow.StepDefinitions;

public class FileManagerStepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("A path to a folder (.*)")]
        public void GivenAPathToAFolder(string path)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method.

            throw new PendingStepException();
        }

        [Given("the file name is (.*)")]
        public void GivenTheFileNameIs(string filename)
        {
            //TODO: implement arrange (precondition) logic

            throw new PendingStepException();
        }

        [When("combined path is checked")]
        public void WhenTheCombinedPathIsChecked()
        {
            //TODO: implement act (action) logic

            throw new PendingStepException();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            throw new PendingStepException();
        }
    }
}