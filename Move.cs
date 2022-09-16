using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float forceValue;
    public float jumpValue;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < .1f)
            rb.AddForce(Vector3.up * jumpValue, ForceMode.Impulse);
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(Input.GetAxis("Horizontal"),
                                0,
                                Input.GetAxis("Vertical")) * forceValue);
    }

}
