using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Ball : MonoBehaviour
{
    public AudioClip rightPaddleCollision;
    public AudioClip leftPaddleCollision;

    AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("rightPaddle"))
        {
            audioSource.PlayOneShot(rightPaddleCollision);
        }
        if (collision.gameObject.CompareTag("leftPaddle"))
        {
            audioSource.PlayOneShot(leftPaddleCollision);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("redCube"))
        {
            // Debug.Log("Hit!");
            this.transform.localScale = new Vector3(2f, 2f, 2f);
            collider.gameObject.SetActive(false);
        }
        if (collider.gameObject.CompareTag("blueCube"))
        {
            // Debug.Log("Hit!");
            this.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            collider.gameObject.SetActive(false);
        }
    }
}
