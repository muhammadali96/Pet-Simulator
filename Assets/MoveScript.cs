using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoveScript : MonoBehaviour
{

    public Sprite selectedSprite;
    public Sprite deselectedSprite;

    public float speed = 0.01f;
    public Text scoreText;
    public Joystick joystick;
    private bool isPetSelected = false;

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
        if (!isPetSelected)
        {
            return;
        }
        float xinput = joystick.Horizontal;

        float yinput = joystick.Vertical;

        //transform.Translate(speed * xinput, speed * yinput, 0);
        float x = Mathf.Clamp(transform.position.x + speed * xinput, -3.3f, 3.2f);
        float y = Mathf.Clamp(transform.position.y + speed * yinput, -1.5f, 0.9f);
        transform.position = new Vector3(x, y, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            scoreText.text = "score:" + Random.Range(100, 1000);
        }
    }

}
