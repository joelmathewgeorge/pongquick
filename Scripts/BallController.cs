using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb;
    private AudioSource audioSource;

    public AudioClip paddleHitSound;
    public AudioClip wallHitSound;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Paddle"))
            audioSource.PlayOneShot(paddleHitSound);
        else if(collision.gameObject.CompareTag("Wall"))
            audioSource.PlayOneShot(wallHitSound);
    }
}
