
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UI;
using TMPro;

public class Ex_5 : MonoBehaviour
{
    //Input a year
    public TMP_InputField yearInput;
    private int year;

    //Show an image 
    public Image animalImage;
    public Sprite[] animalSprite;
    private int animalYear;

    //Give an answer
    public TextMeshProUGUI animalText;
    public string[] animalTextArray;

    void Update()
    {
        //If we use the enter key.
        if (Input.GetKeyDown("return") && yearInput.text != "")
        {
            //We convert the string in the input field to an int.
            year = int.Parse(yearInput.text);
            animalYear = year % 12;
            //We show the correct image and text
            animalImage.sprite = animalSprite[animalYear]; //Image
            animalText.text = animalTextArray[animalYear]; //Text
        }
    }
}
