using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class MoveScript : MonoBehaviour
{
    public Animator animator; 
    //public Sprite selectedSprite;
    //public Sprite deselectedSprite;
    public Text scoreText;
    //private bool isPetSelected = false;
    private Vector3 targetPosition;
    float horizontalMove = 0f;
    bool facingRight = true;

    public float xLowerBound = -3.3f;
    public float xUpperBound = 3.2f;
    public float yLowerBound = -1.5f;
    public float yUpperBound = 0f;
    public float speed;


    void Start()
    {
        transform.position = GameData.tigerPosition;
        targetPosition = transform.position;
    }



    // Update is called once per frame
    void Update()
    {

        //This gets the target position if screen has been pressed

        //replace touch with mouse for testing purposes
        if ( Input.GetMouseButtonDown(0)) //Input.touchCount(0) > 0
        {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

            Vector3 touch = Input.mousePosition; //Input.GetTouch
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch); //touch.position

            float x = Mathf.Clamp(touchPosition.x, xLowerBound, xUpperBound);
            float y = Mathf.Clamp(touchPosition.y, yLowerBound, yUpperBound);
        
            //normalize step vector
            //when we're close to final position we stop

            //Doesn't allow player to click above y clamp
            if (y == yUpperBound)
            {
                return;
            }

            Vector3 constrainedTouchPosition = new Vector3(x, y, 0);
                
            targetPosition = constrainedTouchPosition;

        }

        if(animator.GetBool("Eating") == true | animator.GetBool("Sleeping")| animator.GetBool("Playing"))
        {
            //stop movement if doing activity
            targetPosition = transform.position;
        }

        if (targetPosition!=null)
        {

            //A constant stepVector is defined so the pet moves at a constant speed
            //until it is close to it's destination at which point the stepVector becomes 0
            
            Vector3 stepVector = speed*Vector3.Normalize(targetPosition - transform.position);

            if((targetPosition - transform.position).magnitude < speed)
            {
                stepVector = new Vector3(0, 0, 0);
            }
            
            //Adds stepVector to pet position           
            transform.position += stepVector;
            GameData.tigerPosition += stepVector;

            //The horizontal 'speed' of the pet determines the animation transition
            //switching from idle to walk and vice versa when the pet is above and below a
            //specific speed
            horizontalMove = stepVector.x;
            animator.SetFloat("speed", Mathf.Abs(horizontalMove));
            

            //Face the direction pet is walking
            if (stepVector.x > 0 && !facingRight)
            {
                Flip();
            }

            if (stepVector.x < 0 && facingRight)
            {
                Flip();
            }
        }
        
        }

    void Flip ()
    {
        Vector3 currentScale = gameObject.transform.localScale;

        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facingRight = !facingRight;
    }


}

