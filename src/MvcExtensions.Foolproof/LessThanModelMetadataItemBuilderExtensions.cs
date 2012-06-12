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
    /// Adds validation for <see cref="LessThanAttribute"/>
    /// </summary>
    public static class LessThanModelMetadataItemBuilderExtensions
    {
        /// <summary>
        /// Sets the range of value, this comes into action when is <code>Required</code> is <code>true</code>.
        /// </summary>
        /// <param name="self">The instance.</param>
        /// <param name="otherProperty">The other property.</param>
        /// <returns></returns>
        public static ModelMetadataItemBuilder<TValue> LessThan<TValue>(this ModelMetadataItemBuilder<TValue> self, string otherProperty)
        {
            return LessThan(self, otherProperty, false);
        }

        /// <summary>
        /// Sets the range of value, this comes into action when is <code>Required</code> is <code>true</code>.
        /// </summary>
        /// <param name="self">The instance.</param>
        /// <param name="otherProperty">The other property.</param>
        /// <param name="passOnNull">Pass on null</param>
        /// <returns></returns>
        public static ModelMetadataItemBuilder<TValue> LessThan<TValue>(this ModelMetadataItemBuilder<TValue> self, string otherProperty, bool passOnNull)
        {
            return LessThan(self, otherProperty, passOnNull, null, null, null);
        }

        /// <summary>
        /// Sets the range of value, this comes into action when is <code>Required</code> is <code>true</code>.
        /// </summary>
        /// <param name="otherProperty">The other property.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <param name="self">The instance.</param>
        /// <returns></returns>
        public static ModelMetadataItemBuilder<TValue> LessThan<TValue>(this ModelMetadataItemBuilder<TValue> self, string otherProperty, string errorMessage)
        {
            return LessThan(self, otherProperty, false, errorMessage);
        }

        /// <summary>
        /// Sets the range of value, this comes into action when is <code>Required</code> is <code>true</code>.
        /// </summary>
        /// <param name="otherProperty">The other property.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <param name="passOnNull">Pass on null</param>
        /// <param name="self">The instance.</param>
        /// <returns></returns>
        public static ModelMetadataItemBuilder<TValue> LessThan<TValue>(this ModelMetadataItemBuilder<TValue> self, string otherProperty, bool passOnNull, string errorMessage)
        {
            return LessThan(self, otherProperty, passOnNull, () => errorMessage);
        }

        /// <summary>
        /// Sets the range of value, this comes into action when is <code>Required</code> is <code>true</code>.
        /// </summary>
        /// <param name="otherProperty">The other property.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <param name="self">The instance.</param>
        /// <returns></returns>
        public static ModelMetadataItemBuilder<TValue> LessThan<TValue>(this ModelMetadataItemBuilder<TValue> self, string otherProperty, Func<string> errorMessage)
        {
            return LessThan(self, otherProperty, false, errorMessage);
        }

        /// <summary>
        /// Sets the range of value, this comes into action when is <code>Required</code> is <code>true</code>.
        /// </summary>
        /// <param name="otherProperty">The other property.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <param name="passOnNull">Pass on null</param>
        /// <param name="self">The instance.</param>
        /// <returns></returns>
        public static ModelMetadataItemBuilder<TValue> LessThan<TValue>(this ModelMetadataItemBuilder<TValue> self, string otherProperty, bool passOnNull, Func<string> errorMessage)
        {
            return LessThan(self, otherProperty, passOnNull, errorMessage, null, null);
        }

        /// <summary>
        /// Sets the range of value, this comes into action when is <code>Required</code> is <code>true</code>.
        /// </summary>
        /// <param name="self">The instance.</param>
        /// <param name="otherProperty">The other property.</param>
        /// <param name="errorMessageResourceType">Type of the error message resource.</param>
        /// <param name="errorMessageResourceName">Name of the error message resource.</param>
        /// <returns></returns>
        public static ModelMetadataItemBuilder<TValue> LessThan<TValue>(this ModelMetadataItemBuilder<TValue> self, string otherProperty, Type errorMessageResourceType, string errorMessageResourceName)
        {
            return LessThan(self, otherProperty, false, null, errorMessageResourceType, errorMessageResourceName);
        }

        /// <summary>
        /// Sets the range of value, this comes into action when is <code>Required</code> is <code>true</code>.
        /// </summary>
        /// <param name="self">The instance.</param>
        /// <param name="otherProperty">The other property.</param>
        /// <param name="passOnNull">Pass on null</param>
        /// <param name="errorMessageResourceType">Type of the error message resource.</param>
        /// <param name="errorMessageResourceName">Name of the error message resource.</param>
        /// <returns></returns>
        public static ModelMetadataItemBuilder<TValue> LessThan<TValue>(this ModelMetadataItemBuilder<TValue> self, string otherProperty, bool passOnNull, Type errorMessageResourceType, string errorMessageResourceName)
        {
            return LessThan(self, otherProperty, passOnNull, null, errorMessageResourceType, errorMessageResourceName);
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
        private static ModelMetadataItemBuilder<TValue> LessThan<TValue>(this ModelMetadataItemBuilder<TValue> self, string otherProperty, bool passOnNull, Func<string> errorMessage, Type errorMessageResourceType, string errorMessageResourceName)
        {
            var validation = self.Item.GetValidationOrCreateNew<LessThanAttributeMetadata>();

            validation.OtherProperty = otherProperty;
            validation.PassOnNull = passOnNull;
            validation.ErrorMessage = errorMessage;
            validation.ErrorMessageResourceType = errorMessageResourceType;
            validation.ErrorMessageResourceName = errorMessageResourceName;

            return self;
        }
    }
}