"""
@generated by mypy-protobuf.  Do not edit manually!
isort:skip_file
"""
import builtins
import google.protobuf.descriptor
import google.protobuf.message
import sys

if sys.version_info >= (3, 8):
    import typing as typing_extensions
else:
    import typing_extensions

DESCRIPTOR: google.protobuf.descriptor.FileDescriptor

@typing_extensions.final
class EngineConfigurationProto(google.protobuf.message.Message):
    DESCRIPTOR: google.protobuf.descriptor.Descriptor

    WIDTH_FIELD_NUMBER: builtins.int
    HEIGHT_FIELD_NUMBER: builtins.int
    QUALITY_LEVEL_FIELD_NUMBER: builtins.int
    TIME_SCALE_FIELD_NUMBER: builtins.int
    TARGET_FRAME_RATE_FIELD_NUMBER: builtins.int
    SHOW_MONITOR_FIELD_NUMBER: builtins.int
    width: builtins.int
    height: builtins.int
    quality_level: builtins.int
    time_scale: builtins.float
    target_frame_rate: builtins.int
    show_monitor: builtins.bool
    def __init__(
        self,
        *,
        width: builtins.int = ...,
        height: builtins.int = ...,
        quality_level: builtins.int = ...,
        time_scale: builtins.float = ...,
        target_frame_rate: builtins.int = ...,
        show_monitor: builtins.bool = ...,
    ) -> None: ...
    def ClearField(self, field_name: typing_extensions.Literal["height", b"height", "quality_level", b"quality_level", "show_monitor", b"show_monitor", "target_frame_rate", b"target_frame_rate", "time_scale", b"time_scale", "width", b"width"]) -> None: ...

global___EngineConfigurationProto = EngineConfigurationProto
