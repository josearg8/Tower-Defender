using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaT1ev3Mv : MonoBehaviour
{
    public float bulletSpeed;
    public GameObject enemigo1;
    public ParticleSystem estela;
    public ParticleSystem destruccionBala;
    void Start()
    {

        Destroy(gameObject, 3);
        destruccionBala.Play();
    }
    void Update()
    {
        if (enemigo1 != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, enemigo1.transform.position, bulletSpeed);
            estela.Play();
        }
        else
        {
            Destroy(gameObject);
            destruccionBala.Play();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigos"))
        {
            --collision.gameObject.GetComponent<VidaE1>().VidasE1;
        }
        Destroy(gameObject);
        destruccionBala.Play();
    }
}