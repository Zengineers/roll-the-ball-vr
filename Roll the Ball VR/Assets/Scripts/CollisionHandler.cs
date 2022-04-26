using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public int bounceMagnitude;
    public float audioVolume = 0.5f;
    public AudioClip collisionAudio;
    private AudioSource audioSource;
    private Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "WALL"
            || collisionInfo.collider.tag == "OBSTACLE")
        {
            // play collision audio
            audioSource.PlayOneShot(collisionAudio, audioVolume);

            // get the angle between the collision point and the spawn object position
            Vector3 Direction = collisionInfo.contacts[0].point - transform.position;

            // reverse and normalize the vector
            Direction = -Direction.normalized;

            // apply force to the reversed direction multiplied by magnitude
            rigidbody.AddForce(Direction * bounceMagnitude);

            Debug.Log("Hit a wall");
        }
    }
}
