using UnityEngine;
using System.Collections;

public class CharacterSelect : SceneBase
{
    public override void Initialize()
    {
        StartCoroutine(DoInitialize());
    }
    IEnumerator DoInitialize()
    {
        Debug.Log("CharacterSelect");
        yield return new WaitForSeconds(2.0f);
        base.Initialize();
    }

    private void Update()
    {
        if (!isInitialized)
            return;

        Accessor.I.sceneManager.ChangeScene("CourseSelect");
    }
}
