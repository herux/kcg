using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace Particle
{
    public struct EmitterStateComponent : IComponent
    {
        public GameObject GameObject;
        public GameObject Prefab;

        public float ParticleDecayRate;
        public Vector2 ParticleAcceleration;
        public float ParticleDeltaRotation;
        public float ParticleDeltaScale;


        // we can use a mix of sprites for the particles
        public int[] SpriteIds;

        // the starting properties of the particles
        public Vector2 ParticleStartingVelocity;
        public float ParticleStartingRotation;
        public float ParticleStartingScale;
        public Color ParticleStartingColor;
        public float ParticleAnimationSpeed;


        public float Duration;
        public bool Loop;
        public int ParticleCount;
        public float TimeBetweenEmissions;

        public float CurrentTime;
    }
}