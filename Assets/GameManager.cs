using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    void Start()
    {
        Player p1 = new Player();
        Player P2 = new Player();

        p1.InitializePlayer("mamdoo7", 75);
        P2.InitializePlayer("mamdoo7ah",40);

        p1.Heal(5);
        p1.Heal(true); 

        P2.Heal(10);
        P2.Heal(true);
        
        Player.ShowPlayerCount();

           
    }

    
    void Update()
    {
        
    }
}
