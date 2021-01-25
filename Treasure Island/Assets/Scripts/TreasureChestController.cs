using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChestController : MonoBehaviour
{
    // Start is called before the first frame update
    TIGameManager ti;
    public Animator animator; 

    void Start()
    {
        ti = GameObject.Find("GameManager").GetComponent<TIGameManager>();

        ti.UpdateGoldValues();
    }

    private void OnMouseDown()
    {
        Debug.Log(gameObject.name + " has been clicked");
    }
}
