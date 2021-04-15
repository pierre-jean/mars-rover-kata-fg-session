using System;

namespace MarsRover.Commands
{
    public static class CommandFactory
    {
        public static ICommand CreateCommand(char c) =>
            c switch
            {
                'M' => new MoveForwardCommand(),
                'R' => new TurnRightCommand(),
                'L' => new TurnLeftCommand(),
                _ => throw new NotSupportedException($"Command {c} not supported")
            };
    }
}