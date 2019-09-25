# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: mlagents/envs/communicator_objects/unity_rl_initialization_output.proto

import sys
_b=sys.version_info[0]<3 and (lambda x:x) or (lambda x:x.encode('latin1'))
from google.protobuf import descriptor as _descriptor
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database
from google.protobuf import descriptor_pb2
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


from mlagents.envs.communicator_objects import brain_parameters_proto_pb2 as mlagents_dot_envs_dot_communicator__objects_dot_brain__parameters__proto__pb2
from mlagents.envs.communicator_objects import environment_parameters_proto_pb2 as mlagents_dot_envs_dot_communicator__objects_dot_environment__parameters__proto__pb2


DESCRIPTOR = _descriptor.FileDescriptor(
  name='mlagents/envs/communicator_objects/unity_rl_initialization_output.proto',
  package='communicator_objects',
  syntax='proto3',
  serialized_pb=_b('\nGmlagents/envs/communicator_objects/unity_rl_initialization_output.proto\x12\x14\x63ommunicator_objects\x1a?mlagents/envs/communicator_objects/brain_parameters_proto.proto\x1a\x45mlagents/envs/communicator_objects/environment_parameters_proto.proto\"\xe6\x01\n\x1bUnityRLInitializationOutput\x12\x0c\n\x04name\x18\x01 \x01(\t\x12\x0f\n\x07version\x18\x02 \x01(\t\x12\x10\n\x08log_path\x18\x03 \x01(\t\x12\x44\n\x10\x62rain_parameters\x18\x05 \x03(\x0b\x32*.communicator_objects.BrainParametersProto\x12P\n\x16\x65nvironment_parameters\x18\x06 \x01(\x0b\x32\x30.communicator_objects.EnvironmentParametersProtoB\x1f\xaa\x02\x1cMLAgents.CommunicatorObjectsb\x06proto3')
  ,
  dependencies=[mlagents_dot_envs_dot_communicator__objects_dot_brain__parameters__proto__pb2.DESCRIPTOR,mlagents_dot_envs_dot_communicator__objects_dot_environment__parameters__proto__pb2.DESCRIPTOR,])




_UNITYRLINITIALIZATIONOUTPUT = _descriptor.Descriptor(
  name='UnityRLInitializationOutput',
  full_name='communicator_objects.UnityRLInitializationOutput',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='name', full_name='communicator_objects.UnityRLInitializationOutput.name', index=0,
      number=1, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='version', full_name='communicator_objects.UnityRLInitializationOutput.version', index=1,
      number=2, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='log_path', full_name='communicator_objects.UnityRLInitializationOutput.log_path', index=2,
      number=3, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='brain_parameters', full_name='communicator_objects.UnityRLInitializationOutput.brain_parameters', index=3,
      number=5, type=11, cpp_type=10, label=3,
      has_default_value=False, default_value=[],
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='environment_parameters', full_name='communicator_objects.UnityRLInitializationOutput.environment_parameters', index=4,
      number=6, type=11, cpp_type=10, label=1,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=234,
  serialized_end=464,
)

_UNITYRLINITIALIZATIONOUTPUT.fields_by_name['brain_parameters'].message_type = mlagents_dot_envs_dot_communicator__objects_dot_brain__parameters__proto__pb2._BRAINPARAMETERSPROTO
_UNITYRLINITIALIZATIONOUTPUT.fields_by_name['environment_parameters'].message_type = mlagents_dot_envs_dot_communicator__objects_dot_environment__parameters__proto__pb2._ENVIRONMENTPARAMETERSPROTO
DESCRIPTOR.message_types_by_name['UnityRLInitializationOutput'] = _UNITYRLINITIALIZATIONOUTPUT
_sym_db.RegisterFileDescriptor(DESCRIPTOR)

UnityRLInitializationOutput = _reflection.GeneratedProtocolMessageType('UnityRLInitializationOutput', (_message.Message,), dict(
  DESCRIPTOR = _UNITYRLINITIALIZATIONOUTPUT,
  __module__ = 'mlagents.envs.communicator_objects.unity_rl_initialization_output_pb2'
  # @@protoc_insertion_point(class_scope:communicator_objects.UnityRLInitializationOutput)
  ))
_sym_db.RegisterMessage(UnityRLInitializationOutput)


DESCRIPTOR.has_options = True
DESCRIPTOR._options = _descriptor._ParseOptions(descriptor_pb2.FileOptions(), _b('\252\002\034MLAgents.CommunicatorObjects'))
# @@protoc_insertion_point(module_scope)
