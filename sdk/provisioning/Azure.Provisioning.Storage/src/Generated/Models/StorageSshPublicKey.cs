// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// The StorageSshPublicKey.
/// </summary>
public partial class StorageSshPublicKey : ProvisionableConstruct
{
    /// <summary>
    /// Optional. It is used to store the function/usage of the key.
    /// </summary>
    public BicepValue<string> Description { get => _description; set => _description.Assign(value); }
    private readonly BicepValue<string> _description;

    /// <summary>
    /// Ssh public key base64 encoded. The format should be:
    /// &apos;&lt;keyType&gt; &lt;keyData&gt;&apos;, e.g. ssh-rsa AAAABBBB.
    /// </summary>
    public BicepValue<string> Key { get => _key; set => _key.Assign(value); }
    private readonly BicepValue<string> _key;

    /// <summary>
    /// Creates a new StorageSshPublicKey.
    /// </summary>
    public StorageSshPublicKey()
    {
        _description = BicepValue<string>.DefineProperty(this, "Description", ["description"]);
        _key = BicepValue<string>.DefineProperty(this, "Key", ["key"], isSecure: true);
    }
}
