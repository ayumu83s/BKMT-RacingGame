using UnityEngine;
using System.Collections;

public class SceneChanger : MonoBehaviour
{
    public string sceneName;
    public void ChangeScene()
    {
        Accessor.I.sceneManager.ChangeScene(sceneName);
    }
}
