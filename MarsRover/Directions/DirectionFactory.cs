using System;

namespace MarsRover.Directions
{
    public static class DirectionFactory
    {
        public static IDirection CreateDirection(string directionAsString) =>
            directionAsString switch
            {
                "N" => new North(),
                "W" => new West(),
                "E" => new East(),
                "S" => new South(),
                _ => throw new NotSupportedException($"Direction {directionAsString} is not supported")
            };
    }
}