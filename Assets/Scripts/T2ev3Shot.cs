using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2ev3Shot : MonoBehaviour
{

    public GameObject PrefabBalaT2ev3;
    public GameObject Enemigo1Escena;
    public float AlturaBalaT2ev3;
    public float FrequenlyShoot;
    private float LastShootTime;
    private void Start()
    {

    }

    private void Update()
    {
        ShootT2ev3();
    }
    private void ShootT2ev3()
    {
        if (Enemigo1Escena != null)
        {
            if (Time.time - LastShootTime >= FrequenlyShoot)
            {
                GameObject BalaT2ev3 = Instantiate(PrefabBalaT2ev3, transform.position + new Vector3(0, AlturaBalaT2ev3, 0), Quaternion.identity);
                BalaT2ev3.GetComponent<BalaT2ev3Mv>().enemigo1 = Enemigo1Escena;
                LastShootTime = Time.time;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemigos"))
        {
            Enemigo1Escena = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Enemigo1Escena = null;
    }
}