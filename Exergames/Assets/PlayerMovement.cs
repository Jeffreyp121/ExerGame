using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed =100f;
    float horizontalMove = 0f;
    bool jump = false;
    private Vector2 target;
    private Vector2 beginPos;
    private bool moving = false;


    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(Input.GetMouseButtonDown(0))
        {
            target = new Vector2(mousePos.x, mousePos.y);
            moving = true;
        }

        if (moving)
        {
            moving = MovingToTouch();
        }
       
      
        
        /*horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }*/
    }
    bool MovingToTouch()
    {
        beginPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        Debug.Log($"begin y : { beginPos.y} begin :x {beginPos.x} target y : {target.y}  target x : {target.x}");
        if (beginPos.x == target.x && beginPos.y == target.y)
        {
            return false;
        }

        transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * runSpeed);
        return true;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
        //transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * runSpeed);
        jump = false;
    }


}



