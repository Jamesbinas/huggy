// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mlagents_envs/communicator_objects/unity_output.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Unity.MLAgents.CommunicatorObjects {

  /// <summary>Holder for reflection information generated from mlagents_envs/communicator_objects/unity_output.proto</summary>
  internal static partial class UnityOutputReflection {

    #region Descriptor
    /// <summary>File descriptor for mlagents_envs/communicator_objects/unity_output.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UnityOutputReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVtbGFnZW50c19lbnZzL2NvbW11bmljYXRvcl9vYmplY3RzL3VuaXR5X291",
            "dHB1dC5wcm90bxIUY29tbXVuaWNhdG9yX29iamVjdHMaOG1sYWdlbnRzX2Vu",
            "dnMvY29tbXVuaWNhdG9yX29iamVjdHMvdW5pdHlfcmxfb3V0cHV0LnByb3Rv",
            "GkdtbGFnZW50c19lbnZzL2NvbW11bmljYXRvcl9vYmplY3RzL3VuaXR5X3Js",
            "X2luaXRpYWxpemF0aW9uX291dHB1dC5wcm90byKpAQoQVW5pdHlPdXRwdXRQ",
            "cm90bxI7CglybF9vdXRwdXQYASABKAsyKC5jb21tdW5pY2F0b3Jfb2JqZWN0",
            "cy5Vbml0eVJMT3V0cHV0UHJvdG8SWAoYcmxfaW5pdGlhbGl6YXRpb25fb3V0",
            "cHV0GAIgASgLMjYuY29tbXVuaWNhdG9yX29iamVjdHMuVW5pdHlSTEluaXRp",
            "YWxpemF0aW9uT3V0cHV0UHJvdG9CJaoCIlVuaXR5Lk1MQWdlbnRzLkNvbW11",
            "bmljYXRvck9iamVjdHNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Unity.MLAgents.CommunicatorObjects.UnityRlOutputReflection.Descriptor, global::Unity.MLAgents.CommunicatorObjects.UnityRlInitializationOutputReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Unity.MLAgents.CommunicatorObjects.UnityOutputProto), global::Unity.MLAgents.CommunicatorObjects.UnityOutputProto.Parser, new[]{ "RlOutput", "RlInitializationOutput" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  internal sealed partial class UnityOutputProto : pb::IMessage<UnityOutputProto>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UnityOutputProto> _parser = new pb::MessageParser<UnityOutputProto>(() => new UnityOutputProto());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UnityOutputProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Unity.MLAgents.CommunicatorObjects.UnityOutputReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UnityOutputProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UnityOutputProto(UnityOutputProto other) : this() {
      rlOutput_ = other.rlOutput_ != null ? other.rlOutput_.Clone() : null;
      rlInitializationOutput_ = other.rlInitializationOutput_ != null ? other.rlInitializationOutput_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UnityOutputProto Clone() {
      return new UnityOutputProto(this);
    }

    /// <summary>Field number for the "rl_output" field.</summary>
    public const int RlOutputFieldNumber = 1;
    private global::Unity.MLAgents.CommunicatorObjects.UnityRLOutputProto rlOutput_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Unity.MLAgents.CommunicatorObjects.UnityRLOutputProto RlOutput {
      get { return rlOutput_; }
      set {
        rlOutput_ = value;
      }
    }

    /// <summary>Field number for the "rl_initialization_output" field.</summary>
    public const int RlInitializationOutputFieldNumber = 2;
    private global::Unity.MLAgents.CommunicatorObjects.UnityRLInitializationOutputProto rlInitializationOutput_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Unity.MLAgents.CommunicatorObjects.UnityRLInitializationOutputProto RlInitializationOutput {
      get { return rlInitializationOutput_; }
      set {
        rlInitializationOutput_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UnityOutputProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UnityOutputProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RlOutput, other.RlOutput)) return false;
      if (!object.Equals(RlInitializationOutput, other.RlInitializationOutput)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rlOutput_ != null) hash ^= RlOutput.GetHashCode();
      if (rlInitializationOutput_ != null) hash ^= RlInitializationOutput.GetHashCode();
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
      if (rlOutput_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RlOutput);
      }
      if (rlInitializationOutput_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RlInitializationOutput);
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
      if (rlOutput_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RlOutput);
      }
      if (rlInitializationOutput_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RlInitializationOutput);
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
      if (rlOutput_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RlOutput);
      }
      if (rlInitializationOutput_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RlInitializationOutput);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UnityOutputProto other) {
      if (other == null) {
        return;
      }
      if (other.rlOutput_ != null) {
        if (rlOutput_ == null) {
          RlOutput = new global::Unity.MLAgents.CommunicatorObjects.UnityRLOutputProto();
        }
        RlOutput.MergeFrom(other.RlOutput);
      }
      if (other.rlInitializationOutput_ != null) {
        if (rlInitializationOutput_ == null) {
          RlInitializationOutput = new global::Unity.MLAgents.CommunicatorObjects.UnityRLInitializationOutputProto();
        }
        RlInitializationOutput.MergeFrom(other.RlInitializationOutput);
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
            if (rlOutput_ == null) {
              RlOutput = new global::Unity.MLAgents.CommunicatorObjects.UnityRLOutputProto();
            }
            input.ReadMessage(RlOutput);
            break;
          }
          case 18: {
            if (rlInitializationOutput_ == null) {
              RlInitializationOutput = new global::Unity.MLAgents.CommunicatorObjects.UnityRLInitializationOutputProto();
            }
            input.ReadMessage(RlInitializationOutput);
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
            if (rlOutput_ == null) {
              RlOutput = new global::Unity.MLAgents.CommunicatorObjects.UnityRLOutputProto();
            }
            input.ReadMessage(RlOutput);
            break;
          }
          case 18: {
            if (rlInitializationOutput_ == null) {
              RlInitializationOutput = new global::Unity.MLAgents.CommunicatorObjects.UnityRLInitializationOutputProto();
            }
            input.ReadMessage(RlInitializationOutput);
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
