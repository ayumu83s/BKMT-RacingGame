using UnityEngine;
using System.Collections;

public class Accessor
{
    static Accessor instance = null;
    public static Accessor I
    {
        get
        {
            if (null == instance)
                instance = new Accessor();
            return instance;
        }
    }

    public SceneManager sceneManager = null;
    public void Initialize(AppMain appMain)
    {
        Transform inst = Utility.Realize("SceneManager", appMain.transform_);
        sceneManager = inst.GetComponent<SceneManager>();
        sceneManager.Initialize();
    }
}
