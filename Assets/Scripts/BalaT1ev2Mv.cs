using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaT1ev2Mv : MonoBehaviour
{
    public float bulletSpeed;
    public GameObject enemigo1;
    void Start()
    {
        Destroy(gameObject, 2);
    }
    void Update()
    {
        if (enemigo1 != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, enemigo1.transform.position, bulletSpeed);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigos"))
        {
            --collision.gameObject.GetComponent<VidaE1>().VidasE1;
        }
        Destroy(gameObject);
    }
}