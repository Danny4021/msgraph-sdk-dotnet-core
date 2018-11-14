// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IIosVppAppAssignedUserLicenseRequest.
    /// </summary>
    public partial interface IIosVppAppAssignedUserLicenseRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosVppAppAssignedUserLicense using PUT.
        /// </summary>
        /// <param name="iosVppAppAssignedUserLicenseToCreate">The IosVppAppAssignedUserLicense to create.</param>
        /// <returns>The created IosVppAppAssignedUserLicense.</returns>
        System.Threading.Tasks.Task<IosVppAppAssignedUserLicense> CreateAsync(IosVppAppAssignedUserLicense iosVppAppAssignedUserLicenseToCreate);        /// <summary>
        /// Creates the specified IosVppAppAssignedUserLicense using PUT.
        /// </summary>
        /// <param name="iosVppAppAssignedUserLicenseToCreate">The IosVppAppAssignedUserLicense to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosVppAppAssignedUserLicense.</returns>
        System.Threading.Tasks.Task<IosVppAppAssignedUserLicense> CreateAsync(IosVppAppAssignedUserLicense iosVppAppAssignedUserLicenseToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IosVppAppAssignedUserLicense.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified IosVppAppAssignedUserLicense.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IosVppAppAssignedUserLicense.
        /// </summary>
        /// <returns>The IosVppAppAssignedUserLicense.</returns>
        System.Threading.Tasks.Task<IosVppAppAssignedUserLicense> GetAsync();

        /// <summary>
        /// Gets the specified IosVppAppAssignedUserLicense.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosVppAppAssignedUserLicense.</returns>
        System.Threading.Tasks.Task<IosVppAppAssignedUserLicense> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IosVppAppAssignedUserLicense using PATCH.
        /// </summary>
        /// <param name="iosVppAppAssignedUserLicenseToUpdate">The IosVppAppAssignedUserLicense to update.</param>
        /// <returns>The updated IosVppAppAssignedUserLicense.</returns>
        System.Threading.Tasks.Task<IosVppAppAssignedUserLicense> UpdateAsync(IosVppAppAssignedUserLicense iosVppAppAssignedUserLicenseToUpdate);

        /// <summary>
        /// Updates the specified IosVppAppAssignedUserLicense using PATCH.
        /// </summary>
        /// <param name="iosVppAppAssignedUserLicenseToUpdate">The IosVppAppAssignedUserLicense to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated IosVppAppAssignedUserLicense.</returns>
        System.Threading.Tasks.Task<IosVppAppAssignedUserLicense> UpdateAsync(IosVppAppAssignedUserLicense iosVppAppAssignedUserLicenseToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosVppAppAssignedUserLicenseRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosVppAppAssignedUserLicenseRequest Expand(Expression<Func<IosVppAppAssignedUserLicense, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosVppAppAssignedUserLicenseRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosVppAppAssignedUserLicenseRequest Select(Expression<Func<IosVppAppAssignedUserLicense, object>> selectExpression);

    }
}