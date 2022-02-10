using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectLongClickPet1 : MonoBehaviour
{
    private float startTime, endTime;
    // Start is called before the first frame update
    void Start()
    {
        startTime = 0f;
        endTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            startTime = Time.time;

        if (Input.GetMouseButtonUp(0))
            endTime = Time.time;

        if (endTime - startTime > 0.5f)
        {
            SceneManager.LoadScene("Close Up Scene");
            startTime = 0f;
            endTime = 0f;
        }

    }


    //private void OnMouseDown()
    //{
    //    Debug.Log("clicked");
    //    SceneManager.LoadScene("PetDescription");
    //}
}
