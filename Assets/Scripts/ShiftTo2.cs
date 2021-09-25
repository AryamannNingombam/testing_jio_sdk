using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ShiftTo2 : MonoBehaviour
{
 

 
    public void ChangeScene2()
    {
        print("Clicked");
        SceneManager.LoadScene("Scene2");

    }
}
