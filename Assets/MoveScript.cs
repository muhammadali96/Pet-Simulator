using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveScript : MonoBehaviour
{
    public float speed = 0.01f;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xinput = Input.GetAxis("Horizontal");

        float yinput = Input.GetAxis("Vertical");

        //transform.Translate(speed * xinput, speed * yinput, 0);
        float x = Mathf.Clamp(transform.position.x + speed * xinput, -6f,6f);
        float y = Mathf.Clamp(transform.position.y + speed * yinput, -3f,1.5f);
        transform.position = new Vector3(x, y, 0);

        if(Input.GetKeyDown(KeyCode.Space)) {
            scoreText.text = "score:" + Random.Range(100,1000);
        }
    }
   
}
