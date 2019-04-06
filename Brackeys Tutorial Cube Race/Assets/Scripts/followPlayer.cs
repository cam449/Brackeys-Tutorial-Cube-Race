using UnityEngine;

public class followPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;
    public Vector3 camRetreat;

    // Update is called once per frame
    void Update()
    {
        if (!FindObjectOfType<gameManager>().gameEnded)
        {
            transform.position = player.position + offset;
        }

        if (FindObjectOfType<gameManager>().gameEnded)
        {
            transform.position = transform.position + camRetreat * Time.deltaTime;
            Debug.Log("Cam backing away");
        }
    }
}
