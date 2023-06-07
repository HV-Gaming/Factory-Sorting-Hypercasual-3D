
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject pausecanvas;


    // Start is called before the first frame update
    void Start()
    {
        pausecanvas.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pause()
    {
        Time.timeScale = 0f;
        pausecanvas.SetActive(true);
    }
    public void resume()
    {
        Time.timeScale = 1f;
        pausecanvas.SetActive(false);
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
    public void mainmenu()
    {
        SceneManager.LoadScene("MainMenu"); 
        
    }
}
