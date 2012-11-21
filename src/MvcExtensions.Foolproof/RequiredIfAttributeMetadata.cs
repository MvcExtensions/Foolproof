#region Copyright
// Copyright (c) 2009 - 2011, Kazi Manzur Rashid <kazimanzurrashid@gmail.com>.
// This source is subject to the Microsoft Public License. 
// See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL. 
// All other rights reserved.
#endregion

namespace MvcExtensions
{
    using System.ComponentModel.DataAnnotations;
    using Foolproof;

    /// <summary>
    /// Represents a class to store required-if validation metadata.
    /// </summary>
    public class RequiredIfAttributeMetadata : ContingentValidationAttributeMetadata<RequiredIfAttribute>
    {
        /// <summary>
        /// Gets or sets the dependent value.
        /// </summary>
        /// <value>The dependent value.</value>
        public object DependentValue
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the operator.
        /// </summary>
        /// <value>The operator.</value>
        public Operator Operator
        {
            get;
            set;
        }

        /// <summary>
        /// Creates validation attribute
        /// </summary>
        /// <returns>
        /// Instance of ValidationAttribute type
        /// </returns>
        protected override ValidationAttribute CreateValidationAttribute()
        {
            var attribute = new RequiredIfAttribute(OtherProperty, Operator, DependentValue);
            PopulateErrorMessage(attribute);
            return attribute;
        }
    }
}