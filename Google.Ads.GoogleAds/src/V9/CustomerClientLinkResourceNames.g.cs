// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V9.Resources
{
    /// <summary>Resource name for the <c>CustomerClientLink</c> resource.</summary>
    public sealed partial class CustomerClientLinkName : gax::IResourceName, sys::IEquatable<CustomerClientLinkName>
    {
        /// <summary>The possible contents of <see cref="CustomerClientLinkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/customerClientLinks/{client_customer_id}~{manager_link_id}</c>.
            /// </summary>
            CustomerClientCustomerManagerLink = 1,
        }

        private static gax::PathTemplate s_customerClientCustomerManagerLink = new gax::PathTemplate("customers/{customer_id}/customerClientLinks/{client_customer_id_manager_link_id}");

        /// <summary>Creates a <see cref="CustomerClientLinkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CustomerClientLinkName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CustomerClientLinkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CustomerClientLinkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CustomerClientLinkName"/> with the pattern
        /// <c>customers/{customer_id}/customerClientLinks/{client_customer_id}~{manager_link_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clientCustomerId">The <c>ClientCustomer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="managerLinkId">The <c>ManagerLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CustomerClientLinkName"/> constructed from the provided ids.</returns>
        public static CustomerClientLinkName FromCustomerClientCustomerManagerLink(string customerId, string clientCustomerId, string managerLinkId) =>
            new CustomerClientLinkName(ResourceNameType.CustomerClientCustomerManagerLink, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), clientCustomerId: gax::GaxPreconditions.CheckNotNullOrEmpty(clientCustomerId, nameof(clientCustomerId)), managerLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(managerLinkId, nameof(managerLinkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerClientLinkName"/> with pattern
        /// <c>customers/{customer_id}/customerClientLinks/{client_customer_id}~{manager_link_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clientCustomerId">The <c>ClientCustomer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="managerLinkId">The <c>ManagerLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomerClientLinkName"/> with pattern
        /// <c>customers/{customer_id}/customerClientLinks/{client_customer_id}~{manager_link_id}</c>.
        /// </returns>
        public static string Format(string customerId, string clientCustomerId, string managerLinkId) =>
            FormatCustomerClientCustomerManagerLink(customerId, clientCustomerId, managerLinkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerClientLinkName"/> with pattern
        /// <c>customers/{customer_id}/customerClientLinks/{client_customer_id}~{manager_link_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clientCustomerId">The <c>ClientCustomer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="managerLinkId">The <c>ManagerLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomerClientLinkName"/> with pattern
        /// <c>customers/{customer_id}/customerClientLinks/{client_customer_id}~{manager_link_id}</c>.
        /// </returns>
        public static string FormatCustomerClientCustomerManagerLink(string customerId, string clientCustomerId, string managerLinkId) =>
            s_customerClientCustomerManagerLink.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(clientCustomerId, nameof(clientCustomerId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(managerLinkId, nameof(managerLinkId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerClientLinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/customerClientLinks/{client_customer_id}~{manager_link_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customerClientLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomerClientLinkName"/> if successful.</returns>
        public static CustomerClientLinkName Parse(string customerClientLinkName) => Parse(customerClientLinkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerClientLinkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/customerClientLinks/{client_customer_id}~{manager_link_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerClientLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CustomerClientLinkName"/> if successful.</returns>
        public static CustomerClientLinkName Parse(string customerClientLinkName, bool allowUnparsed) =>
            TryParse(customerClientLinkName, allowUnparsed, out CustomerClientLinkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerClientLinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/customerClientLinks/{client_customer_id}~{manager_link_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customerClientLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerClientLinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerClientLinkName, out CustomerClientLinkName result) =>
            TryParse(customerClientLinkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerClientLinkName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/customerClientLinks/{client_customer_id}~{manager_link_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerClientLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerClientLinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerClientLinkName, bool allowUnparsed, out CustomerClientLinkName result)
        {
            gax::GaxPreconditions.CheckNotNull(customerClientLinkName, nameof(customerClientLinkName));
            gax::TemplatedResourceName resourceName;
            if (s_customerClientCustomerManagerLink.TryParseName(customerClientLinkName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerClientCustomerManagerLink(resourceName[0], split1[0], split1[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(customerClientLinkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private static string[] ParseSplitHelper(string s, char[] separators)
        {
            string[] result = new string[separators.Length + 1];
            int i0 = 0;
            for (int i = 0; i <= separators.Length; i++)
            {
                int i1 = i < separators.Length ? s.IndexOf(separators[i], i0) : s.Length;
                if (i1 < 0 || i1 == i0)
                {
                    return null;
                }
                result[i] = s.Substring(i0, i1 - i0);
                i0 = i1 + 1;
            }
            return result;
        }

        private CustomerClientLinkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string clientCustomerId = null, string customerId = null, string managerLinkId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ClientCustomerId = clientCustomerId;
            CustomerId = customerId;
            ManagerLinkId = managerLinkId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomerClientLinkName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/customerClientLinks/{client_customer_id}~{manager_link_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clientCustomerId">The <c>ClientCustomer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="managerLinkId">The <c>ManagerLink</c> ID. Must not be <c>null</c> or empty.</param>
        public CustomerClientLinkName(string customerId, string clientCustomerId, string managerLinkId) : this(ResourceNameType.CustomerClientCustomerManagerLink, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), clientCustomerId: gax::GaxPreconditions.CheckNotNullOrEmpty(clientCustomerId, nameof(clientCustomerId)), managerLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(managerLinkId, nameof(managerLinkId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>ClientCustomer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ClientCustomerId { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The <c>ManagerLink</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ManagerLinkId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerClientCustomerManagerLink: return s_customerClientCustomerManagerLink.Expand(CustomerId, $"{ClientCustomerId}~{ManagerLinkId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomerClientLinkName);

        /// <inheritdoc/>
        public bool Equals(CustomerClientLinkName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CustomerClientLinkName a, CustomerClientLinkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CustomerClientLinkName a, CustomerClientLinkName b) => !(a == b);
    }

    public partial class CustomerClientLink
    {
        /// <summary>
        /// <see cref="CustomerClientLinkName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal CustomerClientLinkName ResourceNameAsCustomerClientLinkName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CustomerClientLinkName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CustomerName"/>-typed view over the <see cref="ClientCustomer"/> resource name property.
        /// </summary>
        internal CustomerName ClientCustomerAsCustomerName
        {
            get => string.IsNullOrEmpty(ClientCustomer) ? null : CustomerName.Parse(ClientCustomer, allowUnparsed: true);
            set => ClientCustomer = value?.ToString() ?? "";
        }
    }
}