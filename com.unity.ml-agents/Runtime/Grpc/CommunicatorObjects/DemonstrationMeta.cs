// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mlagents_envs/communicator_objects/demonstration_meta.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Unity.MLAgents.CommunicatorObjects {

  /// <summary>Holder for reflection information generated from mlagents_envs/communicator_objects/demonstration_meta.proto</summary>
  internal static partial class DemonstrationMetaReflection {

    #region Descriptor
    /// <summary>File descriptor for mlagents_envs/communicator_objects/demonstration_meta.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DemonstrationMetaReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjttbGFnZW50c19lbnZzL2NvbW11bmljYXRvcl9vYmplY3RzL2RlbW9uc3Ry",
            "YXRpb25fbWV0YS5wcm90bxIUY29tbXVuaWNhdG9yX29iamVjdHMijQEKFkRl",
            "bW9uc3RyYXRpb25NZXRhUHJvdG8SEwoLYXBpX3ZlcnNpb24YASABKAUSGgoS",
            "ZGVtb25zdHJhdGlvbl9uYW1lGAIgASgJEhQKDG51bWJlcl9zdGVwcxgDIAEo",
            "BRIXCg9udW1iZXJfZXBpc29kZXMYBCABKAUSEwoLbWVhbl9yZXdhcmQYBSAB",
            "KAJCJaoCIlVuaXR5Lk1MQWdlbnRzLkNvbW11bmljYXRvck9iamVjdHNiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Unity.MLAgents.CommunicatorObjects.DemonstrationMetaProto), global::Unity.MLAgents.CommunicatorObjects.DemonstrationMetaProto.Parser, new[]{ "ApiVersion", "DemonstrationName", "NumberSteps", "NumberEpisodes", "MeanReward" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  internal sealed partial class DemonstrationMetaProto : pb::IMessage<DemonstrationMetaProto>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DemonstrationMetaProto> _parser = new pb::MessageParser<DemonstrationMetaProto>(() => new DemonstrationMetaProto());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DemonstrationMetaProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Unity.MLAgents.CommunicatorObjects.DemonstrationMetaReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DemonstrationMetaProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DemonstrationMetaProto(DemonstrationMetaProto other) : this() {
      apiVersion_ = other.apiVersion_;
      demonstrationName_ = other.demonstrationName_;
      numberSteps_ = other.numberSteps_;
      numberEpisodes_ = other.numberEpisodes_;
      meanReward_ = other.meanReward_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DemonstrationMetaProto Clone() {
      return new DemonstrationMetaProto(this);
    }

    /// <summary>Field number for the "api_version" field.</summary>
    public const int ApiVersionFieldNumber = 1;
    private int apiVersion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ApiVersion {
      get { return apiVersion_; }
      set {
        apiVersion_ = value;
      }
    }

    /// <summary>Field number for the "demonstration_name" field.</summary>
    public const int DemonstrationNameFieldNumber = 2;
    private string demonstrationName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DemonstrationName {
      get { return demonstrationName_; }
      set {
        demonstrationName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "number_steps" field.</summary>
    public const int NumberStepsFieldNumber = 3;
    private int numberSteps_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int NumberSteps {
      get { return numberSteps_; }
      set {
        numberSteps_ = value;
      }
    }

    /// <summary>Field number for the "number_episodes" field.</summary>
    public const int NumberEpisodesFieldNumber = 4;
    private int numberEpisodes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int NumberEpisodes {
      get { return numberEpisodes_; }
      set {
        numberEpisodes_ = value;
      }
    }

    /// <summary>Field number for the "mean_reward" field.</summary>
    public const int MeanRewardFieldNumber = 5;
    private float meanReward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float MeanReward {
      get { return meanReward_; }
      set {
        meanReward_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DemonstrationMetaProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DemonstrationMetaProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ApiVersion != other.ApiVersion) return false;
      if (DemonstrationName != other.DemonstrationName) return false;
      if (NumberSteps != other.NumberSteps) return false;
      if (NumberEpisodes != other.NumberEpisodes) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MeanReward, other.MeanReward)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ApiVersion != 0) hash ^= ApiVersion.GetHashCode();
      if (DemonstrationName.Length != 0) hash ^= DemonstrationName.GetHashCode();
      if (NumberSteps != 0) hash ^= NumberSteps.GetHashCode();
      if (NumberEpisodes != 0) hash ^= NumberEpisodes.GetHashCode();
      if (MeanReward != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MeanReward);
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
      if (ApiVersion != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ApiVersion);
      }
      if (DemonstrationName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DemonstrationName);
      }
      if (NumberSteps != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(NumberSteps);
      }
      if (NumberEpisodes != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(NumberEpisodes);
      }
      if (MeanReward != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(MeanReward);
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
      if (ApiVersion != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ApiVersion);
      }
      if (DemonstrationName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DemonstrationName);
      }
      if (NumberSteps != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(NumberSteps);
      }
      if (NumberEpisodes != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(NumberEpisodes);
      }
      if (MeanReward != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(MeanReward);
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
      if (ApiVersion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ApiVersion);
      }
      if (DemonstrationName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DemonstrationName);
      }
      if (NumberSteps != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NumberSteps);
      }
      if (NumberEpisodes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NumberEpisodes);
      }
      if (MeanReward != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DemonstrationMetaProto other) {
      if (other == null) {
        return;
      }
      if (other.ApiVersion != 0) {
        ApiVersion = other.ApiVersion;
      }
      if (other.DemonstrationName.Length != 0) {
        DemonstrationName = other.DemonstrationName;
      }
      if (other.NumberSteps != 0) {
        NumberSteps = other.NumberSteps;
      }
      if (other.NumberEpisodes != 0) {
        NumberEpisodes = other.NumberEpisodes;
      }
      if (other.MeanReward != 0F) {
        MeanReward = other.MeanReward;
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
          case 8: {
            ApiVersion = input.ReadInt32();
            break;
          }
          case 18: {
            DemonstrationName = input.ReadString();
            break;
          }
          case 24: {
            NumberSteps = input.ReadInt32();
            break;
          }
          case 32: {
            NumberEpisodes = input.ReadInt32();
            break;
          }
          case 45: {
            MeanReward = input.ReadFloat();
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
          case 8: {
            ApiVersion = input.ReadInt32();
            break;
          }
          case 18: {
            DemonstrationName = input.ReadString();
            break;
          }
          case 24: {
            NumberSteps = input.ReadInt32();
            break;
          }
          case 32: {
            NumberEpisodes = input.ReadInt32();
            break;
          }
          case 45: {
            MeanReward = input.ReadFloat();
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
