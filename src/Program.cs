class Temperature_Converter
{
    public static void Main (String[] args) {
        Console.WriteLine(TempConvert(32, "F"));
        Console.WriteLine(TempConvert(100, "C"));
    }

    static string TempConvert (int degree, string unit) {
        bool isTrue = String.Equals(unit, "F");
        double converted;

        if (isTrue)
        {
            converted = (degree - 32)*5 / 9;
            return $"{converted} C";
        } else
        {
            converted = (degree*9/5) + 32;
            return $"{converted} F";
        }
    }
}