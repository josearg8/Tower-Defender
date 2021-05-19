using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemigos : MonoBehaviour
{   
    public GameObject E1Prefab;
    private float LastE1Time;
    public float FrequenlyE1;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    private void Update()
    {
        GeneratorEnemigos();  
    }
     private void GeneratorEnemigos()
     {
        if (Time.time - LastE1Time >= FrequenlyE1)
        {
            Instantiate(E1Prefab, transform.position, Quaternion.identity);
            LastE1Time = Time.time;
        }
        
     }

    private void GeneradorEnemigosConInvocacion ()
    {
        Instantiate(E1Prefab, transform.position, Quaternion.identity);
    }
}
