using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ClickableQuesionBlock : MonoBehaviour
{
    
   public TextMeshProUGUI coinText;
    private GameManager gameManager; 
    
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>(); 
    }
    private void OnMouseDown()
    {
        if (gameManager != null)
        {
            // Increment the score
            gameManager.IncrementScore();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
