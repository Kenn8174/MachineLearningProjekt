// This file was auto-generated by ML.NET Model Builder. 

using System;
using MachineLearningProjektML.Model;

namespace MachineLearningProjektML.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                Car = @"Ford",
                Body = @"crossover",
                Mileage = 68F,
                EngV = 2.5F,
                EngType = @"Gas",
                Registration = @"yes",
                Year = 2010F,
                Model = @"Kuga",
                Drive = @"full",
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Price with predicted Price from sample data...\n\n");
            Console.WriteLine($"Car: {sampleData.Car}");
            Console.WriteLine($"Body: {sampleData.Body}");
            Console.WriteLine($"Mileage: {sampleData.Mileage}");
            Console.WriteLine($"EngV: {sampleData.EngV}");
            Console.WriteLine($"EngType: {sampleData.EngType}");
            Console.WriteLine($"Registration: {sampleData.Registration}");
            Console.WriteLine($"Year: {sampleData.Year}");
            Console.WriteLine($"Model: {sampleData.Model}");
            Console.WriteLine($"Drive: {sampleData.Drive}");
            Console.WriteLine($"\n\nPredicted Price: {predictionResult.Score}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
