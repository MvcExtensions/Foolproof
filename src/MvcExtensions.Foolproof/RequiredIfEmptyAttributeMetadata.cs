#region Copyright
// Copyright (c) 2009 - 2012, Kazi Manzur Rashid <kazimanzurrashid@gmail.com>, (c) 2011 - 2012 hazzik <hazzik@gmail.com>.
// This source is subject to the Microsoft Public License. 
// See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL. 
// All other rights reserved.
#endregion

namespace MvcExtensions
{
    using System.ComponentModel.DataAnnotations;
    using Foolproof;

    /// <summary>
    /// Represents a class to store required-if-empty validation metadata.
    /// </summary>
    public class RequiredIfEmptyAttributeMetadata : ContingentValidationAttributeMetadata<RequiredIfEmptyAttribute>
    {
        /// <summary>
        /// Creates validation attribute
        /// </summary>
        /// <returns>
        /// Instance of ValidationAttribute type
        /// </returns>
        protected override ValidationAttribute CreateValidationAttribute()
        {
            var attribute = new RequiredIfEmptyAttribute(OtherProperty);
            PopulateErrorMessage(attribute);

            return attribute;
        }
    }
}