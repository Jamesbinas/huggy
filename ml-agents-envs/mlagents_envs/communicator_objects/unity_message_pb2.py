# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: mlagents_envs/communicator_objects/unity_message.proto
# Protobuf Python Version: 4.25.1
"""Generated protocol buffer code."""
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
from google.protobuf.internal import builder as _builder
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


from mlagents_envs.communicator_objects import unity_output_pb2 as mlagents__envs_dot_communicator__objects_dot_unity__output__pb2
from mlagents_envs.communicator_objects import unity_input_pb2 as mlagents__envs_dot_communicator__objects_dot_unity__input__pb2
from mlagents_envs.communicator_objects import header_pb2 as mlagents__envs_dot_communicator__objects_dot_header__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n6mlagents_envs/communicator_objects/unity_message.proto\x12\x14\x63ommunicator_objects\x1a\x35mlagents_envs/communicator_objects/unity_output.proto\x1a\x34mlagents_envs/communicator_objects/unity_input.proto\x1a/mlagents_envs/communicator_objects/header.proto\"\xc0\x01\n\x11UnityMessageProto\x12\x31\n\x06header\x18\x01 \x01(\x0b\x32!.communicator_objects.HeaderProto\x12<\n\x0cunity_output\x18\x02 \x01(\x0b\x32&.communicator_objects.UnityOutputProto\x12:\n\x0bunity_input\x18\x03 \x01(\x0b\x32%.communicator_objects.UnityInputProtoB%\xaa\x02\"Unity.MLAgents.CommunicatorObjectsb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'mlagents_envs.communicator_objects.unity_message_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:
  _globals['DESCRIPTOR']._options = None
  _globals['DESCRIPTOR']._serialized_options = b'\252\002\"Unity.MLAgents.CommunicatorObjects'
  _globals['_UNITYMESSAGEPROTO']._serialized_start=239
  _globals['_UNITYMESSAGEPROTO']._serialized_end=431
# @@protoc_insertion_point(module_scope)
