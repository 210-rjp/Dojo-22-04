namespace Dojo2204
{
    public class MultipleDe5Rule : IRule
    {
        public string ExecuteRule(int leNombreDeMonTour, string result)
        {
            if (leNombreDeMonTour%5 == 0)
            {
                result += "BUZZ";
            }
            return result;
        }
    }
}