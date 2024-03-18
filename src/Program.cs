class Temperature_Converter
{
    public static void Main (String[] args) {
        try
        {
            while (true)
            {
                Console.WriteLine("Enter a temperature and its unit (C or F) or type Quit to exist the app:");
                string input = Console.ReadLine() ?? "";

                // end the app
                if (input.ToLower() == "quit")
                {
                    Console.WriteLine("Program is terminated");
                    break;
                }

                // check if user entered more than 2 input or less
                string[] parts = input.Split(" ");
                if (parts.Length != 2)
                {
                    Console.WriteLine("Invalid Input. Please Enter a temperature value and it's unit (C or F)");
                    continue;
                }

                // check if user entered numeric values
                if (!double.TryParse(parts[0], out double temperatureValue))
                {
                    Console.WriteLine("Invalid Value. Please Enter a numeric value for temperature");
                    continue;
                } 

                // convert unit to string 
                string temperatureUnit = parts[1].ToUpper();

                // Input we want to converted 
                Console.WriteLine(TempConvert(temperatureValue, temperatureUnit));
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.ReadKey();
    }

    static string TempConvert (double degree, string unit) {
        double converted;
        switch (unit)
        {
            case "C":
                converted = (degree*9/5) + 32;
                return $"{converted:F2} F"; 
            case "F": 
                converted = (degree - 32)*5 / 9;
                return $"{converted:F2} C";
            default:
                return "Invalid Unit. Please Enter a temperature value and it's unit (C or F)";
        }
    }
}