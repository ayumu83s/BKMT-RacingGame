using UnityEngine;
using System.Collections;

public class AppMain : MonoBehaviour
{
    public string startScene = "";
    public Transform transform_;

    private void Awake()
    {
        Initialize();
    }

    void Initialize()
    {
        StartCoroutine(DoInitialize());
    }
    IEnumerator DoInitialize()
    {
        transform_ = transform;
        Accessor.I.Initialize(this);
        Accessor.I.sceneManager.ChangeScene("Title");
        yield return null;
    }
}
