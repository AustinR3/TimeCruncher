using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update

public GameObject[] playerPrefabs;
int characterIndex;

private void Awake()
{
    characterIndex = PlayerPrefs.GetInt("SelectedCharacter", 0);
    Instantiate(playerPrefabs[characterIndex]);



}








}
