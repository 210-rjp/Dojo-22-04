using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo2204
{
    public class FizzBuzz
    {
        private readonly IEnumerable<IRule> _rules;

        public FizzBuzz(IEnumerable<IRule> rules)
        {
            _rules = rules;
        }

        public string say(int leNombreDeMonTour)
        {
            String result = "";

            foreach (var rule in _rules)
            {
                result = rule.ExecuteRule(leNombreDeMonTour, result);
            }
            
            if (String.IsNullOrEmpty((result)))
            {
                result = leNombreDeMonTour.ToString();
            }

            return result;
        }
    }
}
