using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    public override void EatSomething()
    {
        // INHERITANCE
        PopText.text = "Dog eats bone.";
        Pop.SetActive(true);
    }
}
