#region Copyright
// Copyright (c) 2009 - 2012, Kazi Manzur Rashid <kazimanzurrashid@gmail.com>, (c) 2011 - 2012 hazzik <hazzik@gmail.com>.
// This source is subject to the Microsoft Public License. 
// See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL. 
// All other rights reserved.
#endregion
namespace MvcExtensions
{
    using System.Web.Mvc;
    using Foolproof;

    /// <summary>
    /// Holds <see cref="T:Foolproof.ModelAwareValidationAttribute"/> metadata
    /// </summary>
    public class ModelAwareValidationAttributeMetadata : ModelValidationMetadata
    {
        /// <summary>
        /// Creates the validator.
        /// </summary>
        /// <param name="modelMetadata">The model metadata.</param>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        protected override ModelValidator CreateValidatorCore(ExtendedModelMetadata modelMetadata, ControllerContext context)
        {
            return new FoolproofValidator(modelMetadata, context, (ModelAwareValidationAttribute)CreateValidationAttribute());
        }
    }
}