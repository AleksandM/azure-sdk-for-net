// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text.Authoring.Models
{
    /// <summary> Represents an evaluation result Sentiment label. </summary>
    public partial class DocumentSentimentLabelEvaluationResult
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

        /// <summary> Initializes a new instance of <see cref="DocumentSentimentLabelEvaluationResult"/>. </summary>
        /// <param name="category"> Represents the sentiment category. </param>
        /// <param name="offset"> Represents the sentiment offset index relative to the original text. </param>
        /// <param name="length"> Represents the sentiment length. </param>
        internal DocumentSentimentLabelEvaluationResult(TextAnalysisAuthoringSentiment category, int offset, int length)
        {
            Category = category;
            Offset = offset;
            Length = length;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentSentimentLabelEvaluationResult"/>. </summary>
        /// <param name="category"> Represents the sentiment category. </param>
        /// <param name="offset"> Represents the sentiment offset index relative to the original text. </param>
        /// <param name="length"> Represents the sentiment length. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentSentimentLabelEvaluationResult(TextAnalysisAuthoringSentiment category, int offset, int length, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Category = category;
            Offset = offset;
            Length = length;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentSentimentLabelEvaluationResult"/> for deserialization. </summary>
        internal DocumentSentimentLabelEvaluationResult()
        {
        }

        /// <summary> Represents the sentiment category. </summary>
        public TextAnalysisAuthoringSentiment Category { get; }
        /// <summary> Represents the sentiment offset index relative to the original text. </summary>
        public int Offset { get; }
        /// <summary> Represents the sentiment length. </summary>
        public int Length { get; }
    }
}
