using System;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float velocidade = 30f;
    public TextMeshProUGUI countText;
    public GameObject WinTextObject;

    private Rigidbody rb;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        WinTextObject.SetActive(false);
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * velocidade);
    }

    void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Pontuação: " + count.ToString();
        if (count >= 12)
        {
            WinTextObject.SetActive(true);
        }
    }

}
    
