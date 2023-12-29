using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Duck : MonoBehaviour
{
    public string currentState;
    public float hunger;
    public float thirst;
    private float updateInterval1; // Update every 2 seconds
    public float walkInterval;
    public bool isThirsty;
    public float duration;
    public bool isRunning;
    public float speedFactor;
    public Vector3 forwardDirection;



    // Start is called before the first frame update
    void Start()
    {
        hunger = 80f;
        thirst = 20f;
        updateInterval1 = 2f;
        walkInterval = 10f;
        isThirsty = false;
        currentState = "idle";
        duration = 10f;
        isRunning = false;
        speedFactor = 10f;
        SearchState();
        StartCoroutine(WalkingState());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SearchState()
    {
        // Your code to be executed every few seconds            
        switch (currentState)
        {
            case "idle":
                    Debug.Log("searching!");
                    
                if (thirst < 50)
                {
                    currentState = "thirsty";
                }
                else if (hunger < 50)
                {
                    currentState = "hungry";
                }
                else
                {
                    currentState = "mating";
                }
                break;

            case "thirsty":
                if (thirst < 50)
                {
                    //Debug.Log("function for thirst");


                }
                break;
            case "hunger":
                if (hunger < 50)
                {
                    //Debug.Log("function for hunger");

                }
                break;
            default:
                if (hunger < 50)
                {
                    //Debug.Log("function for hunger");

                }
                break;
        }
    }

    public void Walk()
    {
        
    }

    IEnumerator WalkingState()
    {
        while (true)
        {
            // Pick a random direction
            this.transform.rotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);

            float startTime = Time.time;

            // Move in the chosen direction for the specified duration
            while (Time.time - startTime < duration)
            {
                Vector3 forwardDirection = this.transform.forward;
                forwardDirection = Quaternion.Euler(0, 65, 0) * forwardDirection;


                this.transform.position += forwardDirection * Time.deltaTime * speedFactor;
                yield return null; // wait for the next frame
            }

            // Wait for 5 seconds before changing the direction again
            yield return new WaitForSeconds(2f);
        }
    }
    public void ThirstyState()
    {

    }

}
