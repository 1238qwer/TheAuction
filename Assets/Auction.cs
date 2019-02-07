using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auction : MonoBehaviour {

    public UIManager uIManager;
    public Enemy enemy;

    private bool isCountinue;

	// Use this for initialization
	void Start () {
        uIManager.currentPrice = 100;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayerBuy()
    {
        StartCoroutine(uIManager.PlayerBuyStart());

        StartCoroutine(Countinue());

        uIManager.currentPrice = uIManager.currentPrice * 2;

        uIManager.BuyBtn.interactable = false;
    }

    public IEnumerator Countinue()
    {
        isCountinue = enemy.EnemyBuying();

        yield return new WaitForSeconds(3.0f);

        if (!isCountinue)
            uIManager.BuySuccess();
        else
        {
            uIManager.EnemyBuy();

            uIManager.currentPrice = uIManager.currentPrice * 2;

            uIManager.BuyBtn.interactable = true;
        }
           
    }
}
