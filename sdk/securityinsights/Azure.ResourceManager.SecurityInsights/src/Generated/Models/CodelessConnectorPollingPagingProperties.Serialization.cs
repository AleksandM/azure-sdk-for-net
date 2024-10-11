// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class CodelessConnectorPollingPagingProperties : IUtf8JsonSerializable, IJsonModel<CodelessConnectorPollingPagingProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CodelessConnectorPollingPagingProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CodelessConnectorPollingPagingProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CodelessConnectorPollingPagingProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CodelessConnectorPollingPagingProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("pagingType"u8);
            writer.WriteStringValue(PagingType);
            if (Optional.IsDefined(NextPageParaName))
            {
                writer.WritePropertyName("nextPageParaName"u8);
                writer.WriteStringValue(NextPageParaName);
            }
            if (Optional.IsDefined(NextPageTokenJsonPath))
            {
                writer.WritePropertyName("nextPageTokenJsonPath"u8);
                writer.WriteStringValue(NextPageTokenJsonPath);
            }
            if (Optional.IsDefined(PageCountAttributePath))
            {
                writer.WritePropertyName("pageCountAttributePath"u8);
                writer.WriteStringValue(PageCountAttributePath);
            }
            if (Optional.IsDefined(PageTotalCountAttributePath))
            {
                writer.WritePropertyName("pageTotalCountAttributePath"u8);
                writer.WriteStringValue(PageTotalCountAttributePath);
            }
            if (Optional.IsDefined(PageTimeStampAttributePath))
            {
                writer.WritePropertyName("pageTimeStampAttributePath"u8);
                writer.WriteStringValue(PageTimeStampAttributePath);
            }
            if (Optional.IsDefined(SearchTheLatestTimeStampFromEventsList))
            {
                writer.WritePropertyName("searchTheLatestTimeStampFromEventsList"u8);
                writer.WriteStringValue(SearchTheLatestTimeStampFromEventsList);
            }
            if (Optional.IsDefined(PageSizeParaName))
            {
                writer.WritePropertyName("pageSizeParaName"u8);
                writer.WriteStringValue(PageSizeParaName);
            }
            if (Optional.IsDefined(PageSize))
            {
                writer.WritePropertyName("pageSize"u8);
                writer.WriteNumberValue(PageSize.Value);
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

        CodelessConnectorPollingPagingProperties IJsonModel<CodelessConnectorPollingPagingProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CodelessConnectorPollingPagingProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CodelessConnectorPollingPagingProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCodelessConnectorPollingPagingProperties(document.RootElement, options);
        }

        internal static CodelessConnectorPollingPagingProperties DeserializeCodelessConnectorPollingPagingProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string pagingType = default;
            string nextPageParaName = default;
            string nextPageTokenJsonPath = default;
            string pageCountAttributePath = default;
            string pageTotalCountAttributePath = default;
            string pageTimeStampAttributePath = default;
            string searchTheLatestTimeStampFromEventsList = default;
            string pageSizeParaName = default;
            int? pageSize = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pagingType"u8))
                {
                    pagingType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nextPageParaName"u8))
                {
                    nextPageParaName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nextPageTokenJsonPath"u8))
                {
                    nextPageTokenJsonPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pageCountAttributePath"u8))
                {
                    pageCountAttributePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pageTotalCountAttributePath"u8))
                {
                    pageTotalCountAttributePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pageTimeStampAttributePath"u8))
                {
                    pageTimeStampAttributePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("searchTheLatestTimeStampFromEventsList"u8))
                {
                    searchTheLatestTimeStampFromEventsList = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pageSizeParaName"u8))
                {
                    pageSizeParaName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pageSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pageSize = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CodelessConnectorPollingPagingProperties(
                pagingType,
                nextPageParaName,
                nextPageTokenJsonPath,
                pageCountAttributePath,
                pageTotalCountAttributePath,
                pageTimeStampAttributePath,
                searchTheLatestTimeStampFromEventsList,
                pageSizeParaName,
                pageSize,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PagingType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  pagingType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PagingType))
                {
                    builder.Append("  pagingType: ");
                    if (PagingType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PagingType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PagingType}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NextPageParaName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  nextPageParaName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NextPageParaName))
                {
                    builder.Append("  nextPageParaName: ");
                    if (NextPageParaName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{NextPageParaName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{NextPageParaName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NextPageTokenJsonPath), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  nextPageTokenJsonPath: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NextPageTokenJsonPath))
                {
                    builder.Append("  nextPageTokenJsonPath: ");
                    if (NextPageTokenJsonPath.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{NextPageTokenJsonPath}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{NextPageTokenJsonPath}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PageCountAttributePath), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  pageCountAttributePath: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PageCountAttributePath))
                {
                    builder.Append("  pageCountAttributePath: ");
                    if (PageCountAttributePath.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PageCountAttributePath}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PageCountAttributePath}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PageTotalCountAttributePath), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  pageTotalCountAttributePath: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PageTotalCountAttributePath))
                {
                    builder.Append("  pageTotalCountAttributePath: ");
                    if (PageTotalCountAttributePath.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PageTotalCountAttributePath}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PageTotalCountAttributePath}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PageTimeStampAttributePath), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  pageTimeStampAttributePath: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PageTimeStampAttributePath))
                {
                    builder.Append("  pageTimeStampAttributePath: ");
                    if (PageTimeStampAttributePath.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PageTimeStampAttributePath}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PageTimeStampAttributePath}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SearchTheLatestTimeStampFromEventsList), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  searchTheLatestTimeStampFromEventsList: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SearchTheLatestTimeStampFromEventsList))
                {
                    builder.Append("  searchTheLatestTimeStampFromEventsList: ");
                    if (SearchTheLatestTimeStampFromEventsList.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SearchTheLatestTimeStampFromEventsList}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SearchTheLatestTimeStampFromEventsList}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PageSizeParaName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  pageSizeParaName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PageSizeParaName))
                {
                    builder.Append("  pageSizeParaName: ");
                    if (PageSizeParaName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PageSizeParaName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PageSizeParaName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PageSize), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  pageSize: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PageSize))
                {
                    builder.Append("  pageSize: ");
                    builder.AppendLine($"{PageSize.Value}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<CodelessConnectorPollingPagingProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CodelessConnectorPollingPagingProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CodelessConnectorPollingPagingProperties)} does not support writing '{options.Format}' format.");
            }
        }

        CodelessConnectorPollingPagingProperties IPersistableModel<CodelessConnectorPollingPagingProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CodelessConnectorPollingPagingProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCodelessConnectorPollingPagingProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CodelessConnectorPollingPagingProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CodelessConnectorPollingPagingProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
