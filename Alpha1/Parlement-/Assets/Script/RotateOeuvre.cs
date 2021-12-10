using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOeuvre : MonoBehaviour
{
    public GameObject Oeuvre;
    
    public void Update()
    {
        Oeuvre.transform.Rotate(0, 0.5f, 0);
    }
}
