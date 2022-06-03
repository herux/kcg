//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Vehicle.ComponentDraw vehicleComponentDraw { get { return (Vehicle.ComponentDraw)GetComponent(GameComponentsLookup.VehicleComponentDraw); } }
    public bool hasVehicleComponentDraw { get { return HasComponent(GameComponentsLookup.VehicleComponentDraw); } }

    public void AddVehicleComponentDraw(int newSpriteId, int newWidth, int newHeight) {
        var index = GameComponentsLookup.VehicleComponentDraw;
        var component = (Vehicle.ComponentDraw)CreateComponent(index, typeof(Vehicle.ComponentDraw));
        component.spriteId = newSpriteId;
        component.width = newWidth;
        component.height = newHeight;
        AddComponent(index, component);
    }

    public void ReplaceVehicleComponentDraw(int newSpriteId, int newWidth, int newHeight) {
        var index = GameComponentsLookup.VehicleComponentDraw;
        var component = (Vehicle.ComponentDraw)CreateComponent(index, typeof(Vehicle.ComponentDraw));
        component.spriteId = newSpriteId;
        component.width = newWidth;
        component.height = newHeight;
        ReplaceComponent(index, component);
    }

    public void RemoveVehicleComponentDraw() {
        RemoveComponent(GameComponentsLookup.VehicleComponentDraw);
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

    static Entitas.IMatcher<GameEntity> _matcherVehicleComponentDraw;

    public static Entitas.IMatcher<GameEntity> VehicleComponentDraw {
        get {
            if (_matcherVehicleComponentDraw == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.VehicleComponentDraw);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherVehicleComponentDraw = matcher;
            }

            return _matcherVehicleComponentDraw;
        }
    }
}
