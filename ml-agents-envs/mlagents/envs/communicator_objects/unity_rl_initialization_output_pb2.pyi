# @generated by generate_proto_mypy_stubs.py.  Do not edit!
import sys
from google.protobuf.descriptor import (
    Descriptor as google___protobuf___descriptor___Descriptor,
)

from google.protobuf.internal.containers import (
    RepeatedCompositeFieldContainer as google___protobuf___internal___containers___RepeatedCompositeFieldContainer,
)

from google.protobuf.message import (
    Message as google___protobuf___message___Message,
)

from mlagents.envs.communicator_objects.brain_parameters_pb2 import (
    BrainParametersProto as mlagents___envs___communicator_objects___brain_parameters_pb2___BrainParametersProto,
)

from typing import (
    Iterable as typing___Iterable,
    Optional as typing___Optional,
    Text as typing___Text,
)

from typing_extensions import (
    Literal as typing_extensions___Literal,
)


builtin___bool = bool
builtin___bytes = bytes
builtin___float = float
builtin___int = int


class UnityRLInitializationOutputProto(google___protobuf___message___Message):
    DESCRIPTOR: google___protobuf___descriptor___Descriptor = ...
    name = ... # type: typing___Text
    version = ... # type: typing___Text
    log_path = ... # type: typing___Text

    @property
    def brain_parameters(self) -> google___protobuf___internal___containers___RepeatedCompositeFieldContainer[mlagents___envs___communicator_objects___brain_parameters_pb2___BrainParametersProto]: ...

    def __init__(self,
        *,
        name : typing___Optional[typing___Text] = None,
        version : typing___Optional[typing___Text] = None,
        log_path : typing___Optional[typing___Text] = None,
        brain_parameters : typing___Optional[typing___Iterable[mlagents___envs___communicator_objects___brain_parameters_pb2___BrainParametersProto]] = None,
        ) -> None: ...
    @classmethod
    def FromString(cls, s: builtin___bytes) -> UnityRLInitializationOutputProto: ...
    def MergeFrom(self, other_msg: google___protobuf___message___Message) -> None: ...
    def CopyFrom(self, other_msg: google___protobuf___message___Message) -> None: ...
    if sys.version_info >= (3,):
        def ClearField(self, field_name: typing_extensions___Literal[u"brain_parameters",u"log_path",u"name",u"version"]) -> None: ...
    else:
        def ClearField(self, field_name: typing_extensions___Literal[u"brain_parameters",b"brain_parameters",u"log_path",b"log_path",u"name",b"name",u"version",b"version"]) -> None: ...
