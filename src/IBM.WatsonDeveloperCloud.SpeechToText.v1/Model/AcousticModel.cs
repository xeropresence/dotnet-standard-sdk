/**
* Copyright 2018 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IBM.WatsonDeveloperCloud.SpeechToText.v1.Model
{
    /// <summary>
    /// AcousticModel.
    /// </summary>
    public class AcousticModel : BaseModel
    {
        /// <summary>
        /// The current status of the custom acoustic model:
        /// * `pending` indicates that the model was created but is waiting either for training data to be added or for
        /// the service to finish analyzing added data.
        /// * `ready` indicates that the model contains data and is ready to be trained.
        /// * `training` indicates that the model is currently being trained.
        /// * `available` indicates that the model is trained and ready to use.
        /// * `upgrading` indicates that the model is currently being upgraded.
        /// * `failed` indicates that training of the model failed.
        /// </summary>
        /// <value>
        /// The current status of the custom acoustic model:
        /// * `pending` indicates that the model was created but is waiting either for training data to be added or for
        /// the service to finish analyzing added data.
        /// * `ready` indicates that the model contains data and is ready to be trained.
        /// * `training` indicates that the model is currently being trained.
        /// * `available` indicates that the model is trained and ready to use.
        /// * `upgrading` indicates that the model is currently being upgraded.
        /// * `failed` indicates that training of the model failed.
        /// </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum PENDING for pending
            /// </summary>
            [EnumMember(Value = "pending")]
            PENDING,
            
            /// <summary>
            /// Enum READY for ready
            /// </summary>
            [EnumMember(Value = "ready")]
            READY,
            
            /// <summary>
            /// Enum TRAINING for training
            /// </summary>
            [EnumMember(Value = "training")]
            TRAINING,
            
            /// <summary>
            /// Enum AVAILABLE for available
            /// </summary>
            [EnumMember(Value = "available")]
            AVAILABLE,
            
            /// <summary>
            /// Enum UPGRADING for upgrading
            /// </summary>
            [EnumMember(Value = "upgrading")]
            UPGRADING,
            
            /// <summary>
            /// Enum FAILED for failed
            /// </summary>
            [EnumMember(Value = "failed")]
            FAILED
        }

        /// <summary>
        /// The current status of the custom acoustic model:
        /// * `pending` indicates that the model was created but is waiting either for training data to be added or for
        /// the service to finish analyzing added data.
        /// * `ready` indicates that the model contains data and is ready to be trained.
        /// * `training` indicates that the model is currently being trained.
        /// * `available` indicates that the model is trained and ready to use.
        /// * `upgrading` indicates that the model is currently being upgraded.
        /// * `failed` indicates that training of the model failed.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The customization ID (GUID) of the custom acoustic model. The **Create a custom acoustic model** method
        /// returns only this field of the object; it does not return the other fields.
        /// </summary>
        [JsonProperty("customization_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomizationId { get; set; }
        /// <summary>
        /// The date and time in Coordinated Universal Time (UTC) at which the custom acoustic model was created. The
        /// value is provided in full ISO 8601 format (`YYYY-MM-DDThh:mm:ss.sTZD`).
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }
        /// <summary>
        /// The language identifier of the custom acoustic model (for example, `en-US`).
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }
        /// <summary>
        /// A list of the available versions of the custom acoustic model. Each element of the array indicates a version
        /// of the base model with which the custom model can be used. Multiple versions exist only if the custom model
        /// has been upgraded; otherwise, only a single version is shown.
        /// </summary>
        [JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Versions { get; set; }
        /// <summary>
        /// The GUID of the service credentials for the instance of the service that owns the custom acoustic model.
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }
        /// <summary>
        /// The name of the custom acoustic model.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        /// <summary>
        /// The description of the custom acoustic model.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
        /// <summary>
        /// The name of the language model for which the custom acoustic model was created.
        /// </summary>
        [JsonProperty("base_model_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BaseModelName { get; set; }
        /// <summary>
        /// A percentage that indicates the progress of the custom acoustic model's current training. A value of `100`
        /// means that the model is fully trained. **Note:** The `progress` field does not currently reflect the
        /// progress of the training. The field changes from `0` to `100` when training is complete.
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public long? Progress { get; set; }
        /// <summary>
        /// If the request included unknown parameters, the following message: `Unexpected query parameter(s)
        /// ['parameters'] detected`, where `parameters` is a list that includes a quoted string for each unknown
        /// parameter.
        /// </summary>
        [JsonProperty("warnings", NullValueHandling = NullValueHandling.Ignore)]
        public string Warnings { get; set; }
    }

}