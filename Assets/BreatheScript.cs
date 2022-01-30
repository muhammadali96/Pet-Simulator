using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreatheScript : MonoBehaviour
{
    public LineRenderer circleRenderer;
    // Start is called before the first frame update
    void Start()
    {
        //DrawCircle(1000, 3);
    }

    // Update is called once per frame
    void Update()
    {
        //Repeatedly draw a circle
        //radius of the circle must increase and decrease (use sinusoid?) ranging from 2-4

        float radius = 3 + Mathf.Sin(Time.time);
        DrawCircle(1000, radius);
        
    }

    //using polar coordinates draw a circle
    void DrawCircle(int steps, float radius)
    {
        circleRenderer.positionCount = steps;
        //steps is the number of minilines that make up the entire circle

        for(int currentStep = 0; currentStep<steps; currentStep++)
        {
            //what percentage of the circle have we made it around
            float circumferenceProgress = (float)currentStep / steps;


            //An entire circle is 2pi radians so multiply by progress to get current radian
            float currentRadian = circumferenceProgress * 2 * Mathf.PI;

            //using polar coordinates

            float x = radius * Mathf.Cos(currentRadian);
            float y = radius * Mathf.Sin(currentRadian);

            //Now create the vector to draw the circle

            Vector3 currentPosition = new Vector3(x, y, 0);

            circleRenderer.SetPosition(currentStep, currentPosition);
        }
    }
}
