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
    public int levelgoalgood = 10;
    public int levelgoalbad = 10;

    public int sessionscore = 0;
    public int SessionCoinsCollected = 0;
    public GameObject completed;
    public GameObject Warning;


    //audio

    public AudioSource Asource;

    public AudioClip[] clips;

    //shake

    //public GameObject CameraObject;
    public Animator CameraAnimator;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("score", 0);
        Warning.SetActive(false);



    }

    // Update is called once per frame
    void Update()
    {

        if (goodsorted >= levelgoalgood || badsorted >= levelgoalbad)
        {
            Time.timeScale = 0f;
            completed.SetActive(true);


        }

        sessionscore = (PlayerPrefs.GetInt("score"));


    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == this.gameObject.tag)
        {

            if (other.gameObject.tag == "good")
            {
                goodsorted += 1;
            }
            if (other.gameObject.tag == "bad")
            {
                badsorted += 1;
            }


            particles.Play();
            Asource.PlayOneShot(clips[0], 1f);
            Destroy(other.gameObject);
            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 10);
            print(PlayerPrefs.GetInt("score"));
            print("right sort");
            SessionCoinsCollected += 1;
            PlayerPrefs.SetInt("Coins", (PlayerPrefs.GetInt("Coins") + 1));



        }
        else
        {
            Destroy(other.gameObject);
            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") - 10);
            checkneg();
            print("Wrong sort");
            print(PlayerPrefs.GetInt("score"));
            StartCoroutine(flash());

        }

    }

    public void checkneg()
    {
        if ((PlayerPrefs.GetInt("score") <= 0))
        {
            PlayerPrefs.SetInt("score", 0);
        }
    }

    public IEnumerator flash()
    {
        Asource.PlayOneShot(clips[1], 0.75f);
        Warning.SetActive(true);
        CameraAnimator.SetTrigger("bs");
        Handheld.Vibrate();
        yield return new WaitForSeconds(0.5f);
        CameraAnimator.SetTrigger("bs");
        Warning.SetActive(false);
        yield break;

    }








}
