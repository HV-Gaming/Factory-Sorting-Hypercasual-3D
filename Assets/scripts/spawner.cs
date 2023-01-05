using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] prefabs; // Set of prefabs to choose from
    public Transform spawnPoint; // Transform where the prefab will be spawned 

    public int randomIndex; // Random number generator

    public float spawnInterval = 2f; // Interval between spawning prefabs, in seconds
    private float elapsedTime = 0f; // Time elapsed since the last spawn

    public int spawncount; // Number of game objects to spawn

    public int levelcap;


    // Start is called before the first frame update
    void Start()
    {
        //levelcap = PlayerPrefs.GetInt("levelspawncount");


    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= spawnInterval)
        {
            // StartCoroutine(Spawn());
            int randomIndex = Random.Range(0, prefabs.Length);
            GameObject prefab = prefabs[randomIndex];

            // Spawn the prefab at the spawn point
            Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
            spawncount += 1;

            // Reset elapsed time
            elapsedTime = 0f;

        }

        if (spawncount >= levelcap)
        {
            this.gameObject.SetActive(false);
        }


    }

}
