//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ContextMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class AgentMatcher {

    public static Entitas.IAllOfMatcher<AgentEntity> AllOf(params int[] indices) {
        return Entitas.Matcher<AgentEntity>.AllOf(indices);
    }

    public static Entitas.IAllOfMatcher<AgentEntity> AllOf(params Entitas.IMatcher<AgentEntity>[] matchers) {
          return Entitas.Matcher<AgentEntity>.AllOf(matchers);
    }

    public static Entitas.IAnyOfMatcher<AgentEntity> AnyOf(params int[] indices) {
          return Entitas.Matcher<AgentEntity>.AnyOf(indices);
    }

    public static Entitas.IAnyOfMatcher<AgentEntity> AnyOf(params Entitas.IMatcher<AgentEntity>[] matchers) {
          return Entitas.Matcher<AgentEntity>.AnyOf(matchers);
    }
}
