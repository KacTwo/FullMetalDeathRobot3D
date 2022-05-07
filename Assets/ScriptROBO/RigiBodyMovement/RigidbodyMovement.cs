using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyMovement : MonoBehaviour
{

    private Vector3 PlayerMovementInput;
    private Vector2 MouseInput;
    private float xRot;
    [SerializeField] private Transform PlayerCamera;
    [SerializeField] private Rigidbody PlayerBody;

    [SerializeField] private float Speed;
    [SerializeField] private float Sensitivity;
    [SerializeField] private float jumpForce;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }



    void Update()
    {
        PlayerMovementInput = new Vector3 (Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        MouseInput = new Vector2 (Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        MovePlayer();
        MovePlayerCamera();
    }



    private void MovePlayer()
    {
        Vector3 MoveVector = transform.TransformDirection(PlayerMovementInput) * Speed;
        PlayerBody.velocity = new Vector3 (MoveVector.x, PlayerBody.velocity.y, MoveVector.z);




    }

    private void MovePlayerCamera()
    {

        xRot -= MouseInput.y * Sensitivity;
        
        transform.Rotate(0f, MouseInput.x * Sensitivity, 0f);

        PlayerCamera.transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);



    }









}
