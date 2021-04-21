using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGuesser : MonoBehaviour
{
    int chotaNum;
    int badaNum;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        chotaNum = 1;
        badaNum = 500;
        guess = 250;

        Debug.Log("Namaste, Swagat hai Number Guessing Game me");
        Debug.Log("Hosted by Danish");
        Debug.Log("Think of an number between 1 t o 500");
        Debug.Log("Lowest Number be:" + chotaNum);
        Debug.Log("Highest Number be:" + badaNum);
        Debug.Log("Batao, if your guess is lower or greater than" + guess);

        Debug.Log("Arrow up = High, Arrow Down = Low, Enter = Correct");

        badaNum = badaNum + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Debug.Log("Up Arrow is pressed");
            chotaNum = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //Debug.Log("Down Arrow is pressed");
            badaNum = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Yay! I guessed it right");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (badaNum + chotaNum) / 2;
        Debug.Log("Is your guess lower or greater than" + guess);
    }
}
