using MarsRover.Rover;

namespace MarsRover.Directions
{
    public class West : IDirection
    {
        public Position MoveForward(Position position) => new Position(position.X -1 , position.Y);
        public string AsString() => "W";
        public IDirection ToRight() => new North();
        public IDirection ToLeft() => new South();
    }
}