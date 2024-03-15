"""
@generated by mypy-protobuf.  Do not edit manually!
isort:skip_file
"""
import builtins
import google.protobuf.descriptor
import google.protobuf.message
import mlagents_envs.communicator_objects.unity_rl_initialization_input_pb2
import mlagents_envs.communicator_objects.unity_rl_input_pb2
import sys

if sys.version_info >= (3, 8):
    import typing as typing_extensions
else:
    import typing_extensions

DESCRIPTOR: google.protobuf.descriptor.FileDescriptor

@typing_extensions.final
class UnityInputProto(google.protobuf.message.Message):
    DESCRIPTOR: google.protobuf.descriptor.Descriptor

    RL_INPUT_FIELD_NUMBER: builtins.int
    RL_INITIALIZATION_INPUT_FIELD_NUMBER: builtins.int
    @property
    def rl_input(self) -> mlagents_envs.communicator_objects.unity_rl_input_pb2.UnityRLInputProto: ...
    @property
    def rl_initialization_input(self) -> mlagents_envs.communicator_objects.unity_rl_initialization_input_pb2.UnityRLInitializationInputProto: ...
    def __init__(
        self,
        *,
        rl_input: mlagents_envs.communicator_objects.unity_rl_input_pb2.UnityRLInputProto | None = ...,
        rl_initialization_input: mlagents_envs.communicator_objects.unity_rl_initialization_input_pb2.UnityRLInitializationInputProto | None = ...,
    ) -> None: ...
    def HasField(self, field_name: typing_extensions.Literal["rl_initialization_input", b"rl_initialization_input", "rl_input", b"rl_input"]) -> builtins.bool: ...
    def ClearField(self, field_name: typing_extensions.Literal["rl_initialization_input", b"rl_initialization_input", "rl_input", b"rl_input"]) -> None: ...

global___UnityInputProto = UnityInputProto
