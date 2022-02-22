// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/enums/asset_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/enums/asset_type.proto</summary>
  public static partial class AssetTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/enums/asset_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9nb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZW51bXMvYXNzZXRfdHlwZS5w",
            "cm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEwLmVudW1zGhxnb29nbGUv",
            "YXBpL2Fubm90YXRpb25zLnByb3RvIswCCg1Bc3NldFR5cGVFbnVtIroCCglB",
            "c3NldFR5cGUSDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESEQoNWU9V",
            "VFVCRV9WSURFTxACEhAKDE1FRElBX0JVTkRMRRADEgkKBUlNQUdFEAQSCAoE",
            "VEVYVBAFEg0KCUxFQURfRk9STRAGEhIKDkJPT0tfT05fR09PR0xFEAcSDQoJ",
            "UFJPTU9USU9OEAgSCwoHQ0FMTE9VVBAJEhYKElNUUlVDVFVSRURfU05JUFBF",
            "VBAKEgwKCFNJVEVMSU5LEAsSDQoJUEFHRV9GRUVEEAwSFQoRRFlOQU1JQ19F",
            "RFVDQVRJT04QDRIOCgpNT0JJTEVfQVBQEA4SEQoNSE9URUxfQ0FMTE9VVBAP",
            "EggKBENBTEwQEBIJCgVQUklDRRAREhIKDkNBTExfVE9fQUNUSU9OEBJC6AEK",
            "ImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTAuZW51bXNCDkFzc2V0VHlw",
            "ZVByb3RvUAFaQ2dvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFw",
            "aXMvYWRzL2dvb2dsZWFkcy92MTAvZW51bXM7ZW51bXOiAgNHQUGqAh5Hb29n",
            "bGUuQWRzLkdvb2dsZUFkcy5WMTAuRW51bXPKAh5Hb29nbGVcQWRzXEdvb2ds",
            "ZUFkc1xWMTBcRW51bXPqAiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTA6",
            "OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Enums.AssetTypeEnum), global::Google.Ads.GoogleAds.V10.Enums.AssetTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V10.Enums.AssetTypeEnum.Types.AssetType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing the types of asset.
  /// </summary>
  public sealed partial class AssetTypeEnum : pb::IMessage<AssetTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AssetTypeEnum> _parser = new pb::MessageParser<AssetTypeEnum>(() => new AssetTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AssetTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Enums.AssetTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetTypeEnum(AssetTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetTypeEnum Clone() {
      return new AssetTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AssetTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AssetTypeEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AssetTypeEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the AssetTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible types of asset.
      /// </summary>
      public enum AssetType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// YouTube video asset.
        /// </summary>
        [pbr::OriginalName("YOUTUBE_VIDEO")] YoutubeVideo = 2,
        /// <summary>
        /// Media bundle asset.
        /// </summary>
        [pbr::OriginalName("MEDIA_BUNDLE")] MediaBundle = 3,
        /// <summary>
        /// Image asset.
        /// </summary>
        [pbr::OriginalName("IMAGE")] Image = 4,
        /// <summary>
        /// Text asset.
        /// </summary>
        [pbr::OriginalName("TEXT")] Text = 5,
        /// <summary>
        /// Lead form asset.
        /// </summary>
        [pbr::OriginalName("LEAD_FORM")] LeadForm = 6,
        /// <summary>
        /// Book on Google asset.
        /// </summary>
        [pbr::OriginalName("BOOK_ON_GOOGLE")] BookOnGoogle = 7,
        /// <summary>
        /// Promotion asset.
        /// </summary>
        [pbr::OriginalName("PROMOTION")] Promotion = 8,
        /// <summary>
        /// Callout asset.
        /// </summary>
        [pbr::OriginalName("CALLOUT")] Callout = 9,
        /// <summary>
        /// Structured Snippet asset.
        /// </summary>
        [pbr::OriginalName("STRUCTURED_SNIPPET")] StructuredSnippet = 10,
        /// <summary>
        /// Sitelink asset.
        /// </summary>
        [pbr::OriginalName("SITELINK")] Sitelink = 11,
        /// <summary>
        /// Page Feed asset.
        /// </summary>
        [pbr::OriginalName("PAGE_FEED")] PageFeed = 12,
        /// <summary>
        /// Dynamic Education asset.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_EDUCATION")] DynamicEducation = 13,
        /// <summary>
        /// Mobile app asset.
        /// </summary>
        [pbr::OriginalName("MOBILE_APP")] MobileApp = 14,
        /// <summary>
        /// Hotel callout asset.
        /// </summary>
        [pbr::OriginalName("HOTEL_CALLOUT")] HotelCallout = 15,
        /// <summary>
        /// Call asset.
        /// </summary>
        [pbr::OriginalName("CALL")] Call = 16,
        /// <summary>
        /// Price asset.
        /// </summary>
        [pbr::OriginalName("PRICE")] Price = 17,
        /// <summary>
        /// Call to action asset.
        /// </summary>
        [pbr::OriginalName("CALL_TO_ACTION")] CallToAction = 18,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code