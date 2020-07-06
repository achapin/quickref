using System;
using System.Collections;
using System.Collections.Generic;

public static class QuickRef
{
    private static Dictionary<Type, Object> references = new Dictionary<Type, Object>();

    public static void RegisterReference(Object newReferenceObject){
        references.Add(newReferenceObject.GetType(), newReferenceObject);
    }

    public static Object GetReference(Type type){
        if(references.ContainsKey(type)){
            return references[type];
        }
        return null;
    }
}
