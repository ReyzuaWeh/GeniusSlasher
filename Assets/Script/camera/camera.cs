using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform user;
    public float spdCamera;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (user != null)
        {
            if (user.localScale.x > 0)
            {
                Vector3 userPosition = new Vector3(user.position.x + offset.x , user.position.y + offset.y , transform.position.z);
                transform.position = Vector3.Lerp(transform.position, userPosition, spdCamera * Time.deltaTime);
            }
            else
            {
                Vector3 userPosition = new Vector3(user.position.x - offset.x , user.position.y + offset.y , transform.position.z);
                transform.position = Vector3.Lerp(transform.position, userPosition, spdCamera * Time.deltaTime);
            }

        }
    }
}