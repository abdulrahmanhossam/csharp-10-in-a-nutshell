using CSharp_10_in_a_Nutshell.CP3.ExplicitInterfaceImplementation;

namespace CSharp_10_in_a_Nutshell.CP3.GenericConstraints;

public class MyGenericClass<T> where T : class, IPrintable, IComparable<T>, new()
{

}