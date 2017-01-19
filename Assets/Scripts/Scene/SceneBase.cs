using UnityEngine;
using System.Collections;

public class SceneBase : MonoBehaviour
{
    public bool isInitialized
    {
        get; set;
    }

    void Awake()
    {
        isInitialized = false;
    }

    public virtual void Initialize()
    {
        // フェードインとか入れる
        isInitialized = true;
    }
}
