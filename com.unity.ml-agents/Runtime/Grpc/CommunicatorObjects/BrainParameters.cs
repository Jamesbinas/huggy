// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mlagents_envs/communicator_objects/brain_parameters.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Unity.MLAgents.CommunicatorObjects {

  /// <summary>Holder for reflection information generated from mlagents_envs/communicator_objects/brain_parameters.proto</summary>
  internal static partial class BrainParametersReflection {

    #region Descriptor
    /// <summary>File descriptor for mlagents_envs/communicator_objects/brain_parameters.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BrainParametersReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjltbGFnZW50c19lbnZzL2NvbW11bmljYXRvcl9vYmplY3RzL2JyYWluX3Bh",
            "cmFtZXRlcnMucHJvdG8SFGNvbW11bmljYXRvcl9vYmplY3RzGjNtbGFnZW50",
            "c19lbnZzL2NvbW11bmljYXRvcl9vYmplY3RzL3NwYWNlX3R5cGUucHJvdG8i",
            "iwEKD0FjdGlvblNwZWNQcm90bxIeChZudW1fY29udGludW91c19hY3Rpb25z",
            "GAEgASgFEhwKFG51bV9kaXNjcmV0ZV9hY3Rpb25zGAIgASgFEh0KFWRpc2Ny",
            "ZXRlX2JyYW5jaF9zaXplcxgDIAMoBRIbChNhY3Rpb25fZGVzY3JpcHRpb25z",
            "GAQgAygJIpUCChRCcmFpblBhcmFtZXRlcnNQcm90bxIaChJ2ZWN0b3JfYWN0",
            "aW9uX3NpemUYAyADKAUSIgoadmVjdG9yX2FjdGlvbl9kZXNjcmlwdGlvbnMY",
            "BSADKAkSRgoYdmVjdG9yX2FjdGlvbl9zcGFjZV90eXBlGAYgASgOMiQuY29t",
            "bXVuaWNhdG9yX29iamVjdHMuU3BhY2VUeXBlUHJvdG8SEgoKYnJhaW5fbmFt",
            "ZRgHIAEoCRITCgtpc190cmFpbmluZxgIIAEoCBI6CgthY3Rpb25fc3BlYxgJ",
            "IAEoCzIlLmNvbW11bmljYXRvcl9vYmplY3RzLkFjdGlvblNwZWNQcm90b0oE",
            "CAEQAkoECAIQA0oECAQQBUIlqgIiVW5pdHkuTUxBZ2VudHMuQ29tbXVuaWNh",
            "dG9yT2JqZWN0c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Unity.MLAgents.CommunicatorObjects.SpaceTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Unity.MLAgents.CommunicatorObjects.ActionSpecProto), global::Unity.MLAgents.CommunicatorObjects.ActionSpecProto.Parser, new[]{ "NumContinuousActions", "NumDiscreteActions", "DiscreteBranchSizes", "ActionDescriptions" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Unity.MLAgents.CommunicatorObjects.BrainParametersProto), global::Unity.MLAgents.CommunicatorObjects.BrainParametersProto.Parser, new[]{ "VectorActionSize", "VectorActionDescriptions", "VectorActionSpaceType", "BrainName", "IsTraining", "ActionSpec" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class ActionSpecProto : pb::IMessage<ActionSpecProto> {
    private static readonly pb::MessageParser<ActionSpecProto> _parser = new pb::MessageParser<ActionSpecProto>(() => new ActionSpecProto());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ActionSpecProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Unity.MLAgents.CommunicatorObjects.BrainParametersReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ActionSpecProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ActionSpecProto(ActionSpecProto other) : this() {
      numContinuousActions_ = other.numContinuousActions_;
      numDiscreteActions_ = other.numDiscreteActions_;
      discreteBranchSizes_ = other.discreteBranchSizes_.Clone();
      actionDescriptions_ = other.actionDescriptions_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ActionSpecProto Clone() {
      return new ActionSpecProto(this);
    }

    /// <summary>Field number for the "num_continuous_actions" field.</summary>
    public const int NumContinuousActionsFieldNumber = 1;
    private int numContinuousActions_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NumContinuousActions {
      get { return numContinuousActions_; }
      set {
        numContinuousActions_ = value;
      }
    }

    /// <summary>Field number for the "num_discrete_actions" field.</summary>
    public const int NumDiscreteActionsFieldNumber = 2;
    private int numDiscreteActions_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NumDiscreteActions {
      get { return numDiscreteActions_; }
      set {
        numDiscreteActions_ = value;
      }
    }

    /// <summary>Field number for the "discrete_branch_sizes" field.</summary>
    public const int DiscreteBranchSizesFieldNumber = 3;
    private static readonly pb::FieldCodec<int> _repeated_discreteBranchSizes_codec
        = pb::FieldCodec.ForInt32(26);
    private readonly pbc::RepeatedField<int> discreteBranchSizes_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> DiscreteBranchSizes {
      get { return discreteBranchSizes_; }
    }

    /// <summary>Field number for the "action_descriptions" field.</summary>
    public const int ActionDescriptionsFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _repeated_actionDescriptions_codec
        = pb::FieldCodec.ForString(34);
    private readonly pbc::RepeatedField<string> actionDescriptions_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> ActionDescriptions {
      get { return actionDescriptions_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ActionSpecProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ActionSpecProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NumContinuousActions != other.NumContinuousActions) return false;
      if (NumDiscreteActions != other.NumDiscreteActions) return false;
      if(!discreteBranchSizes_.Equals(other.discreteBranchSizes_)) return false;
      if(!actionDescriptions_.Equals(other.actionDescriptions_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (NumContinuousActions != 0) hash ^= NumContinuousActions.GetHashCode();
      if (NumDiscreteActions != 0) hash ^= NumDiscreteActions.GetHashCode();
      hash ^= discreteBranchSizes_.GetHashCode();
      hash ^= actionDescriptions_.GetHashCode();
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
      if (NumContinuousActions != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(NumContinuousActions);
      }
      if (NumDiscreteActions != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(NumDiscreteActions);
      }
      discreteBranchSizes_.WriteTo(output, _repeated_discreteBranchSizes_codec);
      actionDescriptions_.WriteTo(output, _repeated_actionDescriptions_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (NumContinuousActions != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NumContinuousActions);
      }
      if (NumDiscreteActions != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NumDiscreteActions);
      }
      size += discreteBranchSizes_.CalculateSize(_repeated_discreteBranchSizes_codec);
      size += actionDescriptions_.CalculateSize(_repeated_actionDescriptions_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ActionSpecProto other) {
      if (other == null) {
        return;
      }
      if (other.NumContinuousActions != 0) {
        NumContinuousActions = other.NumContinuousActions;
      }
      if (other.NumDiscreteActions != 0) {
        NumDiscreteActions = other.NumDiscreteActions;
      }
      discreteBranchSizes_.Add(other.discreteBranchSizes_);
      actionDescriptions_.Add(other.actionDescriptions_);
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
          case 8: {
            NumContinuousActions = input.ReadInt32();
            break;
          }
          case 16: {
            NumDiscreteActions = input.ReadInt32();
            break;
          }
          case 26:
          case 24: {
            discreteBranchSizes_.AddEntriesFrom(input, _repeated_discreteBranchSizes_codec);
            break;
          }
          case 34: {
            actionDescriptions_.AddEntriesFrom(input, _repeated_actionDescriptions_codec);
            break;
          }
        }
      }
    }

  }

  internal sealed partial class BrainParametersProto : pb::IMessage<BrainParametersProto> {
    private static readonly pb::MessageParser<BrainParametersProto> _parser = new pb::MessageParser<BrainParametersProto>(() => new BrainParametersProto());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BrainParametersProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Unity.MLAgents.CommunicatorObjects.BrainParametersReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BrainParametersProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BrainParametersProto(BrainParametersProto other) : this() {
      vectorActionSize_ = other.vectorActionSize_.Clone();
      vectorActionDescriptions_ = other.vectorActionDescriptions_.Clone();
      vectorActionSpaceType_ = other.vectorActionSpaceType_;
      brainName_ = other.brainName_;
      isTraining_ = other.isTraining_;
      ActionSpec = other.actionSpec_ != null ? other.ActionSpec.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BrainParametersProto Clone() {
      return new BrainParametersProto(this);
    }

    /// <summary>Field number for the "vector_action_size" field.</summary>
    public const int VectorActionSizeFieldNumber = 3;
    private static readonly pb::FieldCodec<int> _repeated_vectorActionSize_codec
        = pb::FieldCodec.ForInt32(26);
    private readonly pbc::RepeatedField<int> vectorActionSize_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> VectorActionSize {
      get { return vectorActionSize_; }
    }

    /// <summary>Field number for the "vector_action_descriptions" field.</summary>
    public const int VectorActionDescriptionsFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_vectorActionDescriptions_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> vectorActionDescriptions_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> VectorActionDescriptions {
      get { return vectorActionDescriptions_; }
    }

    /// <summary>Field number for the "vector_action_space_type" field.</summary>
    public const int VectorActionSpaceTypeFieldNumber = 6;
    private global::Unity.MLAgents.CommunicatorObjects.SpaceTypeProto vectorActionSpaceType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Unity.MLAgents.CommunicatorObjects.SpaceTypeProto VectorActionSpaceType {
      get { return vectorActionSpaceType_; }
      set {
        vectorActionSpaceType_ = value;
      }
    }

    /// <summary>Field number for the "brain_name" field.</summary>
    public const int BrainNameFieldNumber = 7;
    private string brainName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BrainName {
      get { return brainName_; }
      set {
        brainName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "is_training" field.</summary>
    public const int IsTrainingFieldNumber = 8;
    private bool isTraining_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsTraining {
      get { return isTraining_; }
      set {
        isTraining_ = value;
      }
    }

    /// <summary>Field number for the "action_spec" field.</summary>
    public const int ActionSpecFieldNumber = 9;
    private global::Unity.MLAgents.CommunicatorObjects.ActionSpecProto actionSpec_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Unity.MLAgents.CommunicatorObjects.ActionSpecProto ActionSpec {
      get { return actionSpec_; }
      set {
        actionSpec_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BrainParametersProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BrainParametersProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!vectorActionSize_.Equals(other.vectorActionSize_)) return false;
      if(!vectorActionDescriptions_.Equals(other.vectorActionDescriptions_)) return false;
      if (VectorActionSpaceType != other.VectorActionSpaceType) return false;
      if (BrainName != other.BrainName) return false;
      if (IsTraining != other.IsTraining) return false;
      if (!object.Equals(ActionSpec, other.ActionSpec)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= vectorActionSize_.GetHashCode();
      hash ^= vectorActionDescriptions_.GetHashCode();
      if (VectorActionSpaceType != 0) hash ^= VectorActionSpaceType.GetHashCode();
      if (BrainName.Length != 0) hash ^= BrainName.GetHashCode();
      if (IsTraining != false) hash ^= IsTraining.GetHashCode();
      if (actionSpec_ != null) hash ^= ActionSpec.GetHashCode();
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
      vectorActionSize_.WriteTo(output, _repeated_vectorActionSize_codec);
      vectorActionDescriptions_.WriteTo(output, _repeated_vectorActionDescriptions_codec);
      if (VectorActionSpaceType != 0) {
        output.WriteRawTag(48);
        output.WriteEnum((int) VectorActionSpaceType);
      }
      if (BrainName.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(BrainName);
      }
      if (IsTraining != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsTraining);
      }
      if (actionSpec_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(ActionSpec);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += vectorActionSize_.CalculateSize(_repeated_vectorActionSize_codec);
      size += vectorActionDescriptions_.CalculateSize(_repeated_vectorActionDescriptions_codec);
      if (VectorActionSpaceType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) VectorActionSpaceType);
      }
      if (BrainName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BrainName);
      }
      if (IsTraining != false) {
        size += 1 + 1;
      }
      if (actionSpec_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ActionSpec);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BrainParametersProto other) {
      if (other == null) {
        return;
      }
      vectorActionSize_.Add(other.vectorActionSize_);
      vectorActionDescriptions_.Add(other.vectorActionDescriptions_);
      if (other.VectorActionSpaceType != 0) {
        VectorActionSpaceType = other.VectorActionSpaceType;
      }
      if (other.BrainName.Length != 0) {
        BrainName = other.BrainName;
      }
      if (other.IsTraining != false) {
        IsTraining = other.IsTraining;
      }
      if (other.actionSpec_ != null) {
        if (actionSpec_ == null) {
          actionSpec_ = new global::Unity.MLAgents.CommunicatorObjects.ActionSpecProto();
        }
        ActionSpec.MergeFrom(other.ActionSpec);
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
          case 26:
          case 24: {
            vectorActionSize_.AddEntriesFrom(input, _repeated_vectorActionSize_codec);
            break;
          }
          case 42: {
            vectorActionDescriptions_.AddEntriesFrom(input, _repeated_vectorActionDescriptions_codec);
            break;
          }
          case 48: {
            vectorActionSpaceType_ = (global::Unity.MLAgents.CommunicatorObjects.SpaceTypeProto) input.ReadEnum();
            break;
          }
          case 58: {
            BrainName = input.ReadString();
            break;
          }
          case 64: {
            IsTraining = input.ReadBool();
            break;
          }
          case 74: {
            if (actionSpec_ == null) {
              actionSpec_ = new global::Unity.MLAgents.CommunicatorObjects.ActionSpecProto();
            }
            input.ReadMessage(actionSpec_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
