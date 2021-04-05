using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       int[] nums = {12, 345, 2, 6, 7896};
       int output1 = 0;
       
       ParDeDigitos( nums,  output1);
       Debug.Log("Output : " + nums[0]);

    }
    
     private int[] ParDeDigitos(int[] nums, int output1)
    {
       int n =0;
       int Buspar = 0;
       int odd_count = 0;
       

      for(int i = 0; i <= nums.Length - 1; i++)
     {
   
    n = nums[i];

    Buspar = 0;
    odd_count = 0;
    while (n > 0) {
        int rem = n % 10;
        if (rem % 2 == 0)
            Buspar++;
        else
            odd_count++;
        n = n / 10;
    }
     
     if (Buspar != 0 && odd_count == 0)
     output1++;

    }
     
     nums[0] = output1;

     return nums;
    }
    
}
