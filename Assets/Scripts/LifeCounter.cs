using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LifeCounter : MonoBehaviour
{
    private int lifeCount;
    private Rigidbody body;
    public TextMeshProUGUI lifeText;
    public GameObject gameOverText;
    public Button MainMenuButton;
    public Button CreditsButton;

    // Start is called before the first frame update
    void Start()
    {
        body = this.GetComponent<Rigidbody>();
        lifeCount = 3;
        SetCountText();
        gameOverText.SetActive(false);
        MainMenuButton.gameObject.SetActive(false);
        CreditsButton.gameObject.SetActive(false);

    }

    void SetCountText()
    {
        lifeText.text = "Lives: " + lifeCount.ToString();

        if (lifeCount <= 0)
        {
            // Set the text value of your 'gameOverText'
            lifeCount = 0;
            gameOverText.SetActive(true);
            MainMenuButton.gameObject.SetActive(true);
            CreditsButton.gameObject.SetActive(true);
        }
    }

    private void FixedUpdate()
    {
        if (body.position.y < -5)
        {
            if (lifeCount > 0)
            {
                lifeCount -= 1;
                if(lifeCount > 0)
                    ChangePosition();
            }
        }
        SetCountText();
    }

    private void ChangePosition()
    {
        Vector3 PlayerSpawn = new Vector3(0f, 1.5f, 0f);
        body.velocity = new Vector3(0f, 0f, 0f);
        body.angularVelocity = new Vector3(0f, 0f, 0f);
        body.position = PlayerSpawn;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Heart")
            lifeCount += 1;

        SetCountText();
    }
}
