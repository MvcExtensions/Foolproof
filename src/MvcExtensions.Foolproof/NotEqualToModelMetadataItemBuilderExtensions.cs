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
    /// Adds validation for <see cref="NotEqualToAttribute"/>
    /// </summary>
    public static class NotEqualToModelMetadataItemBuilderExtensions
    {
        /// <summary>
        /// Sets the range of value, this comes into action when is <code>Required</code> is <code>true</code>.
        /// </summary>
        /// <param name="self">The instance.</param>
        /// <param name="otherProperty">The other property.</param>
        /// <returns></returns>
        public static ModelMetadataItemBuilder<TItem, TItemBuilder> NotEqualTo<TItem, TItemBuilder>(this ModelMetadataItemBuilder<TItem, TItemBuilder> self, string otherProperty)
            where TItem : ModelMetadataItem where TItemBuilder : ModelMetadataItemBuilder<TItem, TItemBuilder>
        {
            return NotEqualTo(self, otherProperty, null, null, null);
        }

        /// <summary>
        /// Sets the range of value, this comes into action when is <code>Required</code> is <code>true</code>.
        /// </summary>
        /// <param name="otherProperty">The other property.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <param name="self">The instance.</param>
        /// <returns></returns>
        public static ModelMetadataItemBuilder<TItem, TItemBuilder> NotEqualTo<TItem, TItemBuilder>(this ModelMetadataItemBuilder<TItem, TItemBuilder> self, string otherProperty, string errorMessage)
            where TItem : ModelMetadataItem
            where TItemBuilder : ModelMetadataItemBuilder<TItem, TItemBuilder>
        {
            return NotEqualTo(self, otherProperty, () => errorMessage);
        }

        /// <summary>
        /// Sets the range of value, this comes into action when is <code>Required</code> is <code>true</code>.
        /// </summary>
        /// <param name="otherProperty">The other property.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <param name="self">The instance.</param>
        /// <returns></returns>
        public static ModelMetadataItemBuilder<TItem, TItemBuilder> NotEqualTo<TItem, TItemBuilder>(this ModelMetadataItemBuilder<TItem, TItemBuilder> self, string otherProperty, Func<string> errorMessage)
            where TItem : ModelMetadataItem
            where TItemBuilder : ModelMetadataItemBuilder<TItem, TItemBuilder>
        {
            return NotEqualTo(self, otherProperty, errorMessage, null, null);
        }

        /// <summary>
        /// Sets the range of value, this comes into action when is <code>Required</code> is <code>true</code>.
        /// </summary>
        /// <param name="self">The instance.</param>
        /// <param name="otherProperty">The other property.</param>
        /// <param name="errorMessageResourceType">Type of the error message resource.</param>
        /// <param name="errorMessageResourceName">Name of the error message resource.</param>
        /// <returns></returns>
        public static ModelMetadataItemBuilder<TItem, TItemBuilder> NotEqualTo<TItem, TItemBuilder>(this ModelMetadataItemBuilder<TItem, TItemBuilder> self, string otherProperty, Type errorMessageResourceType, string errorMessageResourceName)
            where TItem : ModelMetadataItem
            where TItemBuilder : ModelMetadataItemBuilder<TItem, TItemBuilder>
        {
            return NotEqualTo(self, otherProperty, null, errorMessageResourceType, errorMessageResourceName);
        }

        /// <summary>
        /// Sets the range of value, this comes into action when is <code>Required</code> is <code>true</code>.
        /// </summary>
        /// <param name="self">The instance.</param>
        /// <param name="otherProperty">The other property.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <param name="errorMessageResourceType">Type of the error message resource.</param>
        /// <param name="errorMessageResourceName">Name of the error message resource.</param>
        /// <returns></returns>
        private static ModelMetadataItemBuilder<TItem, TItemBuilder> NotEqualTo<TItem, TItemBuilder>(this ModelMetadataItemBuilder<TItem, TItemBuilder> self, string otherProperty, Func<string> errorMessage, Type errorMessageResourceType, string errorMessageResourceName)
            where TItem : ModelMetadataItem
            where TItemBuilder : ModelMetadataItemBuilder<TItem, TItemBuilder>
        {
            var validation = self.Item.GetValidationOrCreateNew<NotEqualToAttributeMetadata>();

            validation.OtherProperty = otherProperty;
            validation.ErrorMessage = errorMessage;
            validation.ErrorMessageResourceType = errorMessageResourceType;
            validation.ErrorMessageResourceName = errorMessageResourceName;

            return self;
        }
    }
}