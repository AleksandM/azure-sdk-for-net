// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.PostgreSql;

/// <summary>
/// PostgreSqlFlexibleServerDatabase.
/// </summary>
public partial class PostgreSqlFlexibleServerDatabase : ProvisionableResource
{
    /// <summary>
    /// The name of the database.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// The charset of the database.
    /// </summary>
    public BicepValue<string> Charset 
    {
        get { Initialize(); return _charset!; }
        set { Initialize(); _charset!.Assign(value); }
    }
    private BicepValue<string>? _charset;

    /// <summary>
    /// The collation of the database.
    /// </summary>
    public BicepValue<string> Collation 
    {
        get { Initialize(); return _collation!; }
        set { Initialize(); _collation!.Assign(value); }
    }
    private BicepValue<string>? _collation;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent PostgreSqlFlexibleServer.
    /// </summary>
    public PostgreSqlFlexibleServer? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<PostgreSqlFlexibleServer>? _parent;

    /// <summary>
    /// Creates a new PostgreSqlFlexibleServerDatabase.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the PostgreSqlFlexibleServerDatabase
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the PostgreSqlFlexibleServerDatabase.</param>
    public PostgreSqlFlexibleServerDatabase(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.DBforPostgreSQL/flexibleServers/databases", resourceVersion ?? "2024-08-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// PostgreSqlFlexibleServerDatabase.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _charset = DefineProperty<string>("Charset", ["properties", "charset"]);
        _collation = DefineProperty<string>("Collation", ["properties", "collation"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<PostgreSqlFlexibleServer>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported PostgreSqlFlexibleServerDatabase resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-08-01.
        /// </summary>
        public static readonly string V2024_08_01 = "2024-08-01";

        /// <summary>
        /// 2022-12-01.
        /// </summary>
        public static readonly string V2022_12_01 = "2022-12-01";

        /// <summary>
        /// 2021-06-01.
        /// </summary>
        public static readonly string V2021_06_01 = "2021-06-01";
    }

    /// <summary>
    /// Creates a reference to an existing PostgreSqlFlexibleServerDatabase.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the PostgreSqlFlexibleServerDatabase
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the PostgreSqlFlexibleServerDatabase.</param>
    /// <returns>The existing PostgreSqlFlexibleServerDatabase resource.</returns>
    public static PostgreSqlFlexibleServerDatabase FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
