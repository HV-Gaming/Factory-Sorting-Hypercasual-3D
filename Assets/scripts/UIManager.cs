
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
        Time.timeScale = 1f;
        
    }
    public void mainmenu()
    {
        SceneManager.LoadScene("MainMenu"); 
        
    }
    public void quit()
    {
        Application.Quit();
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Level3");
    }
}
