try:
    # This should be the only place that we import torch directly.
    # Everywhere else is caught by the banned-modules setting for flake8
    import torch  # noqa I201

    # Known PyLint compatibility with PyTorch https://github.com/pytorch/pytorch/issues/701
    # pylint: disable=E1101
    if torch.cuda.is_available():
        torch.set_default_tensor_type(torch.cuda.FloatTensor)
    else:
        torch.set_default_tensor_type(torch.FloatTensor)
    nn = torch.nn
    # pylint: disable=E1101
except ImportError:
    torch = None
    nn = None


def is_available():
    """
    Returns whether Torch is available in this Python environment
    """
    return torch is not None
