namespace Dojo2204
{
    public class EgalA42Rule : IRule
    {
        public string ExecuteRule(int leNombreDeMonTour, string result)
        {
            if (leNombreDeMonTour == 42)
            {
                result = "la réponse à tout";
            }
            return result;
        }
    }
}