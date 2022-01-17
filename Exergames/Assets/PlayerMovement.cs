using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerMovement : MonoBehaviour, I_SmartwallInteractable
{
    public CharacterController2D controller;
    public float runSpeed =100f;
    float horizontalMove = 0f;
    bool jump = false;
    private Vector3 target;
    private Vector3 beginPos;
    private bool moving = false;
    public GameObject text;

    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        beginPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        if (Input.GetMouseButtonDown(0))
        {
            target = new Vector3(mousePos.x, mousePos.y);
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
        
        Debug.Log($"begin y : { beginPos.y} begin :x {beginPos.x} target y : {target.y}  target x : {target.x}");
        if (beginPos.x == target.x && beginPos.y == target.y)
        {
            return true;
        }

        // transform.position = Vector2.MoveTowards(beginPos, target, Time.deltaTime * runSpeed);
        GameObject.FindGameObjectWithTag("Player").transform.position = target; 
        return false;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
        //transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * runSpeed);
        jump = false;
    }

    public void Hit(Vector3 location)
    {
        if(moving ) { return; }
        moving = true;
        target = location;
        /*beginPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        text.GetComponent<TMP_Text>().text = $"Begin x: {beginPos.x}  y: {beginPos.y} target: x: {target.x}  y:{target.y}";
        GameObject.FindGameObjectWithTag("Player").transform.position = location;*/



    }

}



