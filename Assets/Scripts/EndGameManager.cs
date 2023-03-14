using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndGameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI whoWonText;

    private void Start()
    {
        if (GameManager.scorePlayer == 5)
            whoWonText.text = "You won!";
        else if (GameManager.scoreComputer == 5)
        {
            whoWonText.text = "You lost!";
        }
    }

    public void startNewGame()
    {
        SceneManager.LoadScene("GameScreen");
    }


}
