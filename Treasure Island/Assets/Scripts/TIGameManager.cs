using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    //This is a comment

    int largeGold = 0;
    int mediumGold = 0;
    int smallGold = 0;
    int noGold = 0;

    public int largeGoldMin, largeGoldMax;
    public int mediumGoldMin, mediumGoldMax;
    public int smallGoldMin, smallGoldMax;
    
    void Start()
    {
        
    }

    void UpdateGoldValues()
    {
        largeGold = Random.Range(largeGoldMin, largeGoldMax);
        mediumGold = Random.Range(mediumGoldMin, mediumGoldMax);
        smallGold = Random.Range(smallGoldMin, smallGoldMax);
        noGold = 0;

    }

}
