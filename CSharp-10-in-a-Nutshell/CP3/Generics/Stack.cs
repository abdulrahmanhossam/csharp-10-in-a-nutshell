namespace CSharp_10_in_a_Nutshell.CP3.Generics;

public class Stack<T>
{
    int position;
    T[] data = new T[100];

    public void Push(T obj)
    {
        data[position++] = obj;
    }

    public T Pob()
    {
        return data[--position];
    }
}