namespace Dojo2204
{
    public class EgalA69Rule : IRule
    {
        public string ExecuteRule(int leNombreDeMonTour, string result)
        {
            if (leNombreDeMonTour == 69)
            {
                result = "WOOOOOPI";
            }
            return result;
        }
    }
}