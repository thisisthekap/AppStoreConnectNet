/*
 * App Store Connect API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 3.6.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = AppStoreConnect.Net.Client.FileParameter;
using OpenAPIDateConverter = AppStoreConnect.Net.Client.OpenAPIDateConverter;
using System.Reflection;

namespace AppStoreConnect.Net.Model
{
    /// <summary>
    /// GameCenterLeaderboardReleasesResponseIncludedInner
    /// </summary>
    [JsonConverter(typeof(GameCenterLeaderboardReleasesResponseIncludedInnerJsonConverter))]
    [DataContract(Name = "GameCenterLeaderboardReleasesResponse_included_inner")]
    public partial class GameCenterLeaderboardReleasesResponseIncludedInner : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardReleasesResponseIncludedInner" /> class
        /// with the <see cref="GameCenterDetail" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GameCenterDetail.</param>
        public GameCenterLeaderboardReleasesResponseIncludedInner(GameCenterDetail actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardReleasesResponseIncludedInner" /> class
        /// with the <see cref="GameCenterLeaderboard" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GameCenterLeaderboard.</param>
        public GameCenterLeaderboardReleasesResponseIncludedInner(GameCenterLeaderboard actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(GameCenterDetail) || value is GameCenterDetail)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GameCenterLeaderboard) || value is GameCenterLeaderboard)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: GameCenterDetail, GameCenterLeaderboard");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `GameCenterDetail`. If the actual instance is not `GameCenterDetail`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GameCenterDetail</returns>
        public GameCenterDetail GetGameCenterDetail()
        {
            return (GameCenterDetail)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GameCenterLeaderboard`. If the actual instance is not `GameCenterLeaderboard`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GameCenterLeaderboard</returns>
        public GameCenterLeaderboard GetGameCenterLeaderboard()
        {
            return (GameCenterLeaderboard)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GameCenterLeaderboardReleasesResponseIncludedInner {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, GameCenterLeaderboardReleasesResponseIncludedInner.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of GameCenterLeaderboardReleasesResponseIncludedInner
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of GameCenterLeaderboardReleasesResponseIncludedInner</returns>
        public static GameCenterLeaderboardReleasesResponseIncludedInner FromJson(string jsonString)
        {
            GameCenterLeaderboardReleasesResponseIncludedInner newGameCenterLeaderboardReleasesResponseIncludedInner = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newGameCenterLeaderboardReleasesResponseIncludedInner;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GameCenterDetail).GetProperty("AdditionalProperties") == null)
                {
                    newGameCenterLeaderboardReleasesResponseIncludedInner = new GameCenterLeaderboardReleasesResponseIncludedInner(JsonConvert.DeserializeObject<GameCenterDetail>(jsonString, GameCenterLeaderboardReleasesResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newGameCenterLeaderboardReleasesResponseIncludedInner = new GameCenterLeaderboardReleasesResponseIncludedInner(JsonConvert.DeserializeObject<GameCenterDetail>(jsonString, GameCenterLeaderboardReleasesResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GameCenterDetail");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GameCenterDetail: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GameCenterLeaderboard).GetProperty("AdditionalProperties") == null)
                {
                    newGameCenterLeaderboardReleasesResponseIncludedInner = new GameCenterLeaderboardReleasesResponseIncludedInner(JsonConvert.DeserializeObject<GameCenterLeaderboard>(jsonString, GameCenterLeaderboardReleasesResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newGameCenterLeaderboardReleasesResponseIncludedInner = new GameCenterLeaderboardReleasesResponseIncludedInner(JsonConvert.DeserializeObject<GameCenterLeaderboard>(jsonString, GameCenterLeaderboardReleasesResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GameCenterLeaderboard");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GameCenterLeaderboard: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newGameCenterLeaderboardReleasesResponseIncludedInner;
        }


        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for GameCenterLeaderboardReleasesResponseIncludedInner
    /// </summary>
    public class GameCenterLeaderboardReleasesResponseIncludedInnerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(GameCenterLeaderboardReleasesResponseIncludedInner).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch(reader.TokenType) 
            {
                case JsonToken.StartObject:
                    return GameCenterLeaderboardReleasesResponseIncludedInner.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return GameCenterLeaderboardReleasesResponseIncludedInner.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
