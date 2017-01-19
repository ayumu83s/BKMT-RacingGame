using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour
{
    Transform transform_;
    SceneBase currentScene_ = null;
    SceneBase nextScene_ = null;
    bool isChanging = false;
    string sceneFileName;

    private void Awake()
    {
        transform_ = transform;
    }

    public void Initialize()
    {

    }

    public void ChangeScene(string sceneName)
    {
        if (isChanging)
            return;
        isChanging = true;
        Transform cur = Utility.Realize(sceneName, transform_);
        nextScene_ = cur.GetComponent<SceneBase>();
        StartCoroutine(DoChangeScene());
    }
    IEnumerator DoChangeScene()
    {
        yield return null;
        if (null != currentScene_)
        {
            Destroy(currentScene_.gameObject);
        }
        nextScene_.Initialize();
        currentScene_ = nextScene_;
        nextScene_ = null;
        isChanging = false;
    }
}
