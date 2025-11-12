using UnityEngine;

public class playerManager : MonoBehaviour
{
    [Header("Component References")]
    public playerAbilitiies abilities;
    public playerPowerups powerups;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check for input and call corresponding abilities
        HandleInput();
    }
    
    void HandleInput()
    {
        // Wave ability - Press Q
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (abilities != null)
                abilities.wave();
        }
        
        // Bang ability - Press E
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (abilities != null)
                abilities.bang();
        }
        
        // Yell ability - Press R
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (abilities != null)
                abilities.yell();
        }
        
        // Powerup - Press F
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (powerups != null)
                powerups.powerupTemp();
        }
    }
}
