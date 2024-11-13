using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI TextMeshProUGUI;
    void Update()
    {
        GameObject [] Bricks= GameObject.FindGameObjectsWithTag("brick-o");
        int countBricks = Bricks.Length;
        string count = countBricks.ToString();
        TextMeshProUGUI.text = count;

        if (countBricks <= 0 ){

            
        TextMeshProUGUI.text = " ¡Lo Rompiste Todo!";
        SceneLoader();

        }
    }
    void SceneLoader(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
