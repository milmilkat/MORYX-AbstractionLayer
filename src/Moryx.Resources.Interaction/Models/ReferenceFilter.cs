// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using Moryx.AbstractionLayer.Resources;
using System.Runtime.Serialization;

namespace Moryx.Resources.Interaction.Models
{
    /// <summary>
    /// Enum to classify the current value of the reference property
    /// </summary>
    internal enum ReferenceValue
    {
        /// <summary>
        /// Value of the reference property irrelevant to the filter
        /// </summary>
        Irrelevant = 0,

        /// <summary>
        /// Referenced property is empty
        /// </summary>
        NullOrEmpty = 1,

        /// <summary>
        /// Reference property must not be empty
        /// </summary>
        NotEmpty = 2,
    }

    /// <summary>
    /// Filter criteria for required or requested references
    /// </summary>
    [DataContract]
    internal class ReferenceFilter
    {
        /// <summary>
        /// Name of the reference
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Resource relation type
        /// </summary>
        [DataMember]
        public ResourceRelationType RelationType { get; set; }

        /// <summary>
        /// Role of the reference
        /// </summary>
        [DataMember]
        public ResourceReferenceRole Role { get; set; }

        /// <summary>
        /// Filter criteria for the reference property
        /// </summary>
        [DataMember]
        public ReferenceValue ValueConstraint { get; set; }
    }
}
