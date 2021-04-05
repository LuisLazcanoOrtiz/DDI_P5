using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       int[] nums = {4,1,2,1,2};
       int output1 = 0;

       EncontrUnicoDigi( nums,  output1);
       Debug.Log("Output : " + nums[0]);
    }

     private int[] EncontrUnicoDigi(int[] nums, int output1)
     {
          output1 = nums[0]; // Start with the first element
  for (int i = 1; i < nums.Length ; i ++){
    output1 ^= nums[i];
  }
        
        nums[0] = output1;
        return nums;
     }
    

}
