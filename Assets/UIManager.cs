using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Text currentPriceTxt;
    public Text enemyBuyTxt;
    public Text playerBuyTxt;

    public float currentPrice;
    public float enemyBuy;
    public float playerBuy;

    public Button BuyBtn;

	// Use this for initialization
	void Start () {
        enemyBuyTxt.gameObject.SetActive(false);
        playerBuyTxt.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        currentPriceTxt.text = "현재입찰가" + currentPrice.ToString();
	}

    public void EnemyBuy()
    {
        StartCoroutine(EnemyBuyStart());
    }

    public IEnumerator EnemyBuyStart()
    {
        enemyBuyTxt.gameObject.SetActive(true);

        yield return new WaitForSeconds(2f);

        enemyBuyTxt.gameObject.SetActive(false);
    }
    
    public void PlayerBuy()
    {
        StartCoroutine(PlayerBuyStart());
    }

    public IEnumerator PlayerBuyStart()
    {
        playerBuyTxt.gameObject.SetActive(true);

        yield return new WaitForSeconds(2f);

        playerBuyTxt.gameObject.SetActive(false);
    }

    public void BuySuccess()
    {
        enemyBuyTxt.gameObject.SetActive(true);

        enemyBuyTxt.text = "큭... 내가 졌소";

        currentPriceTxt.text = "입찰성공!!! : " + currentPrice; 
    }
}
