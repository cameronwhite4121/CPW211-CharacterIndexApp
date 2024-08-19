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
        /// It then returns a boolean if the data is valid.
        /// </summary>
        /// <param name="model">The object to validate</param>
        /// <returns>True if datas is valid, false if otherwise</returns>
        public static bool Validate(object model)
        {           
            var validationContext = new ValidationContext(model);
            var validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(model, validationContext, validationResults, true);

            // No errors to be returned
            if (isValid)
            {
                return true;
            }
            else { // Show errors + return false

                string listOfErrors = null;
                foreach (var errorMessage in validationResults)
                {
                    listOfErrors += errorMessage + "\n";
                }
                MessageBox.Show(listOfErrors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }          
        }
    }
}
