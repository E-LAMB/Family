using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    float movement;
    public KeyCode key_jump;
    public KeyCode key_left;
    public KeyCode key_right;

    public GameObject ground_detector;
    public LayerMask ground_mask;

    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key_left)) { movement = -1f; }
        if (Input.GetKeyDown(key_right)) { movement = 1f; }

        if (Input.GetKeyUp(key_left) && movement == -1f) { movement = 0f; }
        if (Input.GetKeyUp(key_right) && movement == 1f) { movement = 0f; }

        rb.velocity = new Vector2(movement * 4f, rb.velocity.y);

        if (Input.GetKeyDown(key_jump) && Physics2D.OverlapCircle(ground_detector.transform.position, 0.2f, ground_mask)) { rb.AddForce(new Vector2(0f, 350f)); }

    }
}
