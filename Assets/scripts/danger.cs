using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class danger : MonoBehaviour
{
    public float maxmiss = 10f;
    public float misscount=0f;

    public AudioSource Music_Asource;
    public AudioSource GameOverSFX;
    public AudioClip gameoverclip;

    public Image milestoneimage;

    public GameObject gameoverpanel;
    public GameObject gamePanel;
    // Start is called before the first frame update
    void Start()
    {
        Music_Asource.volume =1f;
        gameoverpanel.SetActive(false);
        //gamePanel.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {

        //test---------------------

        milestoneimage.fillAmount = (misscount/maxmiss);
        
    }


    public void OnCollisionEnter(Collision c1)
    {
        if(c1.gameObject.tag == "good"||c1.gameObject.tag == "bad")
        {
            Destroy(c1.gameObject);
            misscount+=1;
            if(misscount >= maxmiss)
            {
                print("Game Over");
                Time.timeScale = 0f;
                Music_Asource.volume =0f;
                GameOverSFX.PlayOneShot(gameoverclip,0.5f);
                gameoverpanel.SetActive(true);
                gamePanel.SetActive(false);
                
            }
            
        }

    }
}
