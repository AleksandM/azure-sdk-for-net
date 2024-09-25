// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class CanaryTrafficRegionRolloutConfiguration : IUtf8JsonSerializable, IJsonModel<CanaryTrafficRegionRolloutConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CanaryTrafficRegionRolloutConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CanaryTrafficRegionRolloutConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CanaryTrafficRegionRolloutConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CanaryTrafficRegionRolloutConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(SkipRegions))
            {
                writer.WritePropertyName("skipRegions"u8);
                writer.WriteStartArray();
                foreach (var item in SkipRegions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Regions))
            {
                writer.WritePropertyName("regions"u8);
                writer.WriteStartArray();
                foreach (var item in Regions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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
        }

        CanaryTrafficRegionRolloutConfiguration IJsonModel<CanaryTrafficRegionRolloutConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CanaryTrafficRegionRolloutConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CanaryTrafficRegionRolloutConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCanaryTrafficRegionRolloutConfiguration(document.RootElement, options);
        }

        internal static CanaryTrafficRegionRolloutConfiguration DeserializeCanaryTrafficRegionRolloutConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<AzureLocation> skipRegions = default;
            IList<AzureLocation> regions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("skipRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureLocation> array = new List<AzureLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AzureLocation(item.GetString()));
                    }
                    skipRegions = array;
                    continue;
                }
                if (property.NameEquals("regions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureLocation> array = new List<AzureLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AzureLocation(item.GetString()));
                    }
                    regions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CanaryTrafficRegionRolloutConfiguration(skipRegions ?? new ChangeTrackingList<AzureLocation>(), regions ?? new ChangeTrackingList<AzureLocation>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CanaryTrafficRegionRolloutConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CanaryTrafficRegionRolloutConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CanaryTrafficRegionRolloutConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        CanaryTrafficRegionRolloutConfiguration IPersistableModel<CanaryTrafficRegionRolloutConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CanaryTrafficRegionRolloutConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCanaryTrafficRegionRolloutConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CanaryTrafficRegionRolloutConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CanaryTrafficRegionRolloutConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
