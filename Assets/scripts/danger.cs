using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class danger : MonoBehaviour
{
    public float maxmiss = 10f;
    public float misscount=0f;

    public Image milestoneimage;
    // Start is called before the first frame update
    void Start()
    {
        
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
            }
            
        }

    }
}
