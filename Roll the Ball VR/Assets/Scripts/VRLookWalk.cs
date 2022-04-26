using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLookWalk : MonoBehaviour
{
    public Transform vrCamera;
    public float minToggleAngle = 30.0f;
    public float maxToggleAngle = 90.0f;
    public float speed = 3.0f;
    public bool moveForward;

    private CharacterController charController;
    private AudioSource walkAudio;

    void Start()
    {
        charController = GetComponent<CharacterController>();
        walkAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        // if the camera direction is within the specified angles
        if (vrCamera.eulerAngles.x >= minToggleAngle && vrCamera.eulerAngles.x < maxToggleAngle)
        {
            moveForward = true;

            // play walking audio
            if(!walkAudio.isPlaying)
            {
                walkAudio.Play();
            }
        }
        else
        {
            moveForward = false;
            walkAudio.Stop();
        }

        // apply forward movement to the camera rig
        if (moveForward)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
            charController.SimpleMove(forward * speed);
        }
    }
}
