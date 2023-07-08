using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveHandUI : MonoBehaviour
{
    public GameObject GuiElement;
    // This method is called when another collider enters the trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Activate the desired GameObject
        GuiElement.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        // Deactivate the desired GameObject
        GuiElement.SetActive(false);
    }
}
