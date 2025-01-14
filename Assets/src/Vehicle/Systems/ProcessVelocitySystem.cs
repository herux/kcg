using UnityEngine;
using Entitas;

namespace Vehicle
{
    public sealed class ProcessVelocitySystem
    {
        // Singleton
        public static readonly ProcessVelocitySystem Instance;

        // Game Context
        private GameContext gameContext;

        // Static Constructor
        static ProcessVelocitySystem()
        {
            Instance = new ProcessVelocitySystem();
        }

        // Constructor
        public ProcessVelocitySystem()
        {
            gameContext = Contexts.sharedInstance.game;
        }

        // Move Function
        public void Process(Contexts contexts)
        {
            IGroup<GameEntity> entities =
            contexts.game.GetGroup(GameMatcher.VehiclePosition2D);
            foreach (var vehicle in entities)
            {
                var position = vehicle.vehiclePosition2D;
                position.TempPosition = position.Position;

                position.Position += vehicle.vehicleVelocity.Value * Time.deltaTime;

                vehicle.ReplaceVehiclePosition2D(position.Position, position.TempPosition);
            }
        }
    }
}

