using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    public override void EatSomething()
    {
        // INHERITANCE
        PopText.text = "Cat eats fish.";
        Pop.SetActive(true);
    }
}
