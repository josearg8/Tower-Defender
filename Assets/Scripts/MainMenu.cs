using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level1");

    }

    public void Level2()
    {
        SceneManager.LoadScene("Level2");

    }
}