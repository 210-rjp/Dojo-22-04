namespace Dojo2204
{
    public class MultipleDe7Rule : IRule
    {
        public string ExecuteRule(int leNombreDeMonTour, string result)
        {
            if (leNombreDeMonTour % 7 == 0)
            {
                result += "BANG";
            }
            return result;
        }
    }
}