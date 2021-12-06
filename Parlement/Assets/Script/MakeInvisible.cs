using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeInvisible : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject options;
    public void MakeInvisibl()
    {
        options.SetActive(false);
    }
}
