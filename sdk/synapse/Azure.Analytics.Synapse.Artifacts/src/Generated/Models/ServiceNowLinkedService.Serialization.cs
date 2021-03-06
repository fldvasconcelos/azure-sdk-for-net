// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class ServiceNowLinkedService : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia");
                writer.WriteObjectValue(ConnectVia);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations");
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            writer.WritePropertyName("endpoint");
            writer.WriteObjectValue(Endpoint);
            writer.WritePropertyName("authenticationType");
            writer.WriteStringValue(AuthenticationType.ToString());
            if (Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username");
                writer.WriteObjectValue(Username);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password");
                writer.WriteObjectValue(Password);
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId");
                writer.WriteObjectValue(ClientId);
            }
            if (Optional.IsDefined(ClientSecret))
            {
                writer.WritePropertyName("clientSecret");
                writer.WriteObjectValue(ClientSecret);
            }
            if (Optional.IsDefined(UseEncryptedEndpoints))
            {
                writer.WritePropertyName("useEncryptedEndpoints");
                writer.WriteObjectValue(UseEncryptedEndpoints);
            }
            if (Optional.IsDefined(UseHostVerification))
            {
                writer.WritePropertyName("useHostVerification");
                writer.WriteObjectValue(UseHostVerification);
            }
            if (Optional.IsDefined(UsePeerVerification))
            {
                writer.WritePropertyName("usePeerVerification");
                writer.WriteObjectValue(UsePeerVerification);
            }
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential");
                writer.WriteObjectValue(EncryptedCredential);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static ServiceNowLinkedService DeserializeServiceNowLinkedService(JsonElement element)
        {
            string type = default;
            Optional<IntegrationRuntimeReference> connectVia = default;
            Optional<string> description = default;
            Optional<IDictionary<string, ParameterSpecification>> parameters = default;
            Optional<IList<object>> annotations = default;
            object endpoint = default;
            ServiceNowAuthenticationType authenticationType = default;
            Optional<object> username = default;
            Optional<SecretBase> password = default;
            Optional<object> clientId = default;
            Optional<SecretBase> clientSecret = default;
            Optional<object> useEncryptedEndpoints = default;
            Optional<object> useHostVerification = default;
            Optional<object> usePeerVerification = default;
            Optional<object> encryptedCredential = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"))
                {
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value);
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ParameterSpecification.DeserializeParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"))
                {
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetObject());
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("endpoint"))
                        {
                            endpoint = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("authenticationType"))
                        {
                            authenticationType = new ServiceNowAuthenticationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("username"))
                        {
                            username = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("password"))
                        {
                            password = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("clientId"))
                        {
                            clientId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("clientSecret"))
                        {
                            clientSecret = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("useEncryptedEndpoints"))
                        {
                            useEncryptedEndpoints = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("useHostVerification"))
                        {
                            useHostVerification = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("usePeerVerification"))
                        {
                            usePeerVerification = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"))
                        {
                            encryptedCredential = property0.Value.GetObject();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary ??= new Dictionary<string, object>();
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ServiceNowLinkedService(type, connectVia.Value, description.Value, Optional.ToDictionary(parameters), Optional.ToList(annotations), additionalProperties, endpoint, authenticationType, username.Value, password.Value, clientId.Value, clientSecret.Value, useEncryptedEndpoints.Value, useHostVerification.Value, usePeerVerification.Value, encryptedCredential.Value);
        }
    }
}
