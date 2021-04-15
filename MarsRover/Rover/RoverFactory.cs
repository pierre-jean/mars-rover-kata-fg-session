using MarsRover.Directions;

namespace MarsRover.Rover
{
    public static class RoverFactory
    {
        public static Rover CreateRover(string initialState)
        {
            var states = initialState.Split(":");
            var x = int.Parse(states[0]);
            var y = int.Parse(states[1]);
            var position = new Position(x, y);
            var directionAsString = states[2];
            var direction = DirectionFactory.CreateDirection(directionAsString);
            return new Rover(position, direction);
        }
    }
}