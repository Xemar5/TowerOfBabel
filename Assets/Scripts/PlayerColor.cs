using System;

[Flags]
public enum PlayerColor
{
    Red =       0b00000001,
    Green =     0b00000010,
    Blue =      0b00000100,
    Yellow =    0b00001000,

    Purple =    0b00010000,
    Brown =     0b00100000,
    Teal =      0b01000000,
    Orange =    0b10000000,
}

public static class PlayerColorExtensions
{
    public static int ToIndex(this PlayerColor color)
    {
        if (color.HasFlag(PlayerColor.Red)) return 0;
        if (color.HasFlag(PlayerColor.Green)) return 1;
        if (color.HasFlag(PlayerColor.Blue)) return 2;
        if (color.HasFlag(PlayerColor.Yellow)) return 3;
        if (color.HasFlag(PlayerColor.Purple)) return 4;
        if (color.HasFlag(PlayerColor.Brown)) return 5;
        if (color.HasFlag(PlayerColor.Teal)) return 6;
        if (color.HasFlag(PlayerColor.Orange)) return 7;
        return -1;
    }
    public static PlayerColor Team(this PlayerColor color)
    {
        if (color == PlayerColor.Red ||
            color == PlayerColor.Green ||
            color == PlayerColor.Blue ||
            color == PlayerColor.Yellow)
        {
            return PlayerColor.Red | PlayerColor.Green | PlayerColor.Blue | PlayerColor.Yellow;
        }
        else
        {
            return PlayerColor.Brown | PlayerColor.Orange | PlayerColor.Purple | PlayerColor.Teal;
        }
    }
    public static PlayerColor Opponents(this PlayerColor color)
    {
        if (color == PlayerColor.Red ||
            color == PlayerColor.Green ||
            color == PlayerColor.Blue ||
            color == PlayerColor.Yellow)
        {
            return PlayerColor.Brown | PlayerColor.Orange | PlayerColor.Purple | PlayerColor.Teal;
        }
        else
        {
            return PlayerColor.Red | PlayerColor.Green | PlayerColor.Blue | PlayerColor.Yellow;
        }
    }
}