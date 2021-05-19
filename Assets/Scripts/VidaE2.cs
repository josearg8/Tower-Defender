using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaE2 : MonoBehaviour
{
    public int VidasE2 = 10;
    void Start()
    {

    }
    private void Update ()
    {
        if (VidasE2 <= 0)
        {
            Destroy(gameObject);
        }
    }
}
