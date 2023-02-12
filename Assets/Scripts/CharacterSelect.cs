using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{

    public GameObject[] skins;
    public int selectedCharacter;
    private void Awake() 
    
    {
        
    selectedCharacter = PlayerPrefs.GetInt("SelectedCharacter", 0);
    foreach(GameObject player in skins)
        player.SetActive(false);

    skins[selectedCharacter].SetActive(true);

    }

    public void ChangeNext()

    {
        skins[selectedCharacter].SetActive(false);
        selectedCharacter++;
        // if we add more characters change this number 3. 
        if(selectedCharacter == skins.Length)
        selectedCharacter = 0;

        skins[selectedCharacter].SetActive(true);
        PlayerPrefs.SetInt("SelectedCharacter", selectedCharacter);
    }



        public void ChangePrevious()

    {
        skins[selectedCharacter].SetActive(false);
        selectedCharacter--;
        // if we add more characters change this number 3. 
        if(selectedCharacter == -1)
        selectedCharacter = skins.Length -1;

        skins[selectedCharacter].SetActive(true);
        PlayerPrefs.SetInt("SelectedCharacter", selectedCharacter);
    }



}
