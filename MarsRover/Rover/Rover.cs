using MarsRover.Commands;
using MarsRover.Directions;

namespace MarsRover.Rover
{
    public class Rover
    {
        private readonly Position _position;
        private readonly IDirection _direction;

        public Rover(Position position, IDirection direction)
        {
            _direction = direction;
            _position = position;
        }

        public Rover Apply(ICommand command) => ApplyCommand((dynamic) command);

        private Rover ApplyCommand(TurnRightCommand command) => new Rover(_position, _direction.ToRight());

        private Rover ApplyCommand(TurnLeftCommand command) => new Rover(_position, _direction.ToLeft());

        private Rover ApplyCommand(MoveForwardCommand command) => new Rover(_direction.MoveForward(_position), _direction);
        
        public string PrintState() => $"{_position.X}:{_position.Y}:{_direction.AsString()}";
    }
}