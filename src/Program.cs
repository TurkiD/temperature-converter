class Temperature_Converter
{
    public static void Main (String[] args) {
        try
        {
            Console.WriteLine("Enter a temperature and its unit (C or F) or type Quit to exist the app:");
            string input = Console.ReadLine() ?? "";

            string[] parts = input.Split(" ");
            if (parts.Length != 2)
            {
                Console.WriteLine("Invalid Input. Please Enter a temperature value and it's unit (C or F)");
            }

            string temperatureUnit = parts[1].ToUpper();
            if (temperatureUnit != "C" && temperatureUnit != "F")
            {
                Console.WriteLine("Invalid Unit. Please Enter a temperature value and it's unit (C or F)");
            }

            if (!double.TryParse(parts[0], out double temperatureValue))
            {
                Console.WriteLine("Invalid Value. Please Enter a numeric value for temperature");
            } 

            // Input we want to converted 
            Console.WriteLine(TempConvert(temperatureValue, temperatureUnit));

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
                converted = (degree - 32)*5 / 9;
                return $"{converted:F2} C";
            case "F": 
                converted = (degree*9/5) + 32;
                return $"{converted:F2} F";
            default:
                return "Something went wrong please try again";
        }
    }
}