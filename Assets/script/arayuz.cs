using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class arayuz : MonoBehaviour
{
    // Start is called before the first frame update

   
    public void PlayButton()
    {
        skor.score = 0;
        SceneManager.LoadScene(1);
    }

    public void ExitButton()
    {
        Application.Quit();
    }

     void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            skor.score = 0;
            SceneManager.LoadScene(0);

        }
    }
}
