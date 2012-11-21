#region Copyright
// Copyright (c) 2009 - 2011, Kazi Manzur Rashid <kazimanzurrashid@gmail.com>, hazzik <hazzik@gmail.com>.
// This source is subject to the Microsoft Public License. 
// See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL. 
// All other rights reserved.
#endregion

namespace MvcExtensions
{
    using System.ComponentModel.DataAnnotations;
    using Foolproof;

    /// <summary>
    /// Represents a class to store required-if-true validation metadata.
    /// </summary>
    public class RequiredIfTrueAttributeMetadata : ContingentValidationAttributeMetadata<RequiredIfTrueAttribute>
    {
        /// <summary>
        /// Creates validation attribute
        /// </summary>
        /// <returns>
        /// Instance of ValidationAttribute type
        /// </returns>
        protected override ValidationAttribute CreateValidationAttribute()
        {
            var attribute = new RequiredIfTrueAttribute(OtherProperty);
            PopulateErrorMessage(attribute);

            return attribute;
        }
    }
}