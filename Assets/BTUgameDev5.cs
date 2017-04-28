using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTUgameDev5 : MonoBehaviour {

   //public int a;
   // public float b = 0.6326565f;
   // public bool c = true;
   // public string d = "this is next";
   // public string nameChanger;

      //public Vector3 position;
    //public Vector3 speed;
    //public Vector3 scale;
   // public Vector3 scaleSpeed;
    public Vector3 moveSpeed;
    //public Vector3 rotSpeed;

    public Transform othertransform;





    void Start()
    {
        //  transform.name = "spere";


        //change name
        //  transform.name = nameChanger;


        //   position = transform.position;



    }
    
    void Update()
    {

        //position = position + speed;
        /// transform.position = transform.position + moveSpeed;

        // transform.localScale = transform.localScale + scale;


        //transform.localScale = transform.localScale + scaleSpeed;

        //transform.eulerAngles = transform.eulerAngles + rotSpeed;




        //moving script
        if (othertransform.position.x <= -200f)
        {
            moveSpeed = moveSpeed * -1f;
        }
        else if(othertransform.position.x >= 200f)
        {
            moveSpeed = moveSpeed * -1;
        }

        othertransform.position = othertransform.position + moveSpeed;
    }


}
