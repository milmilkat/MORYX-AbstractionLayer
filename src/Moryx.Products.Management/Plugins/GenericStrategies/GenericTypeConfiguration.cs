// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using Moryx.Products.Management.Implementations.Storage;
using Moryx.Products.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Moryx.Products.Management.Plugins.GenericStrategies
{
    /// <summary>
    /// Configuration for <see cref="GenericTypeStrategy"/>
    /// </summary>
    [DataContract]
    public class GenericTypeConfiguration : ProductTypeConfiguration, IGenericMapperConfiguration
    {
        public override string PluginName
        {
            get { return nameof(GenericTypeStrategy); }
            set { }
        }

        /// <inheritdoc />
        [DataMember, DefaultValue(nameof(IGenericColumns.Text8)), AvailableColumns(typeof(string))]
        [Description("Column that should be used to store all non-configured properties as JSON")]
        public string JsonColumn { get; set; }

        /// <inheritdoc />
        [DataMember, Description]
        public List<PropertyMapperConfig> PropertyConfigs { get; set; }
    }
}
