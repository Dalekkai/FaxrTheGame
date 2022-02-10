using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThirdLvlLoader : MonoBehaviour
{

        private void OnTriggerEnter(Collider other) //Loads the second Scene when entered.
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex +2);
    }

}
