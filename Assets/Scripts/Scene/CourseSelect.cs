using UnityEngine;
using System.Collections;

public class CourseSelect : SceneBase
{
    public override void Initialize()
    {
        StartCoroutine(DoInitialize());
    }
    IEnumerator DoInitialize()
    {
        Debug.Log("CourseSelect");
        yield return new WaitForSeconds(2.0f);
        base.Initialize();
    }

    private void Update()
    {
        if (!isInitialized)
            return;

        Accessor.I.sceneManager.ChangeScene("Battle");
    }
}
