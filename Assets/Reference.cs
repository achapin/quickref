using System;
public class Reference<T>
{
    private T reference;
    public T Ref
    {
        get
        {
            if(reference == null)
            {
                reference = (T) Convert.ChangeType(QuickRef.GetReference(typeof(T)), typeof(T));
            }
            return reference;
        }
    }
}