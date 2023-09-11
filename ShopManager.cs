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



    //��ư �̺�Ʈ�� �������� ��Ʈ �������� �����ϴ� �޼���
    public void BuyHintItem()
    {
        if (playerCoin >= hintItemCost)
        {
            buyText.color = Color.red;
            buyText.text = "��Ʈ ���� �Ϸ�!";
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

    // �������� ���� �������� �����ϴ� �޼���
    public void BuyNoteItem()
    {
        if (playerCoin >= noteItemCost)
        {
            buyText.color = Color.green;
            buyText.text = "���� ���� �Ϸ�!";
            StartCoroutine(BuyItem());
            noteItem.SetActive(true);

            playerCoin -= noteItemCost;
        }
    }

    // �������� ���� �������� �����ϴ� �޼���
    public void KeyItem()
    {
        if (playerCoin >= keyItemCost)
        {
            buyText.color = Color.blue;
            buyText.text = "���� ���� �Ϸ�!";
            StartCoroutine(BuyItem());
            //�÷��̾�� ���� �ִ� �ڵ�

            playerCoin -= keyItemCost;
        }
    }

    public void StaminaItem()
    {
        if (playerCoin >= staminaItemCost)
        {
            buyText.color = Color.blue;
            buyText.text = "���¹̳� ���� �Ϸ�!";
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


