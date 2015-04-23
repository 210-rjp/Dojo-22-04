namespace Dojo2204
{
    public class MultipleDe3Rule : IRule
    {
        public string ExecuteRule(int leNombreDeMonTour, string result)
        {
            if (leNombreDeMonTour%3 == 0)
            {
                result = "FIZZ";
            }
            return result;
        }
    }
}