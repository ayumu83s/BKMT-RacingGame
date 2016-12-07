using UnityEngine;
using System.Collections;

public static class Utility
{
    public static Transform Realize(string className, Transform parent = null)
    {
        GameObject go = new GameObject(className);
        go.AddComponent(System.Type.GetType(className));
        Transform t = go.transform;
        if (null != parent)
        {
            Attach(t, parent);
        }
        return t;
    }

    public static void Attach(Transform child, Transform parent)
    {
        Vector3 position = child.localPosition;
        Quaternion rotation = child.localRotation;
        Vector3 scale = child.localScale;
        child.SetParent(parent);
        child.localPosition = position;
        child.localRotation = rotation;
        child.localScale = scale;
    }
}
