#region Copyright
// Copyright (c) 2009 - 2011, Kazi Manzur Rashid <kazimanzurrashid@gmail.com>, hazzik <hazzik@gmail.com>.
// This source is subject to the Microsoft Public License. 
// See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL. 
// All other rights reserved.
#endregion

namespace MvcExtensions
{
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using Foolproof;

    /// <summary>
    /// Represents a class to store required-if-not-empty validation metadata.
    /// </summary>
    public class RequiredIfNotEmptyAttributeMetadata : ModelValidationMetadata
    {
        /// <summary>
        /// Gets or sets the other property.
        /// </summary>
        /// <value>The property.</value>
        public string OtherProperty
        {
            get;
            set;
        }

        /// <summary>
        /// Creates the validator.
        /// </summary>
        /// <param name="modelMetadata">The model metadata.</param>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        protected override ModelValidator CreateValidatorCore(ExtendedModelMetadata modelMetadata, ControllerContext context)
        {
            return new FoolproofValidator(modelMetadata, context, (RequiredIfNotEmptyAttribute)CreateValidationAttribute());
        }

        /// <summary>
        /// Creates validation attribute
        /// </summary>
        /// <returns>
        /// Instance of ValidationAttribute type
        /// </returns>
        protected override ValidationAttribute CreateValidationAttribute()
        {
            var attribute = new RequiredIfNotEmptyAttribute(OtherProperty);
            PopulateErrorMessage(attribute);

            return attribute;
        }
    }
}