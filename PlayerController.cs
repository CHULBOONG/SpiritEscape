using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float playerHP = 100f;
    public float moveSpeed = 5f;
    public int playerCoin = 500;
    public int playerStamina = 250;

    private Rigidbody rb;
 

    
    public GameObject blueKeySprite;
    public GameObject redKeySprite;
    public GameObject yellowKeySprite;

    private bool haveBlueKey;
    private bool haveYellowKey;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(moveHorizontal, 0f, moveVertical) * moveSpeed;

        
        rb.velocity = move;
    }

    public void TakeHit(float damage) //데미지 받는 메서드
    {
        playerHP -= damage;
        
        if (playerHP <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BlueKey"))
        {
            blueKeySprite.SetActive(true); //화면에 이미지 활성화로 플레이어에게 표시
            haveBlueKey = true;
            
        }
        if (collision.gameObject.CompareTag("YellowKey"))
        {
            yellowKeySprite.SetActive(true); //화면에 이미지 활성화로 플레이어에게 표시
            haveYellowKey = true;
        }


        if (collision.gameObject.CompareTag("RedKey"))
        {
            if (haveBlueKey && haveYellowKey ) 
            {
                redKeySprite.SetActive(true);
                //SceneManager 스크립트에서 씬 전환 
            }

        }
    }
}
