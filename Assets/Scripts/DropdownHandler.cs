using UnityEngine;
using UnityEngine.UI;

public class DropdownHandler : MonoBehaviour
{
    public GameObject Soilmodels; // Reference to the GameObject hierarchy that contains the game objects to enable/disable
    public GameObject Soilnames; // Reference to the GameObject hierarchy that contains the game objects to enable/disable
    public Dropdown dropdown; // Reference to the Dropdown component

    private void Start()
    {
        dropdown.onValueChanged.AddListener(delegate { OnDropdownValueChanged(dropdown); });
    }

    public void OnDropdownValueChanged(Dropdown dropdown)
    {
        // Get the index of the selected option in the dropdown
        int selectedIndex = dropdown.value;

        // Loop through all child game objects of the gameObjectsToToggle hierarchy
        foreach (Transform child in Soilmodels.transform)
        {
            // If the child's name matches the selected option in the dropdown, enable it. Otherwise, disable it.
            if (child.name == dropdown.options[selectedIndex].text)
            {
                child.gameObject.SetActive(true);
            }
            else
            {
                child.gameObject.SetActive(false);
            }
        }

         foreach (Transform child in Soilnames.transform)
        {
            // If the child's name matches the selected option in the dropdown, enable it. Otherwise, disable it.
            if (child.name == dropdown.options[selectedIndex].text)
            {
                child.gameObject.SetActive(true);
            }
            else
            {
                child.gameObject.SetActive(false);
            }
        }
    }
}

