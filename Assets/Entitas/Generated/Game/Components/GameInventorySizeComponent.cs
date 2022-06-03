//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Inventory.SizeComponent inventorySize { get { return (Inventory.SizeComponent)GetComponent(GameComponentsLookup.InventorySize); } }
    public bool hasInventorySize { get { return HasComponent(GameComponentsLookup.InventorySize); } }

    public void AddInventorySize(int newWidth, int newHeight) {
        var index = GameComponentsLookup.InventorySize;
        var component = (Inventory.SizeComponent)CreateComponent(index, typeof(Inventory.SizeComponent));
        component.Width = newWidth;
        component.Height = newHeight;
        AddComponent(index, component);
    }

    public void ReplaceInventorySize(int newWidth, int newHeight) {
        var index = GameComponentsLookup.InventorySize;
        var component = (Inventory.SizeComponent)CreateComponent(index, typeof(Inventory.SizeComponent));
        component.Width = newWidth;
        component.Height = newHeight;
        ReplaceComponent(index, component);
    }

    public void RemoveInventorySize() {
        RemoveComponent(GameComponentsLookup.InventorySize);
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

    static Entitas.IMatcher<GameEntity> _matcherInventorySize;

    public static Entitas.IMatcher<GameEntity> InventorySize {
        get {
            if (_matcherInventorySize == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.InventorySize);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherInventorySize = matcher;
            }

            return _matcherInventorySize;
        }
    }
}
