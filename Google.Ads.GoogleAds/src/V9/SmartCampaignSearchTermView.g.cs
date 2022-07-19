// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/resources/smart_campaign_search_term_view.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/resources/smart_campaign_search_term_view.proto</summary>
  public static partial class SmartCampaignSearchTermViewReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/resources/smart_campaign_search_term_view.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SmartCampaignSearchTermViewReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckdnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9yZXNvdXJjZXMvc21hcnRfY2Ft",
            "cGFpZ25fc2VhcmNoX3Rlcm1fdmlldy5wcm90bxIhZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjkucmVzb3VyY2VzGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9y",
            "LnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvItICChtTbWFydENh",
            "bXBhaWduU2VhcmNoVGVybVZpZXcSUwoNcmVzb3VyY2VfbmFtZRgBIAEoCUI8",
            "4EED+kE2CjRnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vU21hcnRDYW1wYWln",
            "blNlYXJjaFRlcm1WaWV3EhgKC3NlYXJjaF90ZXJtGAIgASgJQgPgQQMSOwoI",
            "Y2FtcGFpZ24YAyABKAlCKeBBA/pBIwohZ29vZ2xlYWRzLmdvb2dsZWFwaXMu",
            "Y29tL0NhbXBhaWduOoYB6kGCAQo0Z29vZ2xlYWRzLmdvb2dsZWFwaXMuY29t",
            "L1NtYXJ0Q2FtcGFpZ25TZWFyY2hUZXJtVmlldxJKY3VzdG9tZXJzL3tjdXN0",
            "b21lcl9pZH0vc21hcnRDYW1wYWlnblNlYXJjaFRlcm1WaWV3cy97Y2FtcGFp",
            "Z25faWR9fntxdWVyeX1CjQIKJWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "OS5yZXNvdXJjZXNCIFNtYXJ0Q2FtcGFpZ25TZWFyY2hUZXJtVmlld1Byb3Rv",
            "UAFaSmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRz",
            "L2dvb2dsZWFkcy92OS9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIhR29v",
            "Z2xlLkFkcy5Hb29nbGVBZHMuVjkuUmVzb3VyY2VzygIhR29vZ2xlXEFkc1xH",
            "b29nbGVBZHNcVjlcUmVzb3VyY2Vz6gIlR29vZ2xlOjpBZHM6Okdvb2dsZUFk",
            "czo6Vjk6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Resources.SmartCampaignSearchTermView), global::Google.Ads.GoogleAds.V9.Resources.SmartCampaignSearchTermView.Parser, new[]{ "ResourceName", "SearchTerm", "Campaign" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A Smart campaign search term view.
  /// </summary>
  public sealed partial class SmartCampaignSearchTermView : pb::IMessage<SmartCampaignSearchTermView>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SmartCampaignSearchTermView> _parser = new pb::MessageParser<SmartCampaignSearchTermView>(() => new SmartCampaignSearchTermView());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SmartCampaignSearchTermView> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Resources.SmartCampaignSearchTermViewReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SmartCampaignSearchTermView() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SmartCampaignSearchTermView(SmartCampaignSearchTermView other) : this() {
      resourceName_ = other.resourceName_;
      searchTerm_ = other.searchTerm_;
      campaign_ = other.campaign_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SmartCampaignSearchTermView Clone() {
      return new SmartCampaignSearchTermView(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the Smart campaign search term view.
    /// Smart campaign search term view resource names have the form:
    ///
    /// `customers/{customer_id}/smartCampaignSearchTermViews/{campaign_id}~{URL-base64_search_term}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "search_term" field.</summary>
    public const int SearchTermFieldNumber = 2;
    private string searchTerm_ = "";
    /// <summary>
    /// Output only. The search term.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SearchTerm {
      get { return searchTerm_; }
      set {
        searchTerm_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "campaign" field.</summary>
    public const int CampaignFieldNumber = 3;
    private string campaign_ = "";
    /// <summary>
    /// Output only. The Smart campaign the search term served in.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Campaign {
      get { return campaign_; }
      set {
        campaign_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SmartCampaignSearchTermView);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SmartCampaignSearchTermView other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (SearchTerm != other.SearchTerm) return false;
      if (Campaign != other.Campaign) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (SearchTerm.Length != 0) hash ^= SearchTerm.GetHashCode();
      if (Campaign.Length != 0) hash ^= Campaign.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (SearchTerm.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SearchTerm);
      }
      if (Campaign.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Campaign);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (SearchTerm.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SearchTerm);
      }
      if (Campaign.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Campaign);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (SearchTerm.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SearchTerm);
      }
      if (Campaign.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Campaign);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SmartCampaignSearchTermView other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.SearchTerm.Length != 0) {
        SearchTerm = other.SearchTerm;
      }
      if (other.Campaign.Length != 0) {
        Campaign = other.Campaign;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
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
          case 18: {
            SearchTerm = input.ReadString();
            break;
          }
          case 26: {
            Campaign = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            SearchTerm = input.ReadString();
            break;
          }
          case 26: {
            Campaign = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code