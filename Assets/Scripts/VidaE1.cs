using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaE1 : MonoBehaviour
{
    public int  VidasE1 = 3;
    public HealthBardE1 healthBardE1;
    void Start()
    {
        healthBardE1.MaxHealth(VidasE1);
        
    }
    private void Update()
    {
       if (VidasE1 <= 0)
        {
            Destroy(gameObject);
        }
    }
}
