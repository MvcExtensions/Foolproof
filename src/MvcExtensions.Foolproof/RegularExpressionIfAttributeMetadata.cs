﻿#region Copyright
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
    /// Represents a class to store regular-expression-if validation metadata.
    /// </summary>
    public class RegularExpressionIfAttributeMetadata : ContingentValidationAttributeMetadata<RegularExpressionIfAttribute>
    {
        /// <summary>
        /// Gets or sets the expression.
        /// </summary>
        /// <value>The expression.</value>
        public string Expression
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
        /// Gets or sets the dependent value.
        /// </summary>
        /// <value>The dependent value.</value>
        public object DependentValue
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
            var attribute = new RegularExpressionIfAttribute(Expression, OtherProperty, Operator, DependentValue);
            PopulateErrorMessage(attribute);

            return attribute;
        }
    }
}