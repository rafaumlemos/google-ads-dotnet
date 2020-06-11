// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/resources/customer_client_link.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/resources/customer_client_link.proto</summary>
  public static partial class CustomerClientLinkReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/resources/customer_client_link.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerClientLinkReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92My9yZXNvdXJjZXMvY3VzdG9tZXJf",
            "Y2xpZW50X2xpbmsucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLnJl",
            "c291cmNlcxo3Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjMvZW51bXMvbWFuYWdl",
            "cl9saW5rX3N0YXR1cy5wcm90bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlv",
            "ci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90bxoeZ29vZ2xlL3By",
            "b3RvYnVmL3dyYXBwZXJzLnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25z",
            "LnByb3RvIs4DChJDdXN0b21lckNsaWVudExpbmsSSgoNcmVzb3VyY2VfbmFt",
            "ZRgBIAEoCUIz4EEF+kEtCitnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQ3Vz",
            "dG9tZXJDbGllbnRMaW5rEjoKD2NsaWVudF9jdXN0b21lchgDIAEoCzIcLmdv",
            "b2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZUID4EEFEjkKD21hbmFnZXJfbGlu",
            "a19pZBgEIAEoCzIbLmdvb2dsZS5wcm90b2J1Zi5JbnQ2NFZhbHVlQgPgQQMS",
            "VgoGc3RhdHVzGAUgASgOMkYuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuZW51",
            "bXMuTWFuYWdlckxpbmtTdGF0dXNFbnVtLk1hbmFnZXJMaW5rU3RhdHVzEioK",
            "BmhpZGRlbhgGIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5Cb29sVmFsdWU6cepB",
            "bgorZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0N1c3RvbWVyQ2xpZW50TGlu",
            "axI/Y3VzdG9tZXJzL3tjdXN0b21lcn0vY3VzdG9tZXJDbGllbnRMaW5rcy97",
            "Y3VzdG9tZXJfY2xpZW50X2xpbmt9QoQCCiVjb20uZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjMucmVzb3VyY2VzQhdDdXN0b21lckNsaWVudExpbmtQcm90b1AB",
            "Wkpnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9n",
            "b29nbGVhZHMvdjMvcmVzb3VyY2VzO3Jlc291cmNlc6ICA0dBQaoCIUdvb2ds",
            "ZS5BZHMuR29vZ2xlQWRzLlYzLlJlc291cmNlc8oCIUdvb2dsZVxBZHNcR29v",
            "Z2xlQWRzXFYzXFJlc291cmNlc+oCJUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6",
            "OlYzOjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V3.Enums.ManagerLinkStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Resources.CustomerClientLink), global::Google.Ads.GoogleAds.V3.Resources.CustomerClientLink.Parser, new[]{ "ResourceName", "ClientCustomer", "ManagerLinkId", "Status", "Hidden" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents customer client link relationship.
  /// </summary>
  public sealed partial class CustomerClientLink : pb::IMessage<CustomerClientLink> {
    private static readonly pb::MessageParser<CustomerClientLink> _parser = new pb::MessageParser<CustomerClientLink>(() => new CustomerClientLink());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CustomerClientLink> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Resources.CustomerClientLinkReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerClientLink() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerClientLink(CustomerClientLink other) : this() {
      resourceName_ = other.resourceName_;
      ClientCustomer = other.ClientCustomer;
      ManagerLinkId = other.ManagerLinkId;
      status_ = other.status_;
      Hidden = other.Hidden;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerClientLink Clone() {
      return new CustomerClientLink(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. Name of the resource.
    /// CustomerClientLink resource names have the form:
    /// `customers/{customer_id}/customerClientLinks/{client_customer_id}~{manager_link_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "client_customer" field.</summary>
    public const int ClientCustomerFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_clientCustomer_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string clientCustomer_;
    /// <summary>
    /// Immutable. The client customer linked to this customer.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ClientCustomer {
      get { return clientCustomer_; }
      set {
        clientCustomer_ = value;
      }
    }


    /// <summary>Field number for the "manager_link_id" field.</summary>
    public const int ManagerLinkIdFieldNumber = 4;
    private static readonly pb::FieldCodec<long?> _single_managerLinkId_codec = pb::FieldCodec.ForStructWrapper<long>(34);
    private long? managerLinkId_;
    /// <summary>
    /// Output only. This is uniquely identifies a customer client link. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? ManagerLinkId {
      get { return managerLinkId_; }
      set {
        managerLinkId_ = value;
      }
    }


    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V3.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus status_ = global::Google.Ads.GoogleAds.V3.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus.Unspecified;
    /// <summary>
    /// This is the status of the link between client and manager.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "hidden" field.</summary>
    public const int HiddenFieldNumber = 6;
    private static readonly pb::FieldCodec<bool?> _single_hidden_codec = pb::FieldCodec.ForStructWrapper<bool>(50);
    private bool? hidden_;
    /// <summary>
    /// The visibility of the link. Users can choose whether or not to see hidden
    /// links in the AdWords UI.
    /// Default value is false
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? Hidden {
      get { return hidden_; }
      set {
        hidden_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CustomerClientLink);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CustomerClientLink other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (ClientCustomer != other.ClientCustomer) return false;
      if (ManagerLinkId != other.ManagerLinkId) return false;
      if (Status != other.Status) return false;
      if (Hidden != other.Hidden) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (clientCustomer_ != null) hash ^= ClientCustomer.GetHashCode();
      if (managerLinkId_ != null) hash ^= ManagerLinkId.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V3.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus.Unspecified) hash ^= Status.GetHashCode();
      if (hidden_ != null) hash ^= Hidden.GetHashCode();
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
      if (clientCustomer_ != null) {
        _single_clientCustomer_codec.WriteTagAndValue(output, ClientCustomer);
      }
      if (managerLinkId_ != null) {
        _single_managerLinkId_codec.WriteTagAndValue(output, ManagerLinkId);
      }
      if (Status != global::Google.Ads.GoogleAds.V3.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (hidden_ != null) {
        _single_hidden_codec.WriteTagAndValue(output, Hidden);
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
      if (clientCustomer_ != null) {
        size += _single_clientCustomer_codec.CalculateSizeWithTag(ClientCustomer);
      }
      if (managerLinkId_ != null) {
        size += _single_managerLinkId_codec.CalculateSizeWithTag(ManagerLinkId);
      }
      if (Status != global::Google.Ads.GoogleAds.V3.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (hidden_ != null) {
        size += _single_hidden_codec.CalculateSizeWithTag(Hidden);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CustomerClientLink other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.clientCustomer_ != null) {
        if (clientCustomer_ == null || other.ClientCustomer != "") {
          ClientCustomer = other.ClientCustomer;
        }
      }
      if (other.managerLinkId_ != null) {
        if (managerLinkId_ == null || other.ManagerLinkId != 0L) {
          ManagerLinkId = other.ManagerLinkId;
        }
      }
      if (other.Status != global::Google.Ads.GoogleAds.V3.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus.Unspecified) {
        Status = other.Status;
      }
      if (other.hidden_ != null) {
        if (hidden_ == null || other.Hidden != false) {
          Hidden = other.Hidden;
        }
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
          case 26: {
            string value = _single_clientCustomer_codec.Read(input);
            if (clientCustomer_ == null || value != "") {
              ClientCustomer = value;
            }
            break;
          }
          case 34: {
            long? value = _single_managerLinkId_codec.Read(input);
            if (managerLinkId_ == null || value != 0L) {
              ManagerLinkId = value;
            }
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V3.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus) input.ReadEnum();
            break;
          }
          case 50: {
            bool? value = _single_hidden_codec.Read(input);
            if (hidden_ == null || value != false) {
              Hidden = value;
            }
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code