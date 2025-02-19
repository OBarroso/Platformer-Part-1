using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableBrick : MonoBehaviour
{
     public LevelParser levelParser; // Reference to the LevelParser for destroying bricks

    private void OnMouseDown()
    {
        Destroy(gameObject); // Destroy the clicked brick
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
