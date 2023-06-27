using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class testscript : MonoBehaviour
{

    public GameObject canvasobject;
    public conveyorbelt cb;
    public void pause()
    {
        Time.timeScale = 0f;
    }

    public void resume()
    {
        Time.timeScale = 1f;
    }

    public void setcanvasactive()
    {
        canvasobject.SetActive(false);
        Debug.Log(cb.speed);
    }




}
