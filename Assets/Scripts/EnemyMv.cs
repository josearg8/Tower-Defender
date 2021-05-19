using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMv : MonoBehaviour
{
    public NavMeshAgent Agente;
    public Vector3 Posicion;
    // Start is called before the first frame update
    void Start()
    {
        Agente.SetDestination(Posicion);
    }
}
