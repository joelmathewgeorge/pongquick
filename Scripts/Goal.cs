using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isLeftGoal;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            if (isLeftGoal) GameManager.Instance.ScoreRight();
            else GameManager.Instance.ScoreLeft();
        }
    }
}
