using System.Linq;
using MarsRover.Commands;
using MarsRover.Rover;

namespace MarsRover
{
    public class MarsRover
    {
        private readonly string _initialState;
        private Rover.Rover _rover;

        public MarsRover(string initialState)
        {
            _initialState = initialState;
        }

        public string Execute(string commandsAsString)
        {
            _rover = RoverFactory.CreateRover(_initialState);
            
            var commands = commandsAsString.Select(CommandFactory.CreateCommand).ToList();
            
            commands.ForEach(c => _rover = _rover.Apply(c));

            return _rover.PrintState();
        }
    }
}