using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    
    private float mouseSensitivity = 1000f;
    private float xRotation = 0f;
    public Transform playerBody;



    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
        float mouseX = Input.GetAxis("Mouse X")*mouseSensitivity*Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y")*mouseSensitivity*Time.deltaTime;
        playerBody.Rotate(Vector3.up * mouseX);
        xRotation -= mouseY;
        xRotation=Mathf.Clamp(xRotation, -70f, 70f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

    }
}
