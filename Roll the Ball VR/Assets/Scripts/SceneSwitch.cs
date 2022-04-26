using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public bool isCorrectHole = true;
    public int nextScene;
    public float audioVolume = 0.5f;
    public AudioClip winAudio;
    public AudioClip loseAudio;
    private AudioSource audioSource;

    private void Awake()
     {
        /*
           gameObject is not destroyed instantly
           such that lose/win audio playback is not
           interrupted by scene change
        */
         DontDestroyOnLoad(transform.gameObject);
         audioSource = GetComponent<AudioSource>();
     }

    void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.tag == "PLAYER" && isCorrectHole)
        {
            // play win audio
            audioSource.PlayOneShot(winAudio, audioVolume);

            // destroy gameObject of current scene after 1s
            // to avoid audio doubling
            Destroy(transform.gameObject, 1f);

            // load next level scene
            SceneManager.LoadScene(nextScene);
        }

        if (collisionInfo.tag == "OBSTACLE"
            || collisionInfo.tag == "CAMERA"
            || PlayerBallEnteredWrongHole(collisionInfo))
        {
            // play lose audio
            audioSource.PlayOneShot(loseAudio, audioVolume);

            // destroy gameObject of current scene after 1s
            // to avoid audio doubling
            Destroy(transform.gameObject, 1f);

            // reload the current level scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    // check if the player ball entered a wrong hole
    private bool PlayerBallEnteredWrongHole(Collider collisionInfo)
    {
        return collisionInfo.tag == "PLAYER"
            && !isCorrectHole;
    }
}
