using UnityEngine;

public class playerCollision : MonoBehaviour
{

    public playerMovement movement;


    private void OnCollisionEnter (Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;

            FindObjectOfType<gameManager>().gameOver();
        }

        if(collisionInfo.collider.tag == "FinishLine")
        {
            movement.enabled = false;

            FindObjectOfType<gameManager>().wonGame();
        }
    }
}
