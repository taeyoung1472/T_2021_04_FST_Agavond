using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Move : MonoBehaviour
{
    //public Vector3 speedvec;
    public float moveSpeed = 5.0f;
    private Vector3 moveDirection;

    public CharacterController characterController;
    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
        {
            MoveTo(moveDirection);
        }
    }
    public void MoveTo(Vector3 direction)
    {
        moveDirection = new Vector3(direction.x, direction.y, direction.z);
    }
}
