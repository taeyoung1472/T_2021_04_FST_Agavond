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
    public Vector3 moveDirection = Vector3.zero;
    public AudioSource[] audio;
    public bool Move;
    private bool isjump;
    //조이스틱 관련
    public Joystick joystick;
    private void Awake()
    {
        cc = GetComponent<CharacterController>();
    }
    private void Start()
    {
        StartCoroutine(Walk());
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
            if (moveDirection.x != 0 && moveDirection.z != 0)
                Move = true;
            else
            {
                Move = false;
            }
            if (isjump == true)
            {
                audio[1].Play();
                moveDirection.y = jumpSpeed;
                isjump = false;
            }
        }
        moveDirection.y -= gravity * Time.deltaTime;
        cc.Move(moveDirection * Time.deltaTime);
    }
    IEnumerator BossHit()
    {
        speed = 1;
        yield return new WaitForSeconds(2f);
        speed = basicspeed;
    }
    public void onjump()
    {
        isjump = true;
    }
    IEnumerator Walk()
    {
        while (true)
        {
            if(Move == true)
            {
                audio[0].Play();
            }
            yield return new WaitForSeconds(0.4f);
        }
    }
}