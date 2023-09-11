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

    public void TakeHit(float damage) //������ �޴� �޼���
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
            blueKeySprite.SetActive(true); //ȭ�鿡 �̹��� Ȱ��ȭ�� �÷��̾�� ǥ��
            haveBlueKey = true;
            
        }
        if (collision.gameObject.CompareTag("YellowKey"))
        {
            yellowKeySprite.SetActive(true); //ȭ�鿡 �̹��� Ȱ��ȭ�� �÷��̾�� ǥ��
            haveYellowKey = true;
        }


        if (collision.gameObject.CompareTag("RedKey"))
        {
            if (haveBlueKey && haveYellowKey ) 
            {
                redKeySprite.SetActive(true);
                //SceneManager ��ũ��Ʈ���� �� ��ȯ 
            }

        }
    }
}
