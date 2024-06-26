// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary>
    /// A Coding is a representation of a defined concept using a symbol from a defined "code system".
    /// Based on [FHIR Coding](https://www.hl7.org/fhir/R4/datatypes.html#Coding)
    /// </summary>
    public partial class FhirR4Coding : FhirR4Element
    {
        /// <summary> Initializes a new instance of <see cref="FhirR4Coding"/>. </summary>
        public FhirR4Coding()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FhirR4Coding"/>. </summary>
        /// <param name="id"> Unique id for inter-element referencing. </param>
        /// <param name="extension"> Additional Content defined by implementations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="system"> Identity of the terminology system. </param>
        /// <param name="version"> Version of the system - if relevant. </param>
        /// <param name="code"> Symbol in syntax defined by the system. </param>
        /// <param name="display"> Representation defined by the system. </param>
        internal FhirR4Coding(string id, IList<FhirR4Extension> extension, IDictionary<string, BinaryData> serializedAdditionalRawData, string system, string version, string code, string display) : base(id, extension, serializedAdditionalRawData)
        {
            System = system;
            Version = version;
            Code = code;
            Display = display;
        }

        /// <summary> Identity of the terminology system. </summary>
        public string System { get; set; }
        /// <summary> Version of the system - if relevant. </summary>
        public string Version { get; set; }
        /// <summary> Symbol in syntax defined by the system. </summary>
        public string Code { get; set; }
        /// <summary> Representation defined by the system. </summary>
        public string Display { get; set; }
    }
}
