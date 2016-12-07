using UnityEngine;
using System.Collections;

public class Battle : SceneBase
{
    public override void Initialize()
    {
        StartCoroutine(DoInitialize());
    }
    IEnumerator DoInitialize()
    {
        Debug.Log("Battle");
        yield return new WaitForSeconds(2.0f);
        base.Initialize();
    }

    private void Update()
    {
        if (!isInitialized)
            return;
    }
}
