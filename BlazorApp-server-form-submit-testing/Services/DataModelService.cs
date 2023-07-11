using BlazorApp_server_form_submit_testing.Data.Models;


namespace BlazorApp_server_form_submit_testing.Services
{
    public class DataModelService
    {
        public List<DataModelExample> GetDataModel(string email)
        {
            return new List<DataModelExample>()
            {
                new DataModelExample()
                {
                    Name = "Example name",
                    OtherName = "Example other name"
                },
                new DataModelExample()
                {
                    Name = "Example name 2",
                    OtherName = "Example other name 2"
                },
                new DataModelExample()
                {
                    Name = "Example name 3",
                    OtherName = "Example other name 3"
                }
            };
        }
    }
}
