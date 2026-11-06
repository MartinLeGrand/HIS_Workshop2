using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Behaviour : MonoBehaviour
{
    [SerializeField] private float launchForce = 10f;
    [SerializeField] private float upForce = 10f;
    [SerializeField] private float forwardForce = 10f;
    [SerializeField] private float forwardRotation = 1f;
    
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Camera playerCamera;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip jumpSound;
    
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jump");
            
            rb.AddForce((transform.up * upForce + playerCamera.transform.forward * forwardForce) * launchForce, ForceMode.VelocityChange);
            
            rb.AddTorque(playerCamera.transform.right * forwardRotation, ForceMode.VelocityChange);
            
            audioSource.PlayOneShot(jumpSound);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
