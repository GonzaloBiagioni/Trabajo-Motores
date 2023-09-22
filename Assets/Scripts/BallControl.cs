using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class BallControl : MonoBehaviour
{

    [SerializeField] private float force;
    [SerializeField] Rigidbody rb;

    [SerializeField] private float score = 0;
    [SerializeField] private GameObject Coin;
    public Text ScoreText;


    void Start()
    {
        updatescoretext();
        rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()

    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);
        rb.AddForce(direction * force, ForceMode.Force);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene(2);
        }

        if (other.gameObject.CompareTag("Coin"))
        {
            score++;
            updatescoretext();
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Kill"))
        {

            SceneManager.LoadScene(1);

        }
    }
    public void updatescoretext()
    {
        ScoreText.text = "Monedas: " + score.ToString();
    }
}