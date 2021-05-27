using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int vidas = 10;
   
    public GameObject gameOverPanel;
    public static bool final;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigos"))
        {
            vidas--;

            if (vidas == 0)
            {
                final = true;
                gameOverPanel.SetActive(true);

                EnemyMv.pause = true;
                
                Time.timeScale = 0;
            }
        }
    }
}
