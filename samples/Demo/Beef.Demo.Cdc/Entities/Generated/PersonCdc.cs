/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using Beef.Entities;
using Beef.Mapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Beef.Demo.Cdc.Entities
{
    /// <summary>
    /// Represents the CDC model for the root (primary) database table 'Demo.Person'.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PersonCdc : IUniqueKey, IETag
    {
        /// <summary>
        /// Gets or sets the 'PersonId' column value.
        /// </summary>
        [JsonProperty("personId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Guid PersonId { get; set; }

        /// <summary>
        /// Gets or sets the entity tag ('RowVersion' column).
        /// </summary>
        [JsonProperty("etag", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [MapperProperty("RowVersion", ConverterType = typeof(Beef.Data.Database.DatabaseRowVersionConverter))]
        public string? ETag { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MapperIgnore()]
        public bool HasUniqueKey => true;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MapperIgnore()]
        public UniqueKey UniqueKey => new UniqueKey(PersonId);

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MapperIgnore()]
        public string[] UniqueKeyProperties => new string[] { nameof(PersonId) };
    }
}

#pragma warning restore
#nullable restore