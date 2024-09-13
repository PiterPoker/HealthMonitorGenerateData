using HealthMonitorGenerateData.App.Services;
using HealthMonitorGenerateData.App.ViewModel;
using System.Xml.Linq;

class Program
{
    static async Task Main(string[] args)
    {
        if (args.Length != 0)
        {
            GeneratePacient generatePacient = new GeneratePacient();
            var apiClient = new ApiClient(args[0], generatePacient);
            //var apiClient = new ApiClient("http://localhost:5200/", generatePacient);

            for (int i = 0; i < 100; i++)
            {
                var patient = new PatientViewModel
                {
                    Person = new PersonViewModel
                    {
                        RecordType = "official",
                        Family = RandomNameGenerator.GenerateLastName(),
                        Given = new string[] { RandomNameGenerator.GenerateFirstName(), RandomNameGenerator.GenerateMiddleName() }
                    },
                    Gender = "male",
                    BirthDate = new DateTime(2024, 12, 5).AddMonths(-i),
                    Status = "Active"
                };

                var response = await generatePacient.NewBirth(args[1], patient);
                //var response = await generatePacient.NewBirth("api/Patient/Create", patient);
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Patient {i + 1} added successfully.");
                }
                else
                {
                    Console.WriteLine($"Failed to add patient {i + 1}. Status code: {response.StatusCode}");
                }
            }
        }
    }
}
