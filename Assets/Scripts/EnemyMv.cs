using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMv : MonoBehaviour
{
    public NavMeshAgent Agente;
    public Vector3 Posicion;
    public static bool pause;
    public GameObject pausePanel;
    // Start is called before the first frame update
    void Start()
    {
        if (!pause)
        {
            Agente.SetDestination(Posicion);
        }
        
    }

    private void Update()
    {
        
        if (!PlayerHealth.final)
        {
            if ((Input.GetKeyDown(KeyCode.Escape)))
            {
                pause = !pause;
                pausePanel.SetActive(pause);
                if (pause)
                {
                    Time.timeScale = 0;
                }
                else
                {
                    Time.timeScale = 1;
                }
            }
        }
    }
}
