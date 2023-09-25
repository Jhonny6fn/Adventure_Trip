using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPirata : MonoBehaviour
{   
    private GameObject principal;
    public float speed;
    
    void Start()
    {
        principal = GameObject.Find("Pirata");
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, principal.transform.position, speed * Time.deltaTime);
    }
}
