using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_TeamProject.Models
{
    public class ValidationHelper
    {
        /// <summary>
        /// This method takes an object as a parameter and uses
        /// that objects data annotations to validate the object.
        /// It then returns a list of errors if any.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static bool Validate(object model)
        {           
            var validationContext = new ValidationContext(model);
            var validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(model, validationContext, validationResults, true);

            // No errors to be returned
            if(isValid)
            {
                return true;
            }

            // Show errors
            MessageBox.Show(string.Join(Environment.NewLine, validationResults.Select(vr => vr.ErrorMessage)));

            // Returns list of errors
            return false; 
        }
    }
}
