using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string inputID;
    public GameObject vehicle;
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }

    void FixedUpdate()
    {
        forwardInput = Input.GetAxis("Vertical" + inputID);
        horizontalInput = Input.GetAxis("Horizontal" + inputID);

        // Moves the car forward based on vertical input
        vehicle.transform.Translate(Vector3.forward * Time.fixedDeltaTime * speed * forwardInput);

        // Rotates the car based on horizontal input
        vehicle.transform.Rotate(Vector3.up, turnSpeed * Time.fixedDeltaTime * horizontalInput);
    }
}
