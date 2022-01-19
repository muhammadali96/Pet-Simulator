using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveScript : MonoBehaviour
{
    public Text scoreText;
    private bool isPetSelected = false;


    private void OnMouseDown()
    {
        GameObject[] allPets = GameObject.FindGameObjectsWithTag("Pet");

        foreach (GameObject pet in allPets)
        {
            pet.SendMessage("DeselectForMovement");
        }

        isPetSelected = true;


    }
    void DeselectForMovement()
    {
        isPetSelected = false;
    }

    IEnumerator LerpPosition(Vector2 touchPosition, float duration)
    {
        float time = 0;
        Vector2 startPosition = transform.position;

        while (time < duration)
        {
            transform.position = Vector2.Lerp(startPosition, touchPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = touchPosition;
        Debug.Log(duration);
    }


    // Update is called once per frame
    void Update()
    {
        if (!isPetSelected)
        {
            return;
        }
        

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            //touchPosition.z = 0f;

            float x = Mathf.Clamp(touchPosition.x, -3.3f, 3.2f);
            float y = Mathf.Clamp(touchPosition.y, -1.5f, 0.9f);

            Vector3 constrainedTouchPosition = new Vector3(x, y, 0);

            StartCoroutine(LerpPosition(constrainedTouchPosition, 3));
        }




        
        //float xinput = joystick.Horizontal;

        //float yinput = joystick.Vertical;

        ////transform.Translate(speed * xinput, speed * yinput, 0);
        //float x = Mathf.Clamp(transform.position.x + speed * xinput, -3.3f, 3.2f);
        //float y = Mathf.Clamp(transform.position.y + speed * yinput, -1.5f, 0.9f);
        //transform.position = new Vector3(x, y, 0);
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    scoreText.text = "score:" + Random.Range(100, 1000);
        //}
    }
   

}

