using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ex_4 : MonoBehaviour
{
    public TextMeshProUGUI turnText;
    private int currentTurn = 10;
    private int guessNumber;

    private int randomNumber;
    public GameObject[] randomGuess;

    //Check if the player can click the options.
    private bool canClick = true; 

    //Counters at the true and false answer.
    private int counterTrue;
    private int counterFalse;

    //Final stage.
    public TextMeshProUGUI correctCounterText;
    public TextMeshProUGUI incorrectCounterText;
    

    //Button function.
    public void OptionButton(int number)
    {
        if (currentTurn > 0 && canClick)
        {
            guessNumber = number; 
            currentTurn--;
            turnText.text = currentTurn.ToString();
            StartCoroutine(RandomOption());
        }
    }

    //To randomize an answer.
    private IEnumerator RandomOption()
    {
        canClick = false;
        yield return new WaitForSeconds(1f); 
        randomNumber = Random.Range(0, 2); //Random number beetwen 0 and 1.

        //When we guess an answer add a ponit in the true counter.
        if (randomNumber == guessNumber)
        {
            counterTrue++;
        }
        //When we don't guess the answer add a ponit in the false counter.
        else
        {
           counterFalse++;
        }

        //once the turns are finished, our result is shown and we can play again.
        if (currentTurn == 0)
        {
            //It shows the final answer before displaying the results.
            yield return new WaitForSeconds(1f); 
            correctCounterText.gameObject.SetActive(true);
            incorrectCounterText.gameObject.SetActive(true);
            correctCounterText.text = $"You have guess {counterTrue} answers correctly";
            incorrectCounterText.text = $"You have guess {counterFalse} answers incorrectly";
        }

        canClick = true;
    }

}