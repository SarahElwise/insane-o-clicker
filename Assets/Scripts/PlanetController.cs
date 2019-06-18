using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlanetController : MonoBehaviour
{
    public string sceneName;

    

    // Update is called once per frame
    void Update()
    {
        
        if (false){
            SceneManager.LoadScene(sceneName);
        }
    }
}
