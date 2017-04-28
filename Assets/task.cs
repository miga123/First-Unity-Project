using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task : MonoBehaviour {

    int frameCounter = 0;
    int frameDirection = 1;
    void Update()
    {
        //frameCounter = frameCounter = 1;

        // Debug.Log(Time.time);

        //if (0 == frameCounter % 2)
        //  Debug.Log(frameCounter);

        float fps = frameCounter / Time.time;
        //Debug.Log(Time.time);

        if (frameCounter == 100)
        {
            //  frameCounter = (frameCounter - 100);
            frameDirection = -1;
        }
        else if (frameCounter == 0)
        {
            frameCounter = 1;
        }
        frameCounter = frameCounter + frameDirection;

        Debug.Log(frameCounter);
    }
}
