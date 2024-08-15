using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // cuando empieza la escena este valor es null
    public void Awake()
    {
        if (Instance != null && Instance != this) //si ya hay algo
        {
            Destroy(this.gameObject); // destruirme
        }

        else // entonces esta vacio
        {
            Instance = this; // asigno que instance es this
        }

        DontDestroyOnLoad(this); // no destruir el objeto cuando cambie la escena
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            ChangeScene("Game"); // tiene que coincidir exactamente con el nombre de la escena
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            ChangeScene("Menu");
        }
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName); // pongo un parametro
    }

    
}
