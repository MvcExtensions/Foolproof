namespace MvcExtensions
{
    using System.ComponentModel.DataAnnotations;
    using Foolproof;

    /// <summary>
    /// Represents a class to store is validation metadata.
    /// </summary>
    public abstract class IsAttributeMetadata : ContingentValidationAttributeMetadata<IsAttribute>
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