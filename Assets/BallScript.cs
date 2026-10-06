using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] float movespeed = 5.0f;
    private float MaxOrMinXPos = 9.0f;
    private float xPos;
    private float yPos;
    private int player1Score;
    private int player2Score;
    Rigidbody2D rb;

    public TextMeshProUGUI player1ScoreText;
    public TextMeshProUGUI player2ScoreText;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        launch();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -MaxOrMinXPos)
        {
            player2Score++;
            player2ScoreText.text = player2Score.ToString("0");
            transform.position = Vector3.zero;
            rb.linearVelocity = Vector3.zero;
            launch();
        }
        else if (transform.position.x >= MaxOrMinXPos)
        {
            player1Score++;
            player1ScoreText.text = player1Score.ToString("0");
            transform.position = Vector3.zero;
            rb.linearVelocity = Vector3.zero;
            launch();
        }
    }

    public void launch() {
        float[] integerValues = { -1f, 1f };
        xPos = integerValues[Random.Range(0, integerValues.Length)];
        yPos = 0f;
        rb.linearVelocity = new Vector3(xPos * movespeed, yPos * movespeed);

    }
}