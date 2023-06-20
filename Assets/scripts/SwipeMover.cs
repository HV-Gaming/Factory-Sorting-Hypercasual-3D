using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;





public class SwipeMover : MonoBehaviour
{

    public GameObject GoodBin;
    public GameObject BadBin;
    // The speed at which the object will move
    

    // The starting position of the touch
    Vector2 startPos;

    public float ForceFactor;
    public bool InPos;
    public bool swright;
    public bool swleft;

    public int maxmiss = 5;
    public int misscount=0;

    public Text Score;
    public Text Coins;


    //public Animator playeranimator;
    //public  GameObject[] player; 
    

    //public Image milestoneimage;

    

    void Start()
    {
      
    }

    void Update()
    {
        
            

            touchscan();

                Score.GetComponent<Text>().text = PlayerPrefs.GetInt("score").ToString();
                Coins.GetComponent<Text>().text = PlayerPrefs.GetInt("Coins").ToString();
            


           
        

        
    }
    

    

    public void touchscan()
    {
        
        // Check if the screen is being touched
        if (Input.touchCount > 0)
        {
            print("Screen touched");
            // Get the first touch
            Touch touch = Input.GetTouch(0);

            // Check if the touch has just started (PhaseBegan)
            if (touch.phase == TouchPhase.Began)
            {
                // Store the position of the touch
                startPos = touch.position;
            }
            // Check if the touch has just ended (PhaseEnded)
            else if (touch.phase == TouchPhase.Ended)
            {
                // Calculate the distance the touch has moved since it started
                float swipeDistance = touch.position.x - startPos.x;

                // Convert the touch position from screen coordinates to world coordinates
                Vector3 touchWorldPos = Camera.main.ScreenToWorldPoint(touch.position);

                // Set the y position of the touch to the y position of the object
                touchWorldPos.y = transform.position.y;

                // Check if the swipe was to the left or right
                if (swipeDistance > 0)
                {
                  
                    print("swiping right");
                    if(InPos)
                    {
                    swright = true;
                   
                    }
                    
                    
                }
                else
                {
                    print("swiping left");
                    if(InPos)
                    {
                    swleft = true;
                   
                    }
                   
                }
            }
        }
    }



    public void OnCollisionStay(Collision col) 
    {
        
          
        
            
            InPos = true;
            if(swright == true)
            {
                StartCoroutine(ShootRight(col.gameObject));
                InPos = false;

            }

            if(swleft == true)
            {
                StartCoroutine(ShootLeft(col.gameObject));
                InPos = false;

            }
            
            
            

        
        
    }
    


    public IEnumerator ShootRight(GameObject Gobj)
    {
        
        Gobj.GetComponent<Rigidbody>().AddForce((GoodBin.transform.position - transform.position).normalized*ForceFactor,ForceMode.Impulse);
        
       
        
        yield return new WaitForSeconds(.2f);
        swright=false;
        
        

    }

    public IEnumerator ShootLeft(GameObject Gobj)
    {
           
            Gobj.GetComponent<Rigidbody>().AddForce((BadBin.transform.position - transform.position).normalized*ForceFactor,ForceMode.Impulse);
            
            
            
            yield return new WaitForSeconds(.2f);
            swleft=false;
        
        

    }
    }
