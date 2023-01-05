using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void skin1()
    {

        if (PlayerPrefs.GetInt("Coins") >= 10)
        {
            if (PlayerPrefs.GetInt("skin1status") == 0)
            {

                PlayerPrefs.SetInt("PlayerSkin", 1);
                PlayerPrefs.SetInt("skin1status", 1);
                print("unlocked");
                PlayerPrefs.SetInt("Coins", (PlayerPrefs.GetInt("Coins") - 10));

            }



            //PlayerPrefs.SetInt("Coins",(PlayerPrefs.GetInt("Coins")-10));

        }
        else
        {
            print("not enough coins");
        }



    }

    public void skin2()
    {

        if (PlayerPrefs.GetInt("Coins") >= 40)
        {
            if (PlayerPrefs.GetInt("skin2status") == 0)
            {

                PlayerPrefs.SetInt("PlayerSkin", 2);
                PlayerPrefs.SetInt("skin2status", 1);
                print("unlocked");
                PlayerPrefs.SetInt("Coins", (PlayerPrefs.GetInt("Coins") - 40));

            }



            //PlayerPrefs.SetInt("Coins",(PlayerPrefs.GetInt("Coins")-10));

        }
        else
        {
            print("not enough coins");
        }



    }

    public void defaultSkin()
    {


        PlayerPrefs.SetInt("PlayerSkin", 0);
        //PlayerPrefs.SetInt("Coins",(PlayerPrefs.GetInt("Coins")-10));

        //PlayerPrefs.SetInt("Coins",(PlayerPrefs.GetInt("Coins")-10));





    }
    public void level1()
    {

        PlayerPrefs.SetInt("levelspawncount", 50);
        SceneManager.LoadScene("level1");
    }


}
