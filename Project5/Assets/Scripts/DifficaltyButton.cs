using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DifficaltyButton : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;
    public float difficalty;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficalty);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetDifficalty()
    {
        Debug.Log(button.gameObject.name + " was clicked");
        gameManager.StartGame(difficalty);
    }
}