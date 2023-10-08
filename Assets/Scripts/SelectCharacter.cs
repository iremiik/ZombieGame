using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectCharacter : MonoBehaviour
{
    public GameObject selectCharacter;
    public GameObject mainMenu;

    public void OnBackButton()
    {
        selectCharacter.SetActive(false);
        mainMenu.SetActive(true);
    }
    public void OnCharacter1()
    {
        SceneManager.LoadScene("ZombieHell");
    }
    public void OnCharacter2()
    {
        SceneManager.LoadScene("ZombieHell2");
    }

    public void OnCharacter3()
    {
        SceneManager.LoadScene("ZombieHell3");
    }


}
