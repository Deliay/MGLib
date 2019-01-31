using System;
using System.Collections.Generic;
using System.Text;

namespace MGLib.Osu.Model.Osb.Commands
{
    public enum ParameterType
    {
        FlipHorizontally,
        FlipVertically,
        BlendAdditive,
    }

    public static class ParameterTypeHelper
    {
        public static string GetShortHand(this ParameterType parameter)
        {
            switch (parameter)
            {
                case ParameterType.FlipHorizontally:
                    return "H";
                case ParameterType.FlipVertically:
                    return "V";
                case ParameterType.BlendAdditive:
                    return "A";
                default:
                    throw new ArgumentOutOfRangeException(nameof(parameter));
            }
        }

        public static ParameterType ToParameterType(this char shortHand)
        {
            switch (shortHand)
            {
                case 'H': return ParameterType.FlipHorizontally;
                case 'V': return ParameterType.FlipVertically;
                case 'A': return ParameterType.BlendAdditive;
            }
            throw new ArgumentOutOfRangeException(nameof(shortHand));
        }
    }
}
