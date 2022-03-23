using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoveScript : MonoBehaviour
{
    public Animator animator; 
    public Sprite selectedSprite;
    public Sprite deselectedSprite;
    public Text scoreText;
    private bool isPetSelected = false;
    private Vector3 targetPosition;
    float horizontalMove = 0f;

    void Start()
    {
        targetPosition = transform.position;
    }
    private void OnMouseDown()
    {
        GameObject[] allPets = GameObject.FindGameObjectsWithTag("Pet");

        foreach (GameObject pet in allPets)
        {
            pet.SendMessage("DeselectForMovement");

        }

        isPetSelected = true;
        ChangeToSelectedSprite();



    }

    void ChangeToSelectedSprite()
    {
        SpriteRenderer mySpriteRenderer = GetComponent<SpriteRenderer>();
        mySpriteRenderer.sprite = selectedSprite;
    }

    void ChangeToDeselectedSprite()
    {
        SpriteRenderer mySpriteRenderer = GetComponent<SpriteRenderer>();
        mySpriteRenderer.sprite = deselectedSprite;
    }

    void DeselectForMovement()
    {
        isPetSelected = false;
        ChangeToDeselectedSprite();
        
     }


    // Update is called once per frame
    void Update()
    {
        if (isPetSelected)
        {
           
            //replace touch with mouse for testing purposes
            if ( Input.GetMouseButtonDown(0)) //Input.touchCount(0) > 0
            {
            
                Vector3 touch = Input.mousePosition; //Input.GetTouch
                Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch); //touch.position

                float x = Mathf.Clamp(touchPosition.x, -3.3f, 3.2f);
                float y = Mathf.Clamp(touchPosition.y, -1.5f, 0.9f);

                Vector3 constrainedTouchPosition = new Vector3(x, y, 0);
                targetPosition = constrainedTouchPosition;

            }

        }
        

        if(targetPosition!=null)
        {
            Vector3 stepVector = 0.001f * (targetPosition - transform.position);
            if (stepVector.magnitude > 0.001f) {

            transform.position += stepVector;

            }

            horizontalMove = stepVector.x;
            animator.SetFloat("speed", Mathf.Abs(horizontalMove));
        }
        
        }


}

