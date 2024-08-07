// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Text
{
    public partial class HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage : IUtf8JsonSerializable, IJsonModel<HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("warnings"u8);
            writer.WriteStartArray();
            foreach (var item in Warnings)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Statistics))
            {
                writer.WritePropertyName("statistics"u8);
                writer.WriteObjectValue(Statistics, options);
            }
            writer.WritePropertyName("entities"u8);
            writer.WriteStartArray();
            foreach (var item in Entities)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("relations"u8);
            writer.WriteStartArray();
            foreach (var item in Relations)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(FhirBundle))
            {
                writer.WritePropertyName("fhirBundle"u8);
                writer.WriteObjectValue(FhirBundle, options);
            }
            if (Optional.IsDefined(DetectedLanguage))
            {
                writer.WritePropertyName("detectedLanguage"u8);
                writer.WriteObjectValue(DetectedLanguage, options);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage IJsonModel<HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHealthcareEntitiesDocumentResultWithDocumentDetectedLanguage(document.RootElement, options);
        }

        internal static HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage DeserializeHealthcareEntitiesDocumentResultWithDocumentDetectedLanguage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            IReadOnlyList<DocumentWarning> warnings = default;
            DocumentStatistics statistics = default;
            IReadOnlyList<HealthcareEntity> entities = default;
            IReadOnlyList<HealthcareRelation> relations = default;
            FhirBundle fhirBundle = default;
            DetectedLanguage detectedLanguage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("warnings"u8))
                {
                    List<DocumentWarning> array = new List<DocumentWarning>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentWarning.DeserializeDocumentWarning(item, options));
                    }
                    warnings = array;
                    continue;
                }
                if (property.NameEquals("statistics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statistics = DocumentStatistics.DeserializeDocumentStatistics(property.Value, options);
                    continue;
                }
                if (property.NameEquals("entities"u8))
                {
                    List<HealthcareEntity> array = new List<HealthcareEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareEntity.DeserializeHealthcareEntity(item, options));
                    }
                    entities = array;
                    continue;
                }
                if (property.NameEquals("relations"u8))
                {
                    List<HealthcareRelation> array = new List<HealthcareRelation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareRelation.DeserializeHealthcareRelation(item, options));
                    }
                    relations = array;
                    continue;
                }
                if (property.NameEquals("fhirBundle"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fhirBundle = FhirBundle.DeserializeFhirBundle(property.Value, options);
                    continue;
                }
                if (property.NameEquals("detectedLanguage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    detectedLanguage = DetectedLanguage.DeserializeDetectedLanguage(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage(
                id,
                warnings,
                statistics,
                entities,
                relations,
                fhirBundle,
                detectedLanguage,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage)} does not support writing '{options.Format}' format.");
            }
        }

        HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage IPersistableModel<HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHealthcareEntitiesDocumentResultWithDocumentDetectedLanguage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeHealthcareEntitiesDocumentResultWithDocumentDetectedLanguage(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
