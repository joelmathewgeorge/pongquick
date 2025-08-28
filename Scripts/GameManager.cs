using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TextMeshProUGUI leftScoreText;
    public TextMeshProUGUI rightScoreText;

    public Rigidbody2D ballRb;
    public float ballSpeed = 5f;

    public AudioClip scoreSound;
    private AudioSource audioSource;

    private int leftScore = 0;
    private int rightScore = 0;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        ResetBall();
    }

    public void ScoreLeft()
    {
        leftScore++;
        leftScoreText.text = leftScore.ToString();
        if(audioSource != null) audioSource.PlayOneShot(scoreSound);
        ResetBall();
    }

    public void ScoreRight()
    {
        rightScore++;
        rightScoreText.text = rightScore.ToString();
        if(audioSource != null) audioSource.PlayOneShot(scoreSound);
        ResetBall();
    }

    void ResetBall()
    {
        ballRb.linearVelocity = Vector2.zero;
        ballRb.position = Vector2.zero;

        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(-1f, 1f);

        Vector2 dir = new Vector2(x, y).normalized;
        ballRb.linearVelocity = dir * ballSpeed;
    }
}
