using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputChek : MonoBehaviour
{
   [SerializeField] public int point;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            point += 10;


        }
    }
}
