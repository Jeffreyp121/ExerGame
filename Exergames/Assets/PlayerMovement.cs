using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour, I_SmartwallInteractable
{
    public CharacterController2D controller;
    public float runSpeed =100f;
    float horizontalMove = 0f;
    bool jump = false;
    private Vector3 target;
    private Vector3 beginPos;
    private bool moving = false;


    void Update()
    {
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

        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * runSpeed);
        return true;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
        //transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * runSpeed);
        jump = false;
    }

    public void Hit(Vector3 location)
    {
        if(moving) {return;}

        target = location;
        moving = true;
    }


}



