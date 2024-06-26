﻿namespace StabilityMatrix.Avalonia.Models.Inference;

public class SamplerCardModel
{
    public int Steps { get; init; }

    public bool IsDenoiseStrengthEnabled { get; init; } = false;
    public double DenoiseStrength { get; init; }

    public bool IsCfgScaleEnabled { get; init; } = true;
    public double CfgScale { get; init; }

    public bool IsDimensionsEnabled { get; init; }
    public int Width { get; init; }
    public int Height { get; init; }

    public bool IsSamplerSelectionEnabled { get; init; } = true;
    public string? SelectedSampler { get; init; }
}
