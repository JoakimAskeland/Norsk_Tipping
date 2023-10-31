using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private TextMeshPro ButtonText;

    public void GoToLotteriScreen()
    {
        //Load scene takes in the exact name and jmps to that.
        SceneManager.LoadScene("Lotteri");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
