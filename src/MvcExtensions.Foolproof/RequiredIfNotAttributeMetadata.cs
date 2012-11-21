#region Copyright
// Copyright (c) 2009 - 2012, Kazi Manzur Rashid <kazimanzurrashid@gmail.com>, (c) 2011 - 2012 hazzik <hazzik@gmail.com>.
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
    /// Represents a class to store required-if-not validation metadata.
    /// </summary>
    public class RequiredIfNotAttributeMetadata : ModelValidationMetadata
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
        /// Gets or sets the other property.
        /// </summary>
        /// <value>The property.</value>
        public object DependentValue
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
            return new FoolproofValidator(modelMetadata, context, (RequiredIfNotAttribute) CreateValidationAttribute());
        }

        /// <summary>
        /// Creates validation attribute
        /// </summary>
        /// <returns>
        /// Instance of ValidationAttribute type
        /// </returns>
        protected override ValidationAttribute CreateValidationAttribute()
        {
            var attribute = new RequiredIfNotAttribute(OtherProperty, DependentValue);
            PopulateErrorMessage(attribute);

            return attribute;
        }
    }
}