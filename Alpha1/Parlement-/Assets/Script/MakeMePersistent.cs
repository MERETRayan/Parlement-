using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MakeMePersistent : MonoBehaviour
{
    public GameObject[] persistentObjects;
    public int idSceneToLoad;
    // Start is called before the first frame update
    void Awake()
    {
        foreach (var obj in persistentObjects)
        {
            DontDestroyOnLoad(obj);
        }

        SceneManager.LoadScene(idSceneToLoad);
    }

}
