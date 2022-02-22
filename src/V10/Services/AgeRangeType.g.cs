// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/enums/age_range_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/enums/age_range_type.proto</summary>
  public static partial class AgeRangeTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/enums/age_range_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AgeRangeTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZW51bXMvYWdlX3JhbmdlX3R5",
            "cGUucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMC5lbnVtcxocZ29v",
            "Z2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byLpAQoQQWdlUmFuZ2VUeXBlRW51",
            "bSLUAQoMQWdlUmFuZ2VUeXBlEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9X",
            "ThABEhUKD0FHRV9SQU5HRV8xOF8yNBDZ2R4SFQoPQUdFX1JBTkdFXzI1XzM0",
            "ENrZHhIVCg9BR0VfUkFOR0VfMzVfNDQQ29keEhUKD0FHRV9SQU5HRV80NV81",
            "NBDc2R4SFQoPQUdFX1JBTkdFXzU1XzY0EN3ZHhIVCg9BR0VfUkFOR0VfNjVf",
            "VVAQ3tkeEhwKFkFHRV9SQU5HRV9VTkRFVEVSTUlORUQQv+EeQusBCiJjb20u",
            "Z29vZ2xlLmFkcy5nb29nbGVhZHMudjEwLmVudW1zQhFBZ2VSYW5nZVR5cGVQ",
            "cm90b1ABWkNnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlz",
            "L2Fkcy9nb29nbGVhZHMvdjEwL2VudW1zO2VudW1zogIDR0FBqgIeR29vZ2xl",
            "LkFkcy5Hb29nbGVBZHMuVjEwLkVudW1zygIeR29vZ2xlXEFkc1xHb29nbGVB",
            "ZHNcVjEwXEVudW1z6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjEwOjpF",
            "bnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Enums.AgeRangeTypeEnum), global::Google.Ads.GoogleAds.V10.Enums.AgeRangeTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V10.Enums.AgeRangeTypeEnum.Types.AgeRangeType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing the type of demographic age ranges.
  /// </summary>
  public sealed partial class AgeRangeTypeEnum : pb::IMessage<AgeRangeTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AgeRangeTypeEnum> _parser = new pb::MessageParser<AgeRangeTypeEnum>(() => new AgeRangeTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AgeRangeTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Enums.AgeRangeTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AgeRangeTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AgeRangeTypeEnum(AgeRangeTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AgeRangeTypeEnum Clone() {
      return new AgeRangeTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AgeRangeTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AgeRangeTypeEnum other) {
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
    public void MergeFrom(AgeRangeTypeEnum other) {
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
    /// <summary>Container for nested types declared in the AgeRangeTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The type of demographic age ranges (e.g. between 18 and 24 years old).
      /// </summary>
      public enum AgeRangeType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Between 18 and 24 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_18_24")] AgeRange1824 = 503001,
        /// <summary>
        /// Between 25 and 34 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_25_34")] AgeRange2534 = 503002,
        /// <summary>
        /// Between 35 and 44 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_35_44")] AgeRange3544 = 503003,
        /// <summary>
        /// Between 45 and 54 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_45_54")] AgeRange4554 = 503004,
        /// <summary>
        /// Between 55 and 64 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_55_64")] AgeRange5564 = 503005,
        /// <summary>
        /// 65 years old and beyond.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_65_UP")] AgeRange65Up = 503006,
        /// <summary>
        /// Undetermined age range.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_UNDETERMINED")] AgeRangeUndetermined = 503999,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code