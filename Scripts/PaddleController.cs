using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed = 10f;
    public string upKey;
    public string downKey;

    private Rigidbody2D rb;
    private float yLimit = 4.2f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float move = 0f;
        if (Input.GetKey(upKey)) move = 1f;
        else if (Input.GetKey(downKey)) move = -1f;

        Vector2 newPos = rb.position + new Vector2(0, move * speed * Time.deltaTime);
        newPos.y = Mathf.Clamp(newPos.y, -yLimit, yLimit);
        rb.MovePosition(newPos);
    }
}
