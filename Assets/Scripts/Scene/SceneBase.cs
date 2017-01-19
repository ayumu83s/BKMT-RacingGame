using UnityEngine;
using System.Collections;

public class SceneBase : MonoBehaviour
{
    public bool isInitialized
    {
        get; set;
    }
    public string sceneFileName
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

    public virtual void OnDestroy()
    {
        UnloadSceneFile();
    }

    /*
     * UnitySceneの読み込み
     */
    public AsyncOperation LoadSceneFile(string sceneName)
    {
        sceneFileName = sceneName;
        var mode = UnityEngine.SceneManagement.LoadSceneMode.Additive;
        return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName, mode);
    }

    /*
     * UnitySceneの破棄
     */
    public void UnloadSceneFile()
    {
        if (!string.IsNullOrEmpty(sceneFileName))
        {
            UnityEngine.SceneManagement.SceneManager.UnloadScene(sceneFileName);
        }
        sceneFileName = "";
    }
}
