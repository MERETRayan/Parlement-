using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeVisible : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject options;
    public void MakeVisibl()
    {
        options.SetActive(true);
    }
}
