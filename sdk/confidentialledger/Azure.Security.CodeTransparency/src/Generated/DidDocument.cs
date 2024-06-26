// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Security.CodeTransparency
{
    /// <summary> A DID document. </summary>
    public partial class DidDocument
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DidDocument"/>. </summary>
        /// <param name="id"> String representing a DID issuer. </param>
        /// <param name="assertionMethod"> List of public keys used for receipt endorsement verification. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="assertionMethod"/> is null. </exception>
        internal DidDocument(string id, IEnumerable<DidDocumentKey> assertionMethod)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(assertionMethod, nameof(assertionMethod));

            Id = id;
            AssertionMethod = assertionMethod.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DidDocument"/>. </summary>
        /// <param name="id"> String representing a DID issuer. </param>
        /// <param name="assertionMethod"> List of public keys used for receipt endorsement verification. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DidDocument(string id, IReadOnlyList<DidDocumentKey> assertionMethod, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            AssertionMethod = assertionMethod;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DidDocument"/> for deserialization. </summary>
        internal DidDocument()
        {
        }

        /// <summary> String representing a DID issuer. </summary>
        public string Id { get; }
        /// <summary> List of public keys used for receipt endorsement verification. </summary>
        public IReadOnlyList<DidDocumentKey> AssertionMethod { get; }
    }
}
