namespace MvcExtensions
{
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using Foolproof;

    /// <summary>
    /// Represents a class to store is validation metadata.
    /// </summary>
    public abstract class IsAttributeMetadata : ModelValidationMetadata
    {
        /// <summary>
        /// Gets or sets whether validation shouldpass on null property value.
        /// </summary>
        /// <value>The property.</value>
        public bool PassOnNull
        {
            get;
            set;
        }

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
        protected sealed override ModelValidator CreateValidatorCore(ExtendedModelMetadata modelMetadata, ControllerContext context)
        {
            return new FoolproofValidator(modelMetadata, context, (IsAttribute)CreateValidationAttribute());
        }

        /// <summary>
        /// Creates validation attribute
        /// </summary>
        /// <returns>
        /// Instance of ValidationAttribute type
        /// </returns>
        protected override ValidationAttribute CreateValidationAttribute()
        {
            var attribute = CreateAttribute();
            attribute.PassOnNull = PassOnNull;
            PopulateErrorMessage(attribute); 
            return attribute;
        }

        /// <summary>
        /// Creates an instence of Foolproof attribute
        /// </summary>
        /// <returns></returns>
        protected abstract IsAttribute CreateAttribute();
    }
}