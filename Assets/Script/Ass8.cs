using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ass8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // Ex 1 
        int counter = 0;

        while (counter < 20)
        {

            int num = Random.Range(1, 20);

            Debug.Log(num);
            counter++;

            if (num == 5)
            {
                continue;
            }
            else if (num == 15) break;



        }

        //Ex 2
        int count = 0;
        string[] word = { "cat", "Dog", "Car", " Pizza", " Hat", " Fish", " Tree", " Monkey", " Ball", " Bird" };
        while (count < 7)
        {
            int ran = Random.Range(1, 8);

            Debug.Log("I love " + word[ran] );
            count++;


        }


    }


}
