using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowScript : MonoBehaviour
{
    public GameObject objectToFollow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Clamp(objectToFollow.transform.position.x, -20f, 20f);
        float y = Mathf.Clamp(objectToFollow.transform.position.y,-165f,165f);
        transform.position = new Vector3(x,y , -10); 
    }
}
