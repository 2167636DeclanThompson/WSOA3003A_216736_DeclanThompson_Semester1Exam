using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool Water;
    public bool Key;
    public bool Painting;   
    public bool Key2;
    public bool Letter;
    public bool Wine;
    public bool Glasses;
    public bool Chair;
    public bool Couch;
    public bool Envelope;

    public CluesScript cluesScript;

    private void Start()
    {
        Water = false;
        Key = false;
        Painting = false;        
        Key2 = false;
        Letter = false;
        Envelope = false;
        Couch = false;
        Chair = false;
        Glasses = false;
        Wine = false;
    }

   
    public void PlayerScored(int playerID)
    {
        cluesScript.PlayerScored(playerID);
    }
}
