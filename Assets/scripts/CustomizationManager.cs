using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CustomizationManager : MonoBehaviour
{

    public TextMeshProUGUI cointext;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("Coins",100);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        cointext.text = PlayerPrefs.GetInt("Coins").ToString();
        
    }

    
}
