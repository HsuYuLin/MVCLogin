using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLogin.ValidateAttribute
{
    public sealed class NoIsAttribute:ValidationAttribute, IClientValidatable
    {
        public string Input { get; set; }    

        public NoIsAttribute(string input)
        {
            this.Input = input;            
        }

        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }              

            if (value is string)
            {
                var x = Input.Split(',');
                foreach(var y in x)
                {
                    if(value.ToString().Contains(y))
                    {
                        return false;
                    }
                }

                //if (value.ToString().Contains(x))
                //{
                //    return false;
                //}                    
            }
            return true;
        }

        IEnumerable<ModelClientValidationRule> IClientValidatable.GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            //throw new NotImplementedException();
            ModelClientValidationRule rule = new ModelClientValidationRule
            {
                ValidationType = "nois",
                ErrorMessage = FormatErrorMessage(metadata.GetDisplayName())
            };
            
            rule.ValidationParameters["input"] = Input;
            yield return rule;

        }
    }
}