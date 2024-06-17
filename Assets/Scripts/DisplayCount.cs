using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayCount : MonoBehaviour
{
    private float score;
    private float scorePerSecond;
    private float scoreTimer;
    public TextMeshProUGUI countText;
    private int collidedCoinValue;
    private Rigidbody body;
    private int lifeCount;

    // Start is called before the first frame update
    void Start()
    {
        body = this.GetComponent<Rigidbody>();
        lifeCount = 3;
        score = 0f;
        scorePerSecond = 1f;
        SetCountText();
    }
    
    void Update()
    {
        if (lifeCount > 0)
        {
            countText.text = "Score: " + (int)score;
            score += scorePerSecond * Time.deltaTime;
        }

        scoreTimer -= Time.deltaTime;


        if (scoreTimer <= 0)
        {
            scorePerSecond = 1;
        }

    }

    private void FixedUpdate()
    {
        if (body.position.y < -5)
            if (lifeCount > 0)
                lifeCount -= 1;
                
    }

    void SetCountText()
    {
        countText.text = "Score: " + score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Heart")
            lifeCount += 1;

        if (other.gameObject.tag == "DoublePoints")
        {
            scorePerSecond = 3;
            scoreTimer = 10f;
        }
            

        if (other.gameObject.name == "GoldCoin" || other.gameObject.name == "SilverCoin")
        {
            collidedCoinValue = other.gameObject.GetComponent<Coin>().coinValue;
            score = score + collidedCoinValue;

            SetCountText();
        }
        
    }
}
