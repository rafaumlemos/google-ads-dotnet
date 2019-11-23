// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/services/customer_client_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/services/customer_client_service.proto</summary>
  public static partial class CustomerClientServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/services/customer_client_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerClientServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9zZXJ2aWNlcy9jdXN0b21lcl9j",
            "bGllbnRfc2VydmljZS5wcm90bxIgZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIu",
            "c2VydmljZXMaN2dvb2dsZS9hZHMvZ29vZ2xlYWRzL3YyL3Jlc291cmNlcy9j",
            "dXN0b21lcl9jbGllbnQucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMu",
            "cHJvdG8aF2dvb2dsZS9hcGkvY2xpZW50LnByb3RvIjEKGEdldEN1c3RvbWVy",
            "Q2xpZW50UmVxdWVzdBIVCg1yZXNvdXJjZV9uYW1lGAEgASgJMvQBChVDdXN0",
            "b21lckNsaWVudFNlcnZpY2USvQEKEUdldEN1c3RvbWVyQ2xpZW50EjouZ29v",
            "Z2xlLmFkcy5nb29nbGVhZHMudjIuc2VydmljZXMuR2V0Q3VzdG9tZXJDbGll",
            "bnRSZXF1ZXN0GjEuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIucmVzb3VyY2Vz",
            "LkN1c3RvbWVyQ2xpZW50IjmC0+STAjMSMS92Mi97cmVzb3VyY2VfbmFtZT1j",
            "dXN0b21lcnMvKi9jdXN0b21lckNsaWVudHMvKn0aG8pBGGdvb2dsZWFkcy5n",
            "b29nbGVhcGlzLmNvbUKBAgokY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYy",
            "LnNlcnZpY2VzQhpDdXN0b21lckNsaWVudFNlcnZpY2VQcm90b1ABWkhnb29n",
            "bGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVh",
            "ZHMvdjIvc2VydmljZXM7c2VydmljZXOiAgNHQUGqAiBHb29nbGUuQWRzLkdv",
            "b2dsZUFkcy5WMi5TZXJ2aWNlc8oCIEdvb2dsZVxBZHNcR29vZ2xlQWRzXFYy",
            "XFNlcnZpY2Vz6gIkR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjI6OlNlcnZp",
            "Y2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V2.Resources.CustomerClientReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Services.GetCustomerClientRequest), global::Google.Ads.GoogleAds.V2.Services.GetCustomerClientRequest.Parser, new[]{ "ResourceName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [CustomerClientService.GetCustomerClient][google.ads.googleads.v2.services.CustomerClientService.GetCustomerClient].
  /// </summary>
  public sealed partial class GetCustomerClientRequest : pb::IMessage<GetCustomerClientRequest> {
    private static readonly pb::MessageParser<GetCustomerClientRequest> _parser = new pb::MessageParser<GetCustomerClientRequest>(() => new GetCustomerClientRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetCustomerClientRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Services.CustomerClientServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCustomerClientRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCustomerClientRequest(GetCustomerClientRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCustomerClientRequest Clone() {
      return new GetCustomerClientRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the client to fetch.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetCustomerClientRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetCustomerClientRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetCustomerClientRequest other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code