namespace CSharp_10_in_a_Nutshell.CP4.DelegatesVersusInterfaces;

// Architectural Rule of Thumb:
// -> Use INTERFACES: To define an "Object" that has a cohesive set of behaviors (e.g., IDatabase with Save, Read, Delete).
// -> Use DELEGATES: To pass a "Single, isolated behavior/action" like a plug-in or a callback (e.g., OnSuccess action).
public class Squarer : ITransformer
{
    public int Transform(int x) => x * x;
}