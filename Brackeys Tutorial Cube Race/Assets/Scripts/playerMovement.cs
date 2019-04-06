using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float jumpForce = 800f;
    public Vector3 jumpExplOffset;

    // Update is called once per frame
    void FixedUpdate() {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w") && Mathf.Floor(rb.transform.position.y * 100) / 100 == 1)
        {
            Debug.Log("BOOM!");
            rb.AddExplosionForce(jumpForce * Time.deltaTime, rb.transform.position - jumpExplOffset, 1.5f);
        }

        if (rb.position.y < 0)
        {
            FindObjectOfType<gameManager>().gameOver();
        }
        
    }
}
