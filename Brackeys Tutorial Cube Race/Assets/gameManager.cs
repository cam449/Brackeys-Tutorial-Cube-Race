using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public bool gameEnded = false;
    public GameObject light1;
    public GameObject light2;
    public GameObject particle1;
    public GameObject particle2;
    public GameObject loserText;
    public GameObject winText;

    public void gameOver()
    {
        if (!gameEnded)
        {
            Debug.Log("GAME OVER");
            gameEnded = true;
            loserText.SetActive(true);

            //Set Player Color to Loser Color
            FindObjectOfType<playerColor>().setPlayerColor(FindObjectOfType<playerColor>().colors.Length - 1);

            Invoke("openMenu", 3f);
        }
    }

    public void wonGame()
    {
        Debug.Log("Way to go champ!");
        gameEnded = true;   

        //Special Effects
        light1.SetActive(true);
        light2.SetActive(true);
        particle1.SetActive(true);
        particle2.SetActive(true);
        winText.SetActive(true);

        //Set Player Color to Victory Color
        FindObjectOfType<playerColor>().setPlayerColor(FindObjectOfType<playerColor>().colors.Length - 2);

        Invoke("openMenu", 5f);
    }

    private void openMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
