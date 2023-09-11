using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{


    
    public GameObject hintItem;
    public GameObject noteItem;
    public GameObject collectibleItem;
    public GameObject staminaItem;
    public GameObject player;

    public int hintItemCost = 50;
    public int noteItemCost = 50;
    public int keyItemCost = 80;
    public int staminaItemCost = 60;

    public int playerCoin;
    public int playerStamina;

    public Light hintLight;
    public Text buyText;

    private void Awake()
    {
        playerCoin = player.GetComponent<PlayerController>().playerCoin;
        hintLight = hintItem.GetComponent<Light>();
        playerStamina = player.GetComponent<PlayerController>().playerStamina;
    }



    //버튼 이벤트로 상점에서 힌트 아이템을 구매하는 메서드
    public void BuyHintItem()
    {
        if (playerCoin >= hintItemCost)
        {
            buyText.color = Color.red;
            buyText.text = "힌트 구매 완료!";
            StartCoroutine(BuyItem());
            hintLight.enabled = true;

            playerCoin -= hintItemCost;
        }
        

        /*if (Input.GetButtonDown("0"))

        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))

            {
                
            }
        }*/
    }

    // 상점에서 쪽지 아이템을 구매하는 메서드
    public void BuyNoteItem()
    {
        if (playerCoin >= noteItemCost)
        {
            buyText.color = Color.green;
            buyText.text = "쪽지 구매 완료!";
            StartCoroutine(BuyItem());
            noteItem.SetActive(true);

            playerCoin -= noteItemCost;
        }
    }

    // 상점에서 열쇠 아이템을 구매하는 메서드
    public void KeyItem()
    {
        if (playerCoin >= keyItemCost)
        {
            buyText.color = Color.blue;
            buyText.text = "열쇠 구매 완료!";
            StartCoroutine(BuyItem());
            //플레이어에게 열쇠 주는 코드

            playerCoin -= keyItemCost;
        }
    }

    public void StaminaItem()
    {
        if (playerCoin >= staminaItemCost)
        {
            buyText.color = Color.blue;
            buyText.text = "스태미나 구매 완료!";
            StartCoroutine(BuyItem());
            playerStamina += 65;

            playerCoin -= staminaItemCost;
        }
    }

    IEnumerator BuyItem()
    {
        yield return new WaitForSecondsRealtime(2f);
    }
}


