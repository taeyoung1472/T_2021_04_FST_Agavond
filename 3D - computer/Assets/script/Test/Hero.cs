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
    private bool Move;
    //조이스틱 관련
    public Joystick joystick;
    private void Awake()
    {
        cc = GetComponent<CharacterController>();
    }
    private void Start()
    {
        basicspeed = speed;
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Boss")
        {
            StartCoroutine(BossHit());
        }
    }
    void Update ()
    {
        if (cc.isGrounded)
        {
            moveDirection = new Vector3(joystick.Horizontal, 0, joystick.Vertical);
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
    /*public void Foward()
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
    }*/
    IEnumerator BossHit()
    {
        speed = 1;
        yield return new WaitForSeconds(2f);
        speed = basicspeed;
    }
}

