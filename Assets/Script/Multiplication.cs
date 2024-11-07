using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiplication : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int Multiply(int num1,int num2)
        {
            int multi = num1 * num2;
            return multi;
        }

        for (int n = 1; n < 11; n++)
        {
            int sum = Multiply(5,n);
            Debug.Log("5" + " * " + n + " = " + sum);
            //Debug.Log("5" + " x " + n + " = " + sum);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
