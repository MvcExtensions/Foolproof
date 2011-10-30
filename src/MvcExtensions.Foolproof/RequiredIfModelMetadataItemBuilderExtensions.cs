#region Copyright
// Copyright (c) 2009 - 2011, Kazi Manzur Rashid <kazimanzurrashid@gmail.com>, hazzik <hazzik@gmail.com>.
// This source is subject to the Microsoft public License. 
// See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL. 
// All other rights reserved.
#endregion

namespace MvcExtensions
{
    using System;
    using Foolproof;

    /// <summary>
    /// Adds validation for <see cref="RequiredIfAttribute"/>
    /// </summary>
    public static class RequiredIfModelMetadataItemBuilderExtensions
    {
        /// <summary>
        /// Sets the range of value, this comes into action when is <code>Required</code> is <code>true</code>.
        /// </summary>
        /// <param name="self">The instance.</param>
        /// <param name="otherProperty">The other property.</param>
        /// <param name="operator"></param>
        /// <param name="dependentValue"></param>
        /// <returns></returns>
        public static ModelMetadataItemBuilder<TItemBuilder> RequiredIf<TItemBuilder>(this ModelMetadataItemBuilder<TItemBuilder> self, string otherProperty, Operator @operator, object dependentValue)
            where TItemBuilder : ModelMetadataItemBuilder<TItemBuilder>
        {
            return RequiredIf(self, otherProperty, @operator, dependentValue, null, null, null);
        }

        /// <summary>
        /// Sets the range of value, this comes into action when is <code>Required</code> is <code>true</code>.
        /// </summary>
        /// <param name="dependentValue"></param>
        /// <param name="errorMessage">The error message.</param>
        /// <param name="self">The instance.</param>
        /// <param name="otherProperty">The other property.</param>
        /// <param name="operator"></param>
        /// <returns></returns>
        public static ModelMetadataItemBuilder<TItemBuilder> RequiredIf<TItemBuilder>(this ModelMetadataItemBuilder<TItemBuilder> self, string otherProperty, Operator @operator, object dependentValue, string errorMessage)
            where TItemBuilder : ModelMetadataItemBuilder<TItemBuilder>
        {
            return RequiredIf(self, otherProperty, @operator, dependentValue, () => errorMessage);
        }

        /// <summary>
        /// Sets the range of value, this comes into action when is <code>Required</code> is <code>true</code>.
        /// </summary>
        /// <param name="dependentValue"></param>
        /// <param name="errorMessage">The error message.</param>
        /// <param name="self">The instance.</param>
        /// <param name="otherProperty">The other property.</param>
        /// <param name="operator"></param>
        /// <returns></returns>
        public static ModelMetadataItemBuilder<TItemBuilder> RequiredIf<TItemBuilder>(this ModelMetadataItemBuilder<TItemBuilder> self, string otherProperty, Operator @operator, object dependentValue, Func<string> errorMessage)
            where TItemBuilder : ModelMetadataItemBuilder<TItemBuilder>
        {
            return RequiredIf(self, otherProperty, @operator, dependentValue, errorMessage, null, null);
        }

        /// <summary>
        /// Sets the range of value, this comes into action when is <code>Required</code> is <code>true</code>.
        /// </summary>
        /// <param name="self">The instance.</param>
        /// <param name="otherProperty">The other property.</param>
        /// <param name="dependentValue"></param>
        /// <param name="errorMessageResourceType">Type of the error message resource.</param>
        /// <param name="errorMessageResourceName">Name of the error message resource.</param>
        /// <param name="operator"></param>
        /// <returns></returns>
        public static ModelMetadataItemBuilder<TItemBuilder> RequiredIf<TItemBuilder>(this ModelMetadataItemBuilder<TItemBuilder> self, string otherProperty, Operator @operator, object dependentValue, Type errorMessageResourceType, string errorMessageResourceName)
            where TItemBuilder : ModelMetadataItemBuilder<TItemBuilder>
        {
            return RequiredIf(self, otherProperty, @operator, dependentValue, null, errorMessageResourceType, errorMessageResourceName);
        }

        /// <summary>
        /// Sets the range of value, this comes into action when is <code>Required</code> is <code>true</code>.
        /// </summary>
        /// <param name="self">The instance.</param>
        /// <param name="otherProperty">The other property.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <param name="errorMessageResourceType">Type of the error message resource.</param>
        /// <param name="errorMessageResourceName">Name of the error message resource.</param>
        /// <param name="operator"></param>
        /// <param name="dependentValue"></param>
        /// <returns></returns>
        private static ModelMetadataItemBuilder<TItemBuilder> RequiredIf<TItemBuilder>(this ModelMetadataItemBuilder<TItemBuilder> self, string otherProperty, Operator @operator, object dependentValue, Func<string> errorMessage, Type errorMessageResourceType, string errorMessageResourceName)
            where TItemBuilder : ModelMetadataItemBuilder<TItemBuilder>
        {
            var validation = self.Item.GetValidationOrCreateNew<RequiredIfAttributeMetadata>();

            validation.OtherProperty = otherProperty;
            validation.Operator = @operator;
            validation.DependentValue = dependentValue;
            validation.ErrorMessage = errorMessage;
            validation.ErrorMessageResourceType = errorMessageResourceType;
            validation.ErrorMessageResourceName = errorMessageResourceName;

            return self;
        }
    }
}