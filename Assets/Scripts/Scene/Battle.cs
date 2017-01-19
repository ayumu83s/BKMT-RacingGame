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
        var op = LoadSceneFile("Battle");
        if (null == op)
            yield break;

        while (!op.isDone)
        {
            yield return null;
        }

        base.Initialize();
    }

    private void Update()
    {
        if (!isInitialized)
            return;
    }
}
