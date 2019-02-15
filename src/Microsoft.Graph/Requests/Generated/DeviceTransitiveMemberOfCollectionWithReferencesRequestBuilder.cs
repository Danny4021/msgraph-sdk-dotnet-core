// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DeviceTransitiveMemberOfCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class DeviceTransitiveMemberOfCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IDeviceTransitiveMemberOfCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new DeviceTransitiveMemberOfCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceTransitiveMemberOfCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceTransitiveMemberOfCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceTransitiveMemberOfCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new DeviceTransitiveMemberOfCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDirectoryObjectWithReferenceRequestBuilder"/> for the specified DeviceDirectoryObject.
        /// </summary>
        /// <param name="id">The ID for the DeviceDirectoryObject.</param>
        /// <returns>The <see cref="IDirectoryObjectWithReferenceRequestBuilder"/>.</returns>
        public IDirectoryObjectWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new DirectoryObjectWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IDeviceTransitiveMemberOfCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IDeviceTransitiveMemberOfCollectionReferencesRequestBuilder"/>.</returns>
        public IDeviceTransitiveMemberOfCollectionReferencesRequestBuilder References
        {
            get
            {
                return new DeviceTransitiveMemberOfCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
