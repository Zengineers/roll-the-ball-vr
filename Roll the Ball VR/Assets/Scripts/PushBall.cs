using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBall : MonoBehaviour
{
    public float pushMagnitude;
    public float audioVolume = 0.5f;
    public Transform vrCamera;
    public AudioClip pushAudio;
    private AudioSource audioSource;
    private Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    public void Push()
    {
        // play push audio
        audioSource.PlayOneShot(pushAudio, audioVolume);

        // apply push force to the ball from the camera forward direction
        Vector3 force = new Vector3(vrCamera.forward.x, 0, vrCamera.forward.z).normalized;
        rigidbody.AddForce(force * pushMagnitude);

        Debug.Log("Ball pushed with vector direction: " + vrCamera.forward);

    }
}
