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
    public void Initialize()
    {
        sceneManager = new SceneManager();
        sceneManager.Initialize();
    }
}
