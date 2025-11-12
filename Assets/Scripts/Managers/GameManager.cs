using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerMovment L_Player;
    [SerializeField] private PlayerMovment R_Player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        if (R_Player)
        {
            R_Player.SetKeys(KeyCode.W, KeyCode.S);
        }
         if (L_Player)
        {
            L_Player.SetKeys(KeyCode.UpArrow,KeyCode.DownArrow); 
        }
        
    }


}
