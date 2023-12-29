using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject grassTile;
    public GameObject pond1;
    public GameObject pond2;
    public GameObject pond3;
    public GameObject duck;
    // Start is called before the first frame update
    void Start()
    {
        //spawn grass
        for (int x = 0; x < 10; x++)
        { 
            for (int z = 0; z < 10; z++)
            {

                GameObject spawn = Instantiate(grassTile, new Vector3(x*100, 0, z*100), Quaternion.identity);
            }
        }

        //spawn ponds
        GameObject pond1Spawn = Instantiate(pond1, new Vector3((float)528, (float)0.1, (float)632.8), Quaternion.identity);
        pond1Spawn.transform.localScale = new Vector3((float)50, (float)1, (float)50);

        GameObject pond2Spawn = Instantiate(pond2, new Vector3((float)329.2, (float)0.1, (float)273.3), Quaternion.identity);
        pond2Spawn.transform.localScale = new Vector3((float)50, (float)1, (float)50);

        GameObject pond3Spawn = Instantiate(pond3, new Vector3((float)717.1, (float)0.1, (float)245), Quaternion.identity);
        pond3Spawn.transform.localScale = new Vector3((float)50, (float)1, (float)50);

        GameObject pond4Spawn = Instantiate(pond3, new Vector3((float)86.8, (float)0.1, (float)840.6), Quaternion.identity);
        pond4Spawn.transform.localScale = new Vector3((float)30, (float)1, (float)30);


        


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnDuck()
    {
        GameObject duckSpawn = Instantiate(duck, new Vector3(Random.Range(0, 900), 24f, Random.Range(0, 900)), Quaternion.Euler(new Vector3(0f, 0f, 0f)));
    }
}
