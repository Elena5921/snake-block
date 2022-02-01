using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player: MonoBehaviour
{
    private Rigidbody Rb;
    public GameObject panel_finish;
    public GameObject panel_death;

    public float money = 0;

    public TextMesh text_ball;

    public AudioSource audio_money;
    public AudioSource audio_block;
    public AudioSource audio_fon;
    public AudioSource audio_won;
    public AudioSource audio_lost;
    public AudioSource audio_maych;
    public GameObject effect;

    public GameObject fps;


    public GameObject bodyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
        panel_finish.SetActive(false);
        panel_death.SetActive(false);
        effect.SetActive(false);
    }
       
    // Update is called once per frame
    void Update()
    {
        text_ball.text = money.ToString("f0");
    }
    private void FixedUpdate()
    {
        Rb.AddForce(0f, 0f, 5f);
        if (Input.GetKey(KeyCode.A))
        {
            Rb.AddForce(-20f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Rb.AddForce(20f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Rb.AddForce(0f, 0f, -6f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish1")
        {
            PlayerPrefs.SetInt("saveLVL", 1);
            panel_finish.SetActive(true);
            fps.SetActive(false);
            audio_fon.Stop();
            audio_won.Play();
        }
        if (other.tag == "Finish2")
        {
            PlayerPrefs.SetInt("saveLVL", 2);
            panel_finish.SetActive(true);
            fps.SetActive(false);
            audio_fon.Stop();
            audio_won.Play();
        }
        if (other.tag == "Finish3")
        {
            //PlayerPrefs.SetInt("saveLVL", 3);
            panel_finish.SetActive(true);
            fps.SetActive(false);
            audio_fon.Stop();
            audio_won.Play();
        }
        if (other.tag == "money")
        {
            money += other.GetComponent<ball>().ochko;
            Destroy(other.gameObject);
            audio_money.Play();
        }
        if(other.tag == "block")
        {
            audio_maych.Play();
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "block")
        {
            money -= 1 * Time.deltaTime * 5;
            other.GetComponent<ball>().ochkof -= 1 * Time.deltaTime * 5;
            effect.SetActive(true);
            if(other.GetComponent<ball>().ochkof <= 0.9f)
            {
                Destroy(other.gameObject);
                effect.SetActive(false);
                audio_block.Play();
                audio_maych.Stop();
            }
            if (money < 0)
            {
                panel_death.SetActive(true);
                fps.SetActive(false);
                audio_fon.Stop();
                audio_lost.Play();
            }
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "block")
        {
            effect.SetActive(false);
            audio_maych.Stop();
        }
    }

}
