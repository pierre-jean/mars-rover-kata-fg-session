using MarsRover.Rover;

namespace MarsRover.Directions
{
    public class North : IDirection
    {
        public Position MoveForward(Position position) => new Position(position.X, position.Y+1);
        public string AsString() => "N";
        public IDirection ToRight() => new East();
        public IDirection ToLeft() => new West();
    }
}