class Temperature_Converter
{
    public static void Main (String[] args) {

        Console.WriteLine("Enter a temperature and its unit (C or F): ");
        string input = Console.ReadLine() ?? "";

        string[] parts = input.Split(" ");
               
        string temperatureUnit = parts[1].ToUpper();
        double.TryParse(parts[0], out double temperatureValue);

        // Input we want to converted 
        Console.WriteLine(TempConvert(temperatureValue, temperatureUnit));


        Console.ReadKey();
    }

    static string TempConvert (double degree, string unit) {
        bool isTrue = String.Equals(unit, "F");
        double converted;

        if (isTrue)
        {
            converted = (degree - 32)*5 / 9;
            return $"{converted:F2} C";
        } else
        {
            converted = (degree*9/5) + 32;
            return $"{converted:F2} F";
        }
    }
}