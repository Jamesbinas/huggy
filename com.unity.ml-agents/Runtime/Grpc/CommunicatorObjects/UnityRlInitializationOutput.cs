// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mlagents_envs/communicator_objects/unity_rl_initialization_output.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Unity.MLAgents.CommunicatorObjects {

  /// <summary>Holder for reflection information generated from mlagents_envs/communicator_objects/unity_rl_initialization_output.proto</summary>
  internal static partial class UnityRlInitializationOutputReflection {

    #region Descriptor
    /// <summary>File descriptor for mlagents_envs/communicator_objects/unity_rl_initialization_output.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UnityRlInitializationOutputReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkdtbGFnZW50c19lbnZzL2NvbW11bmljYXRvcl9vYmplY3RzL3VuaXR5X3Js",
            "X2luaXRpYWxpemF0aW9uX291dHB1dC5wcm90bxIUY29tbXVuaWNhdG9yX29i",
            "amVjdHMaNW1sYWdlbnRzX2VudnMvY29tbXVuaWNhdG9yX29iamVjdHMvY2Fw",
            "YWJpbGl0aWVzLnByb3RvGjltbGFnZW50c19lbnZzL2NvbW11bmljYXRvcl9v",
            "YmplY3RzL2JyYWluX3BhcmFtZXRlcnMucHJvdG8ijAIKIFVuaXR5UkxJbml0",
            "aWFsaXphdGlvbk91dHB1dFByb3RvEgwKBG5hbWUYASABKAkSHQoVY29tbXVu",
            "aWNhdGlvbl92ZXJzaW9uGAIgASgJEhAKCGxvZ19wYXRoGAMgASgJEkQKEGJy",
            "YWluX3BhcmFtZXRlcnMYBSADKAsyKi5jb21tdW5pY2F0b3Jfb2JqZWN0cy5C",
            "cmFpblBhcmFtZXRlcnNQcm90bxIXCg9wYWNrYWdlX3ZlcnNpb24YByABKAkS",
            "RAoMY2FwYWJpbGl0aWVzGAggASgLMi4uY29tbXVuaWNhdG9yX29iamVjdHMu",
            "VW5pdHlSTENhcGFiaWxpdGllc1Byb3RvSgQIBhAHQiWqAiJVbml0eS5NTEFn",
            "ZW50cy5Db21tdW5pY2F0b3JPYmplY3RzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Unity.MLAgents.CommunicatorObjects.CapabilitiesReflection.Descriptor, global::Unity.MLAgents.CommunicatorObjects.BrainParametersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Unity.MLAgents.CommunicatorObjects.UnityRLInitializationOutputProto), global::Unity.MLAgents.CommunicatorObjects.UnityRLInitializationOutputProto.Parser, new[]{ "Name", "CommunicationVersion", "LogPath", "BrainParameters", "PackageVersion", "Capabilities" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The request message containing the academy's parameters.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  internal sealed partial class UnityRLInitializationOutputProto : pb::IMessage<UnityRLInitializationOutputProto>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UnityRLInitializationOutputProto> _parser = new pb::MessageParser<UnityRLInitializationOutputProto>(() => new UnityRLInitializationOutputProto());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UnityRLInitializationOutputProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Unity.MLAgents.CommunicatorObjects.UnityRlInitializationOutputReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UnityRLInitializationOutputProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UnityRLInitializationOutputProto(UnityRLInitializationOutputProto other) : this() {
      name_ = other.name_;
      communicationVersion_ = other.communicationVersion_;
      logPath_ = other.logPath_;
      brainParameters_ = other.brainParameters_.Clone();
      packageVersion_ = other.packageVersion_;
      capabilities_ = other.capabilities_ != null ? other.capabilities_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UnityRLInitializationOutputProto Clone() {
      return new UnityRLInitializationOutputProto(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "communication_version" field.</summary>
    public const int CommunicationVersionFieldNumber = 2;
    private string communicationVersion_ = "";
    /// <summary>
    /// Communication protocol version that the responding side (typically the C# environment) is using.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CommunicationVersion {
      get { return communicationVersion_; }
      set {
        communicationVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "log_path" field.</summary>
    public const int LogPathFieldNumber = 3;
    private string logPath_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LogPath {
      get { return logPath_; }
      set {
        logPath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "brain_parameters" field.</summary>
    public const int BrainParametersFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Unity.MLAgents.CommunicatorObjects.BrainParametersProto> _repeated_brainParameters_codec
        = pb::FieldCodec.ForMessage(42, global::Unity.MLAgents.CommunicatorObjects.BrainParametersProto.Parser);
    private readonly pbc::RepeatedField<global::Unity.MLAgents.CommunicatorObjects.BrainParametersProto> brainParameters_ = new pbc::RepeatedField<global::Unity.MLAgents.CommunicatorObjects.BrainParametersProto>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Unity.MLAgents.CommunicatorObjects.BrainParametersProto> BrainParameters {
      get { return brainParameters_; }
    }

    /// <summary>Field number for the "package_version" field.</summary>
    public const int PackageVersionFieldNumber = 7;
    private string packageVersion_ = "";
    /// <summary>
    /// Package/library version that the responding side (typically the C# environment) is using.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PackageVersion {
      get { return packageVersion_; }
      set {
        packageVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "capabilities" field.</summary>
    public const int CapabilitiesFieldNumber = 8;
    private global::Unity.MLAgents.CommunicatorObjects.UnityRLCapabilitiesProto capabilities_;
    /// <summary>
    /// The RL Capabilities of the C# package.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Unity.MLAgents.CommunicatorObjects.UnityRLCapabilitiesProto Capabilities {
      get { return capabilities_; }
      set {
        capabilities_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UnityRLInitializationOutputProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UnityRLInitializationOutputProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (CommunicationVersion != other.CommunicationVersion) return false;
      if (LogPath != other.LogPath) return false;
      if(!brainParameters_.Equals(other.brainParameters_)) return false;
      if (PackageVersion != other.PackageVersion) return false;
      if (!object.Equals(Capabilities, other.Capabilities)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (CommunicationVersion.Length != 0) hash ^= CommunicationVersion.GetHashCode();
      if (LogPath.Length != 0) hash ^= LogPath.GetHashCode();
      hash ^= brainParameters_.GetHashCode();
      if (PackageVersion.Length != 0) hash ^= PackageVersion.GetHashCode();
      if (capabilities_ != null) hash ^= Capabilities.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (CommunicationVersion.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CommunicationVersion);
      }
      if (LogPath.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(LogPath);
      }
      brainParameters_.WriteTo(output, _repeated_brainParameters_codec);
      if (PackageVersion.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(PackageVersion);
      }
      if (capabilities_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Capabilities);
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (CommunicationVersion.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CommunicationVersion);
      }
      if (LogPath.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(LogPath);
      }
      brainParameters_.WriteTo(ref output, _repeated_brainParameters_codec);
      if (PackageVersion.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(PackageVersion);
      }
      if (capabilities_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Capabilities);
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
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (CommunicationVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CommunicationVersion);
      }
      if (LogPath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LogPath);
      }
      size += brainParameters_.CalculateSize(_repeated_brainParameters_codec);
      if (PackageVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PackageVersion);
      }
      if (capabilities_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Capabilities);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UnityRLInitializationOutputProto other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.CommunicationVersion.Length != 0) {
        CommunicationVersion = other.CommunicationVersion;
      }
      if (other.LogPath.Length != 0) {
        LogPath = other.LogPath;
      }
      brainParameters_.Add(other.brainParameters_);
      if (other.PackageVersion.Length != 0) {
        PackageVersion = other.PackageVersion;
      }
      if (other.capabilities_ != null) {
        if (capabilities_ == null) {
          Capabilities = new global::Unity.MLAgents.CommunicatorObjects.UnityRLCapabilitiesProto();
        }
        Capabilities.MergeFrom(other.Capabilities);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            CommunicationVersion = input.ReadString();
            break;
          }
          case 26: {
            LogPath = input.ReadString();
            break;
          }
          case 42: {
            brainParameters_.AddEntriesFrom(input, _repeated_brainParameters_codec);
            break;
          }
          case 58: {
            PackageVersion = input.ReadString();
            break;
          }
          case 66: {
            if (capabilities_ == null) {
              Capabilities = new global::Unity.MLAgents.CommunicatorObjects.UnityRLCapabilitiesProto();
            }
            input.ReadMessage(Capabilities);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            CommunicationVersion = input.ReadString();
            break;
          }
          case 26: {
            LogPath = input.ReadString();
            break;
          }
          case 42: {
            brainParameters_.AddEntriesFrom(ref input, _repeated_brainParameters_codec);
            break;
          }
          case 58: {
            PackageVersion = input.ReadString();
            break;
          }
          case 66: {
            if (capabilities_ == null) {
              Capabilities = new global::Unity.MLAgents.CommunicatorObjects.UnityRLCapabilitiesProto();
            }
            input.ReadMessage(Capabilities);
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
