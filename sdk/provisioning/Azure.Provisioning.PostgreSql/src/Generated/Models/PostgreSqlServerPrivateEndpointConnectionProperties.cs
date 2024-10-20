// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.PostgreSql;

/// <summary>
/// Properties of a private endpoint connection.
/// </summary>
public partial class PostgreSqlServerPrivateEndpointConnectionProperties : ProvisionableConstruct
{
    /// <summary>
    /// Gets or sets Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> PrivateEndpointId { get => _privateEndpointId; }
    private readonly BicepValue<ResourceIdentifier> _privateEndpointId;

    /// <summary>
    /// Connection state of the private endpoint connection.
    /// </summary>
    public BicepValue<PostgreSqlServerPrivateLinkServiceConnectionStateProperty> PrivateLinkServiceConnectionState { get => _privateLinkServiceConnectionState; }
    private readonly BicepValue<PostgreSqlServerPrivateLinkServiceConnectionStateProperty> _privateLinkServiceConnectionState;

    /// <summary>
    /// State of the private endpoint connection.
    /// </summary>
    public BicepValue<PostgreSqlPrivateEndpointProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<PostgreSqlPrivateEndpointProvisioningState> _provisioningState;

    /// <summary>
    /// Creates a new PostgreSqlServerPrivateEndpointConnectionProperties.
    /// </summary>
    public PostgreSqlServerPrivateEndpointConnectionProperties()
    {
        _privateEndpointId = BicepValue<ResourceIdentifier>.DefineProperty(this, "PrivateEndpointId", ["privateEndpoint", "id"], isOutput: true);
        _privateLinkServiceConnectionState = BicepValue<PostgreSqlServerPrivateLinkServiceConnectionStateProperty>.DefineProperty(this, "PrivateLinkServiceConnectionState", ["privateLinkServiceConnectionState"], isOutput: true);
        _provisioningState = BicepValue<PostgreSqlPrivateEndpointProvisioningState>.DefineProperty(this, "ProvisioningState", ["provisioningState"], isOutput: true);
    }
}
