using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;
public class GameScript : MonoBehaviour
{
    public TMP_Text storyText;
    public TMP_Text choiceText;
    public Sprite[] imageArray;

    enum States {Car0, Car1, Car2, Car3 };
    States myState;

    // Start is called before the first frame update
    void Awake()
    {
        myState = States.Car0;
    }

    // Update is called once per frame
    void Update()
    {
        if(myState == States.Car0)
        {
            car0();
        }else if(myState == States.Car1)
        {
           
        }
    }

    void car0()
    {
        storyText.SetText("'I have no clue why they aren't returning any of my calls' you say, annoyed." + 
"'Well I have no clue why you decided to go meet them in the first place Andy, we barely talk to them.'" + 
"your sister says, nagging at you through the phone." +
"You're calling her while currently in the middle of a road trip that's expected to last 13 hours, all to meet your " +
"aunt and uncle who you've never met before. In fact, you've only ever seen one photo of them, and its from the early 80's." +
"'I just wanted to give them a chance,' you say back to her, starting to think you shouldn't have even started this trip in" +
" the first place. 'I don't know Andy, this just seems like a waste of a good spring break.' she replies.");

        choiceText.SetText("Press 1 to Hang Up / Press 2 to Turn Around / Press 3 to Call Aunt");

        GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            myState = States.Car1;
        }else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            myState = States.Car2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            myState = States.Car3;
        }
    }
}
