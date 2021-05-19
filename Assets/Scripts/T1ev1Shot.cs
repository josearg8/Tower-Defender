using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T1ev1Shot : MonoBehaviour
{
   
    public GameObject PrefabBalaT1ev1;
    public GameObject Enemigo1Escena;
    public float AlturaBalaT1ev1;
    public float FrequenlyShoot;
    private float LastShootTime;
    private void Start()
    {
        
    }

    private void Update()
    {
        ShootT1ev1();   
    }
    private void ShootT1ev1()
    {
       
        if (Enemigo1Escena!= null)
        {
            
            if (Time.time - LastShootTime >=FrequenlyShoot){
                GameObject BalaT1ev1 = Instantiate(PrefabBalaT1ev1, transform.position + new Vector3(0, AlturaBalaT1ev1, 0), Quaternion.identity);
                BalaT1ev1.GetComponent<BalaT1ev1Mv>().enemigo1 = Enemigo1Escena;
                LastShootTime = Time.time;
            }
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {  
      if (other.CompareTag("Enemigos"))
      {
          Enemigo1Escena=other.gameObject;  
      }
    }
    private void OnTriggerExit(Collider other)
    {
        Enemigo1Escena = null;
    }
}