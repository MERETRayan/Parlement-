using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfClickMe : MonoBehaviour
{
    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject UI1;
    public GameObject UI2;
    public void OnMouseDown()
    {
        Cam1.SetActive(false);
        Cam2.SetActive(true);
        UI1.SetActive(false);
        UI2.SetActive(true);
    }
}
