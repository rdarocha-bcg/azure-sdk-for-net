// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Amazon Marketplace Web Service linked service. </summary>
    public partial class AmazonMwsLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="AmazonMwsLinkedService"/>. </summary>
        /// <param name="endpoint"> The endpoint of the Amazon MWS server, (i.e. mws.amazonservices.com). </param>
        /// <param name="marketplaceId"> The Amazon Marketplace ID you want to retrieve data from. To retrieve data from multiple Marketplace IDs, separate them with a comma (,). (i.e. A2EUQ1WTGCTBG2). </param>
        /// <param name="sellerId"> The Amazon seller ID. </param>
        /// <param name="accessKeyId"> The access key id used to access data. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/>, <paramref name="marketplaceId"/>, <paramref name="sellerId"/> or <paramref name="accessKeyId"/> is null. </exception>
        public AmazonMwsLinkedService(DataFactoryElement<string> endpoint, DataFactoryElement<string> marketplaceId, DataFactoryElement<string> sellerId, DataFactoryElement<string> accessKeyId)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(marketplaceId, nameof(marketplaceId));
            Argument.AssertNotNull(sellerId, nameof(sellerId));
            Argument.AssertNotNull(accessKeyId, nameof(accessKeyId));

            Endpoint = endpoint;
            MarketplaceId = marketplaceId;
            SellerId = sellerId;
            AccessKeyId = accessKeyId;
            LinkedServiceType = "AmazonMWS";
        }

        /// <summary> Initializes a new instance of <see cref="AmazonMwsLinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="endpoint"> The endpoint of the Amazon MWS server, (i.e. mws.amazonservices.com). </param>
        /// <param name="marketplaceId"> The Amazon Marketplace ID you want to retrieve data from. To retrieve data from multiple Marketplace IDs, separate them with a comma (,). (i.e. A2EUQ1WTGCTBG2). </param>
        /// <param name="sellerId"> The Amazon seller ID. </param>
        /// <param name="mwsAuthToken"> The Amazon MWS authentication token. </param>
        /// <param name="accessKeyId"> The access key id used to access data. </param>
        /// <param name="secretKey"> The secret key used to access data. </param>
        /// <param name="useEncryptedEndpoints"> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. </param>
        /// <param name="useHostVerification"> Specifies whether to require the host name in the server's certificate to match the host name of the server when connecting over SSL. The default value is true. </param>
        /// <param name="usePeerVerification"> Specifies whether to verify the identity of the server when connecting over SSL. The default value is true. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal AmazonMwsLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> endpoint, DataFactoryElement<string> marketplaceId, DataFactoryElement<string> sellerId, DataFactorySecretBaseDefinition mwsAuthToken, DataFactoryElement<string> accessKeyId, DataFactorySecretBaseDefinition secretKey, DataFactoryElement<bool> useEncryptedEndpoints, DataFactoryElement<bool> useHostVerification, DataFactoryElement<bool> usePeerVerification, string encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Endpoint = endpoint;
            MarketplaceId = marketplaceId;
            SellerId = sellerId;
            MwsAuthToken = mwsAuthToken;
            AccessKeyId = accessKeyId;
            SecretKey = secretKey;
            UseEncryptedEndpoints = useEncryptedEndpoints;
            UseHostVerification = useHostVerification;
            UsePeerVerification = usePeerVerification;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "AmazonMWS";
        }

        /// <summary> Initializes a new instance of <see cref="AmazonMwsLinkedService"/> for deserialization. </summary>
        internal AmazonMwsLinkedService()
        {
        }

        /// <summary> The endpoint of the Amazon MWS server, (i.e. mws.amazonservices.com). </summary>
        public DataFactoryElement<string> Endpoint { get; set; }
        /// <summary> The Amazon Marketplace ID you want to retrieve data from. To retrieve data from multiple Marketplace IDs, separate them with a comma (,). (i.e. A2EUQ1WTGCTBG2). </summary>
        public DataFactoryElement<string> MarketplaceId { get; set; }
        /// <summary> The Amazon seller ID. </summary>
        public DataFactoryElement<string> SellerId { get; set; }
        /// <summary> The Amazon MWS authentication token. </summary>
        public DataFactorySecretBaseDefinition MwsAuthToken { get; set; }
        /// <summary> The access key id used to access data. </summary>
        public DataFactoryElement<string> AccessKeyId { get; set; }
        /// <summary> The secret key used to access data. </summary>
        public DataFactorySecretBaseDefinition SecretKey { get; set; }
        /// <summary> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. </summary>
        public DataFactoryElement<bool> UseEncryptedEndpoints { get; set; }
        /// <summary> Specifies whether to require the host name in the server's certificate to match the host name of the server when connecting over SSL. The default value is true. </summary>
        public DataFactoryElement<bool> UseHostVerification { get; set; }
        /// <summary> Specifies whether to verify the identity of the server when connecting over SSL. The default value is true. </summary>
        public DataFactoryElement<bool> UsePeerVerification { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
