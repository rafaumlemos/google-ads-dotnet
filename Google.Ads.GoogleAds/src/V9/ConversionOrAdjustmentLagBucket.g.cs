// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/enums/conversion_or_adjustment_lag_bucket.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/enums/conversion_or_adjustment_lag_bucket.proto</summary>
  public static partial class ConversionOrAdjustmentLagBucketReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/enums/conversion_or_adjustment_lag_bucket.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConversionOrAdjustmentLagBucketReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckdnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9lbnVtcy9jb252ZXJzaW9uX29y",
            "X2FkanVzdG1lbnRfbGFnX2J1Y2tldC5wcm90bxIdZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjkuZW51bXMiywwKI0NvbnZlcnNpb25PckFkanVzdG1lbnRMYWdC",
            "dWNrZXRFbnVtIqMMCh9Db252ZXJzaW9uT3JBZGp1c3RtZW50TGFnQnVja2V0",
            "Eg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEiAKHENPTlZFUlNJT05f",
            "TEVTU19USEFOX09ORV9EQVkQAhIeChpDT05WRVJTSU9OX09ORV9UT19UV09f",
            "REFZUxADEiAKHENPTlZFUlNJT05fVFdPX1RPX1RIUkVFX0RBWVMQBBIhCh1D",
            "T05WRVJTSU9OX1RIUkVFX1RPX0ZPVVJfREFZUxAFEiAKHENPTlZFUlNJT05f",
            "Rk9VUl9UT19GSVZFX0RBWVMQBhIfChtDT05WRVJTSU9OX0ZJVkVfVE9fU0lY",
            "X0RBWVMQBxIgChxDT05WRVJTSU9OX1NJWF9UT19TRVZFTl9EQVlTEAgSIgoe",
            "Q09OVkVSU0lPTl9TRVZFTl9UT19FSUdIVF9EQVlTEAkSIQodQ09OVkVSU0lP",
            "Tl9FSUdIVF9UT19OSU5FX0RBWVMQChIfChtDT05WRVJTSU9OX05JTkVfVE9f",
            "VEVOX0RBWVMQCxIhCh1DT05WRVJTSU9OX1RFTl9UT19FTEVWRU5fREFZUxAM",
            "EiQKIENPTlZFUlNJT05fRUxFVkVOX1RPX1RXRUxWRV9EQVlTEA0SJgoiQ09O",
            "VkVSU0lPTl9UV0VMVkVfVE9fVEhJUlRFRU5fREFZUxAOEigKJENPTlZFUlNJ",
            "T05fVEhJUlRFRU5fVE9fRk9VUlRFRU5fREFZUxAPEioKJkNPTlZFUlNJT05f",
            "Rk9VUlRFRU5fVE9fVFdFTlRZX09ORV9EQVlTEBASKAokQ09OVkVSU0lPTl9U",
            "V0VOVFlfT05FX1RPX1RISVJUWV9EQVlTEBESKAokQ09OVkVSU0lPTl9USElS",
            "VFlfVE9fRk9SVFlfRklWRV9EQVlTEBISJwojQ09OVkVSU0lPTl9GT1JUWV9G",
            "SVZFX1RPX1NJWFRZX0RBWVMQExIjCh9DT05WRVJTSU9OX1NJWFRZX1RPX05J",
            "TkVUWV9EQVlTEBQSIAocQURKVVNUTUVOVF9MRVNTX1RIQU5fT05FX0RBWRAV",
            "Eh4KGkFESlVTVE1FTlRfT05FX1RPX1RXT19EQVlTEBYSIAocQURKVVNUTUVO",
            "VF9UV09fVE9fVEhSRUVfREFZUxAXEiEKHUFESlVTVE1FTlRfVEhSRUVfVE9f",
            "Rk9VUl9EQVlTEBgSIAocQURKVVNUTUVOVF9GT1VSX1RPX0ZJVkVfREFZUxAZ",
            "Eh8KG0FESlVTVE1FTlRfRklWRV9UT19TSVhfREFZUxAaEiAKHEFESlVTVE1F",
            "TlRfU0lYX1RPX1NFVkVOX0RBWVMQGxIiCh5BREpVU1RNRU5UX1NFVkVOX1RP",
            "X0VJR0hUX0RBWVMQHBIhCh1BREpVU1RNRU5UX0VJR0hUX1RPX05JTkVfREFZ",
            "UxAdEh8KG0FESlVTVE1FTlRfTklORV9UT19URU5fREFZUxAeEiEKHUFESlVT",
            "VE1FTlRfVEVOX1RPX0VMRVZFTl9EQVlTEB8SJAogQURKVVNUTUVOVF9FTEVW",
            "RU5fVE9fVFdFTFZFX0RBWVMQIBImCiJBREpVU1RNRU5UX1RXRUxWRV9UT19U",
            "SElSVEVFTl9EQVlTECESKAokQURKVVNUTUVOVF9USElSVEVFTl9UT19GT1VS",
            "VEVFTl9EQVlTECISKgomQURKVVNUTUVOVF9GT1VSVEVFTl9UT19UV0VOVFlf",
            "T05FX0RBWVMQIxIoCiRBREpVU1RNRU5UX1RXRU5UWV9PTkVfVE9fVEhJUlRZ",
            "X0RBWVMQJBIoCiRBREpVU1RNRU5UX1RISVJUWV9UT19GT1JUWV9GSVZFX0RB",
            "WVMQJRInCiNBREpVU1RNRU5UX0ZPUlRZX0ZJVkVfVE9fU0lYVFlfREFZUxAm",
            "EiMKH0FESlVTVE1FTlRfU0lYVFlfVE9fTklORVRZX0RBWVMQJxI4CjRBREpV",
            "U1RNRU5UX05JTkVUWV9UT19PTkVfSFVORFJFRF9BTkRfRk9SVFlfRklWRV9E",
            "QVlTECgSFgoSQ09OVkVSU0lPTl9VTktOT1dOECkSFgoSQURKVVNUTUVOVF9V",
            "TktOT1dOECpC+QEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52OS5lbnVt",
            "c0IkQ29udmVyc2lvbk9yQWRqdXN0bWVudExhZ0J1Y2tldFByb3RvUAFaQmdv",
            "b2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2ds",
            "ZWFkcy92OS9lbnVtcztlbnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMuR29vZ2xl",
            "QWRzLlY5LkVudW1zygIdR29vZ2xlXEFkc1xHb29nbGVBZHNcVjlcRW51bXPq",
            "AiFHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWOTo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Enums.ConversionOrAdjustmentLagBucketEnum), global::Google.Ads.GoogleAds.V9.Enums.ConversionOrAdjustmentLagBucketEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V9.Enums.ConversionOrAdjustmentLagBucketEnum.Types.ConversionOrAdjustmentLagBucket) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum representing the number of days between the impression and
  /// the conversion or between the impression and adjustments to the conversion.
  /// </summary>
  public sealed partial class ConversionOrAdjustmentLagBucketEnum : pb::IMessage<ConversionOrAdjustmentLagBucketEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ConversionOrAdjustmentLagBucketEnum> _parser = new pb::MessageParser<ConversionOrAdjustmentLagBucketEnum>(() => new ConversionOrAdjustmentLagBucketEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ConversionOrAdjustmentLagBucketEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Enums.ConversionOrAdjustmentLagBucketReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionOrAdjustmentLagBucketEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionOrAdjustmentLagBucketEnum(ConversionOrAdjustmentLagBucketEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionOrAdjustmentLagBucketEnum Clone() {
      return new ConversionOrAdjustmentLagBucketEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ConversionOrAdjustmentLagBucketEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ConversionOrAdjustmentLagBucketEnum other) {
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
    public void MergeFrom(ConversionOrAdjustmentLagBucketEnum other) {
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
    /// <summary>Container for nested types declared in the ConversionOrAdjustmentLagBucketEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum representing the number of days between the impression and the
      /// conversion or between the impression and adjustments to the conversion.
      /// </summary>
      public enum ConversionOrAdjustmentLagBucket {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Conversion lag bucket from 0 to 1 day. 0 day is included, 1 day is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_LESS_THAN_ONE_DAY")] ConversionLessThanOneDay = 2,
        /// <summary>
        /// Conversion lag bucket from 1 to 2 days. 1 day is included, 2 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_ONE_TO_TWO_DAYS")] ConversionOneToTwoDays = 3,
        /// <summary>
        /// Conversion lag bucket from 2 to 3 days. 2 days is included,
        /// 3 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_TWO_TO_THREE_DAYS")] ConversionTwoToThreeDays = 4,
        /// <summary>
        /// Conversion lag bucket from 3 to 4 days. 3 days is included,
        /// 4 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_THREE_TO_FOUR_DAYS")] ConversionThreeToFourDays = 5,
        /// <summary>
        /// Conversion lag bucket from 4 to 5 days. 4 days is included,
        /// 5 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_FOUR_TO_FIVE_DAYS")] ConversionFourToFiveDays = 6,
        /// <summary>
        /// Conversion lag bucket from 5 to 6 days. 5 days is included,
        /// 6 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_FIVE_TO_SIX_DAYS")] ConversionFiveToSixDays = 7,
        /// <summary>
        /// Conversion lag bucket from 6 to 7 days. 6 days is included,
        /// 7 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_SIX_TO_SEVEN_DAYS")] ConversionSixToSevenDays = 8,
        /// <summary>
        /// Conversion lag bucket from 7 to 8 days. 7 days is included,
        /// 8 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_SEVEN_TO_EIGHT_DAYS")] ConversionSevenToEightDays = 9,
        /// <summary>
        /// Conversion lag bucket from 8 to 9 days. 8 days is included,
        /// 9 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_EIGHT_TO_NINE_DAYS")] ConversionEightToNineDays = 10,
        /// <summary>
        /// Conversion lag bucket from 9 to 10 days. 9 days is included,
        /// 10 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_NINE_TO_TEN_DAYS")] ConversionNineToTenDays = 11,
        /// <summary>
        /// Conversion lag bucket from 10 to 11 days. 10 days is included,
        /// 11 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_TEN_TO_ELEVEN_DAYS")] ConversionTenToElevenDays = 12,
        /// <summary>
        /// Conversion lag bucket from 11 to 12 days. 11 days is included,
        /// 12 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_ELEVEN_TO_TWELVE_DAYS")] ConversionElevenToTwelveDays = 13,
        /// <summary>
        /// Conversion lag bucket from 12 to 13 days. 12 days is included,
        /// 13 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_TWELVE_TO_THIRTEEN_DAYS")] ConversionTwelveToThirteenDays = 14,
        /// <summary>
        /// Conversion lag bucket from 13 to 14 days. 13 days is included,
        /// 14 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_THIRTEEN_TO_FOURTEEN_DAYS")] ConversionThirteenToFourteenDays = 15,
        /// <summary>
        /// Conversion lag bucket from 14 to 21 days. 14 days is included,
        /// 21 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_FOURTEEN_TO_TWENTY_ONE_DAYS")] ConversionFourteenToTwentyOneDays = 16,
        /// <summary>
        /// Conversion lag bucket from 21 to 30 days. 21 days is included,
        /// 30 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_TWENTY_ONE_TO_THIRTY_DAYS")] ConversionTwentyOneToThirtyDays = 17,
        /// <summary>
        /// Conversion lag bucket from 30 to 45 days. 30 days is included,
        /// 45 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_THIRTY_TO_FORTY_FIVE_DAYS")] ConversionThirtyToFortyFiveDays = 18,
        /// <summary>
        /// Conversion lag bucket from 45 to 60 days. 45 days is included,
        /// 60 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_FORTY_FIVE_TO_SIXTY_DAYS")] ConversionFortyFiveToSixtyDays = 19,
        /// <summary>
        /// Conversion lag bucket from 60 to 90 days. 60 days is included,
        /// 90 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_SIXTY_TO_NINETY_DAYS")] ConversionSixtyToNinetyDays = 20,
        /// <summary>
        /// Conversion adjustment lag bucket from 0 to 1 day. 0 day is included,
        /// 1 day is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_LESS_THAN_ONE_DAY")] AdjustmentLessThanOneDay = 21,
        /// <summary>
        /// Conversion adjustment lag bucket from 1 to 2 days. 1 day is included,
        /// 2 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_ONE_TO_TWO_DAYS")] AdjustmentOneToTwoDays = 22,
        /// <summary>
        /// Conversion adjustment lag bucket from 2 to 3 days. 2 days is included,
        /// 3 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_TWO_TO_THREE_DAYS")] AdjustmentTwoToThreeDays = 23,
        /// <summary>
        /// Conversion adjustment lag bucket from 3 to 4 days. 3 days is included,
        /// 4 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_THREE_TO_FOUR_DAYS")] AdjustmentThreeToFourDays = 24,
        /// <summary>
        /// Conversion adjustment lag bucket from 4 to 5 days. 4 days is included,
        /// 5 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_FOUR_TO_FIVE_DAYS")] AdjustmentFourToFiveDays = 25,
        /// <summary>
        /// Conversion adjustment lag bucket from 5 to 6 days. 5 days is included,
        /// 6 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_FIVE_TO_SIX_DAYS")] AdjustmentFiveToSixDays = 26,
        /// <summary>
        /// Conversion adjustment lag bucket from 6 to 7 days. 6 days is included,
        /// 7 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_SIX_TO_SEVEN_DAYS")] AdjustmentSixToSevenDays = 27,
        /// <summary>
        /// Conversion adjustment lag bucket from 7 to 8 days. 7 days is included,
        /// 8 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_SEVEN_TO_EIGHT_DAYS")] AdjustmentSevenToEightDays = 28,
        /// <summary>
        /// Conversion adjustment lag bucket from 8 to 9 days. 8 days is included,
        /// 9 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_EIGHT_TO_NINE_DAYS")] AdjustmentEightToNineDays = 29,
        /// <summary>
        /// Conversion adjustment lag bucket from 9 to 10 days. 9 days is included,
        /// 10 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_NINE_TO_TEN_DAYS")] AdjustmentNineToTenDays = 30,
        /// <summary>
        /// Conversion adjustment lag bucket from 10 to 11 days. 10 days is included,
        /// 11 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_TEN_TO_ELEVEN_DAYS")] AdjustmentTenToElevenDays = 31,
        /// <summary>
        /// Conversion adjustment lag bucket from 11 to 12 days. 11 days is included,
        /// 12 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_ELEVEN_TO_TWELVE_DAYS")] AdjustmentElevenToTwelveDays = 32,
        /// <summary>
        /// Conversion adjustment lag bucket from 12 to 13 days. 12 days is included,
        /// 13 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_TWELVE_TO_THIRTEEN_DAYS")] AdjustmentTwelveToThirteenDays = 33,
        /// <summary>
        /// Conversion adjustment lag bucket from 13 to 14 days. 13 days is included,
        /// 14 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_THIRTEEN_TO_FOURTEEN_DAYS")] AdjustmentThirteenToFourteenDays = 34,
        /// <summary>
        /// Conversion adjustment lag bucket from 14 to 21 days. 14 days is included,
        /// 21 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_FOURTEEN_TO_TWENTY_ONE_DAYS")] AdjustmentFourteenToTwentyOneDays = 35,
        /// <summary>
        /// Conversion adjustment lag bucket from 21 to 30 days. 21 days is included,
        /// 30 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_TWENTY_ONE_TO_THIRTY_DAYS")] AdjustmentTwentyOneToThirtyDays = 36,
        /// <summary>
        /// Conversion adjustment lag bucket from 30 to 45 days. 30 days is included,
        /// 45 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_THIRTY_TO_FORTY_FIVE_DAYS")] AdjustmentThirtyToFortyFiveDays = 37,
        /// <summary>
        /// Conversion adjustment lag bucket from 45 to 60 days. 45 days is included,
        /// 60 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_FORTY_FIVE_TO_SIXTY_DAYS")] AdjustmentFortyFiveToSixtyDays = 38,
        /// <summary>
        /// Conversion adjustment lag bucket from 60 to 90 days. 60 days is included,
        /// 90 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_SIXTY_TO_NINETY_DAYS")] AdjustmentSixtyToNinetyDays = 39,
        /// <summary>
        /// Conversion adjustment lag bucket from 90 to 145 days. 90 days is
        /// included, 145 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_NINETY_TO_ONE_HUNDRED_AND_FORTY_FIVE_DAYS")] AdjustmentNinetyToOneHundredAndFortyFiveDays = 40,
        /// <summary>
        /// Conversion lag bucket UNKNOWN. This is for dates before conversion lag
        /// bucket was available in Google Ads.
        /// </summary>
        [pbr::OriginalName("CONVERSION_UNKNOWN")] ConversionUnknown = 41,
        /// <summary>
        /// Conversion adjustment lag bucket UNKNOWN. This is for dates before
        /// conversion adjustment lag bucket was available in Google Ads.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_UNKNOWN")] AdjustmentUnknown = 42,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code