#region Copyright
// Copyright (c) 2009 - 2012, Kazi Manzur Rashid <kazimanzurrashid@gmail.com>, (c) 2011 - 2012 hazzik <hazzik@gmail.com>.
// This source is subject to the Microsoft Public License. 
// See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL. 
// All other rights reserved.
#endregion

namespace MvcExtensions
{
    using Foolproof;

    /// <summary>
    /// Holds <see cref="T:Foolproof.ContingentValidationAttribute"/> metadata
    /// </summary>
    public class ContingentValidationAttributeMetadata<TAttribute> : ModelAwareValidationAttributeMetadata
        where TAttribute : ContingentValidationAttribute
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
    }
}