using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManualBook : MonoBehaviour, ObjectInteractable
{
    [SerializeField] string prompt;

    public string InteractionPrompt => prompt;
    public bool Interact(CharacterInteractor interactor){
        Debug.Log("Insert Dialog Here");
        return true;
    }
}
