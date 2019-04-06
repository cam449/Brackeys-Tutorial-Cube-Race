using UnityEngine;
using TMPro;

public class Score : MonoBehaviour{

    public Transform player;
    public TextMeshProUGUI scoreText;
    private int finishLinePos;
    private int numColors;
    private int colorTrans; // Color transition point
    private int colInd = 0;
    private int newColInd;



    private void Start()
    {
        finishLinePos = (int) FindObjectOfType<finishLine>().transform.position.z;

        //Number of colors minus victory and loser colors
        numColors = FindObjectOfType<playerColor>().colors.Length - 2;

        colorTrans = finishLinePos / numColors;
    }

    // Update is called once per frame
    void Update()
    {
        if (!FindObjectOfType<gameManager>().gameEnded)
        {
            float scoreF = Mathf.Floor(player.position.z);
            scoreText.text = scoreF.ToString();

            //Set Player Color to Victory Color
            newColInd = (int)player.position.z / colorTrans;
            if (colInd != newColInd)
            {
                colInd = newColInd;
                FindObjectOfType<playerColor>().setPlayerColor(colInd);
            }
        }
    }
}
