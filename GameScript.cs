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

    enum States { Car0, Car1, Car2, Car3, Town0, Phone0, Address0, Resident0, Phone1, Sleep0, Outside0, Uncle0, Exit0, Woman0, Aunt0, Motel0, Town1, Friend0, Bar0, Sleep1, Outside1, Family0, Family1, Sleep2, Outside2, Bar1, You0, Liar0, Sorry0, Run0,
    run1, run2, };
    States myState;

    // Start is called before the first frame update
    void Awake()
    {
        myState = States.Car0;
    }

    // Update is called once per frame
    void Update()
    {
        if (myState == States.Car0)
        {
            car0();
        }
        else if (myState == States.Car1)
        {
            car1();
        }
        else if (myState == States.Car2)
        {
            car2();
        }
        else if (myState == States.Car3)
        {
            car3();
        }
        else if (myState == States.Town0)
        {
            town0();
        }
        else if (myState == States.Phone0)
        {
            phone0();
        }
        else if (myState == States.Address0)
        {
            address0();
        }
        else if (myState == States.Resident0)
        {
            resident0();
        }
        else if (myState == States.Phone1)
        {
            phone1();
        }
        else if (myState == States.)
        {
            ();
        }
        else if (myState == States.)
        {
            ();
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
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            myState = States.Car2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            myState = States.Car3;
        }
    }
    void car1()
    {
        storyText.SetText("you hang up on your sister angrily and keep driving down the road. 'waste of a spring break' you mumble, mocking her.");

        choiceText.SetText("Press 1 to try calling your aunt and uncle again while driving / Press 2 to fast forward to arrival");

        GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            myState = States.Town0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            myState = States.Car2;
        }
    }
    void car2()
    {
        storyText.SetText("you call them, and they still don't pick up. even though you have every reason not to, you still feel this weird inclination to visit them. so nevertheless, you reluctantly continue driving.");

        choiceText.SetText("Press 1 to fast forward to arrival");

        GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            myState = States.Town0;
        }
      
    }
    void car3()
    {
        storyText.SetText("you hang up and turn your car around, when suddenly your aunt calls you. you immediately pick up, and hear silence for a few seconds. 
\'uh hello? Andy DON\'T-\' she says, followed by the call ending immediately.you sit in silence for a moment, confused, as you make a decision.despite what your sister tells you, you decide to turn around, again, and go back on the path to your aunt's and uncle's house.");

        choiceText.SetText("Press 1 to try calling your aunt and uncle again while driving / Press 2 to fast forward to arrival");

        GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            myState = States.Town0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            myState = States.Car2;
        }
    }
}
