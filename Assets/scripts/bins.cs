using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bins : MonoBehaviour
{

    public ParticleSystem particles;

    
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("score",0);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision other) 
    {
       if(other.gameObject.tag == this.gameObject.tag)
       {
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
