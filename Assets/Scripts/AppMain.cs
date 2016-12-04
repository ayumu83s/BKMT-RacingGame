using UnityEngine;
using System.Collections;

public class AppMain : MonoBehaviour
{
    public string startScene = "";

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
        yield return null;
    }
}
