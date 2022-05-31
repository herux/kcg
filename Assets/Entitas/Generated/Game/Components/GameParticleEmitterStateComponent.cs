//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Components.ParticleEmitterStateComponent particleEmitterState { get { return (Components.ParticleEmitterStateComponent)GetComponent(GameComponentsLookup.ParticleEmitterState); } }
    public bool hasParticleEmitterState { get { return HasComponent(GameComponentsLookup.ParticleEmitterState); } }

    public void AddParticleEmitterState(UnityEngine.GameObject newGameObject, UnityEngine.GameObject newPrefab, float newParticleDecayRate, UnityEngine.Vector2 newParticleAcceleration, float newParticleDeltaRotation, float newParticleDeltaScale, int[] newSpriteIds, UnityEngine.Vector2 newParticleStartingVelocity, float newParticleStartingRotation, float newParticleStartingScale, UnityEngine.Color newParticleStartingColor, float newParticleAnimationSpeed, float newDuration, bool newLoop, int newParticleCount, float newTimeBetweenEmissions, float newCurrentTime) {
        var index = GameComponentsLookup.ParticleEmitterState;
        var component = (Components.ParticleEmitterStateComponent)CreateComponent(index, typeof(Components.ParticleEmitterStateComponent));
        component.GameObject = newGameObject;
        component.Prefab = newPrefab;
        component.ParticleDecayRate = newParticleDecayRate;
        component.ParticleAcceleration = newParticleAcceleration;
        component.ParticleDeltaRotation = newParticleDeltaRotation;
        component.ParticleDeltaScale = newParticleDeltaScale;
        component.SpriteIds = newSpriteIds;
        component.ParticleStartingVelocity = newParticleStartingVelocity;
        component.ParticleStartingRotation = newParticleStartingRotation;
        component.ParticleStartingScale = newParticleStartingScale;
        component.ParticleStartingColor = newParticleStartingColor;
        component.ParticleAnimationSpeed = newParticleAnimationSpeed;
        component.Duration = newDuration;
        component.Loop = newLoop;
        component.ParticleCount = newParticleCount;
        component.TimeBetweenEmissions = newTimeBetweenEmissions;
        component.CurrentTime = newCurrentTime;
        AddComponent(index, component);
    }

    public void ReplaceParticleEmitterState(UnityEngine.GameObject newGameObject, UnityEngine.GameObject newPrefab, float newParticleDecayRate, UnityEngine.Vector2 newParticleAcceleration, float newParticleDeltaRotation, float newParticleDeltaScale, int[] newSpriteIds, UnityEngine.Vector2 newParticleStartingVelocity, float newParticleStartingRotation, float newParticleStartingScale, UnityEngine.Color newParticleStartingColor, float newParticleAnimationSpeed, float newDuration, bool newLoop, int newParticleCount, float newTimeBetweenEmissions, float newCurrentTime) {
        var index = GameComponentsLookup.ParticleEmitterState;
        var component = (Components.ParticleEmitterStateComponent)CreateComponent(index, typeof(Components.ParticleEmitterStateComponent));
        component.GameObject = newGameObject;
        component.Prefab = newPrefab;
        component.ParticleDecayRate = newParticleDecayRate;
        component.ParticleAcceleration = newParticleAcceleration;
        component.ParticleDeltaRotation = newParticleDeltaRotation;
        component.ParticleDeltaScale = newParticleDeltaScale;
        component.SpriteIds = newSpriteIds;
        component.ParticleStartingVelocity = newParticleStartingVelocity;
        component.ParticleStartingRotation = newParticleStartingRotation;
        component.ParticleStartingScale = newParticleStartingScale;
        component.ParticleStartingColor = newParticleStartingColor;
        component.ParticleAnimationSpeed = newParticleAnimationSpeed;
        component.Duration = newDuration;
        component.Loop = newLoop;
        component.ParticleCount = newParticleCount;
        component.TimeBetweenEmissions = newTimeBetweenEmissions;
        component.CurrentTime = newCurrentTime;
        ReplaceComponent(index, component);
    }

    public void RemoveParticleEmitterState() {
        RemoveComponent(GameComponentsLookup.ParticleEmitterState);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherParticleEmitterState;

    public static Entitas.IMatcher<GameEntity> ParticleEmitterState {
        get {
            if (_matcherParticleEmitterState == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ParticleEmitterState);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherParticleEmitterState = matcher;
            }

            return _matcherParticleEmitterState;
        }
    }
}
