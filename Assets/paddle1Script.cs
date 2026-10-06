using UnityEngine;

public class paddle1Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private static float moveSpeed = 5.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S)) {
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
        }
    }
}
