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
    public Text cur;
    public Text cur2;
    public Text cur3;
    public Text cur4;
    private void Start()
    {
        basicspeed = speed;
    }
    void Update ()
    {
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
            /*moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;*/
            Move(0,0);
        }
        moveDirection.y -= gravity * Time.deltaTime;
        cc.Move(moveDirection * Time.deltaTime);
    }
    public void Move(float X,float Y)
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
    }
}

