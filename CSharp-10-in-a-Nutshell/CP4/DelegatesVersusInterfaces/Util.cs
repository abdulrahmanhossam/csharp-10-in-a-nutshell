namespace CSharp_10_in_a_Nutshell.CP4.DelegatesVersusInterfaces;

public static class Util
{
    public static void TransformAll(int[] values, ITransformer t)
    {
        for (int i = 0; i < values.Length; i++)
            values[i] = t.Transform(values[i]);
    }
}