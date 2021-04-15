using MarsRover.Rover;

namespace MarsRover.Directions
{
    public interface IDirection
    {
        Position MoveForward(Position position);
        string AsString();
        IDirection ToRight();
        IDirection ToLeft();
    }
}