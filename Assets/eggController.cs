using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class eggController : MonoBehaviour
{

    public GameObject[] egg = new GameObject[9];

    public int waitTime;

    public float delay;
    private float ratio = 0;
    

    private Vector3 endposition;
    private Vector3 startposition;

    private  float timer = 0.0f;
    
    private int previousEgg;

    private int rand;

    private  bool riseFlag;


    // Start is called before the first frame update
    void Start()
    {

        riseFlag = false;
        previousEgg = 4;

    }

    // Update is called once per frame
    void Update()
    {   
        // none of the egg pops
        if(riseFlag == false)
        {
            do
            {
                rand = Random.Range(0, 9); // choose random egg, except latest

            } while (previousEgg == rand);

            previousEgg = rand;

            endposition = startposition = egg[rand].transform.position;
            endposition.y = 0.094f;

            float multiplier = 1 / delay;

            while (egg[rand].transform.position != endposition)
            {

                ratio += Time.deltaTime * multiplier;

                egg[rand].transform.position = Vector3.Lerp(egg[rand].transform.position, endposition, ratio);

            } 

            riseFlag = true;

        }

        else
        {

            timer += Time.deltaTime;

            if (timer > waitTime) // poping duration
            {

                endposition.y = 0.0f;
                egg[rand].transform.position = Vector3.Lerp(egg[rand].transform.position, endposition, 1);
                timer = 0;

                riseFlag = false;

            }

        }

    }

}
