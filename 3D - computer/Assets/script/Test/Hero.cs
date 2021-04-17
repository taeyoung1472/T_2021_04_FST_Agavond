using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hero : MonoBehaviour
{
    [SerializeField]
    CharacterController cc;
    public float basicspeed;
    public float speed = 3.0F;
    public float runspeed;
    public float jumpSpeed = 4.0F;
    public float gravity = 9.81F;
    private Vector3 moveDirection = Vector3.zero;
    public float X;
    public float Z;
    private bool Move;
    private void Awake()
    {
        cc = GetComponent<CharacterController>();
    }
    private void Start()
    {
        basicspeed = speed;
    }
    void Update ()
    {
        if (Move == true)
        {
            Debug.Log("움직이는중");
        }
        else
        {
            X = 0;
            Z = 0;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = runspeed;
        }
        else
        {
            speed = basicspeed;
        }
        if (cc.isGrounded)
        {
            moveDirection = new Vector3(X, 0, Z);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        cc.Move(moveDirection * Time.deltaTime);
    }
    /*public void Move(float X,float Y)
    {
        moveDirection = new Vector3(X, 0, Y);
        cur.text = string.Format("{0}", X);
        cur2.text = string.Format("{0}", Y);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;
        cur3.text = string.Format("{0}", moveDirection);
        cur4.text = string.Format("{0}", speed);
        if (Input.GetButton("Jump"))
            moveDirection.y = jumpSpeed;
    }*/
    public void Foward()
    {
        Move = true;
        Z = 1;
    }
    public void stop()
    {
        Move = false;
    }
    public void Left()
    {
        Move = true;
        X = -1;
    }
    public void Back()
    {
        Move = true;
        Z = -1;
    }
    public void Right()
    {
        Move = true;
        X = 1;
    }
}

