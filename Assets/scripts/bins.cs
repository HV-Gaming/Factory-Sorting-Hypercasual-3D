using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bins : MonoBehaviour
{

    public ParticleSystem particles;
    public int goodsorted;
    public int badsorted;
    public int levelgoal = 10;
    public GameObject completed;

    
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("score",0);

        
    }

    // Update is called once per frame
    void Update()
    {

        if(goodsorted >= levelgoal)
        {
            Time.timeScale =0f;
            completed.SetActive(true);
            

        }
        
    }

    public void OnCollisionEnter(Collision other) 
    {
       if(other.gameObject.tag == this.gameObject.tag)
       {

        if(other.gameObject.tag == "good")
        {
            goodsorted+=1;
        }
        if(other.gameObject.tag == "bad")
        {
            badsorted+=1;
        }


        particles.Play();
        Destroy(other.gameObject);
        PlayerPrefs.SetInt("score",PlayerPrefs.GetInt("score")+10); 
        print(PlayerPrefs.GetInt("score"));
        print("right sort");
        
         
       } 
       else
       {
        Destroy(other.gameObject);
        PlayerPrefs.SetInt("score",PlayerPrefs.GetInt("score")-10);
        checkneg(); 
        print("Wrong sort");
        print(PlayerPrefs.GetInt("score"));

       }
        
    }

    public void checkneg()
    {
        if((PlayerPrefs.GetInt("score")<=0))
        {
            PlayerPrefs.SetInt("score",0);
        }
    }
}
