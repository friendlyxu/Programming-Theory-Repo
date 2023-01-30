using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Animal : MonoBehaviour
{
    // ENCAPSULATION
    [SerializeField] protected GameObject Pop;
    [SerializeField] protected TextMeshProUGUI PopText;
    // ABSTRACTION
    // POLYMORPHISM
    public abstract void EatSomething();

}
