using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    private Rigidbody rig;
    private int score = 0;
    public int DEFAULT_FORCE = 10;
    public Text scoreText;
    public GameObject successObj;
    public Text successText;
    public GameObject fireworks;
    public ParticleSystem collisionEffect;

	// Use this for initialization
	void Start () {
        rig = GetComponent<Rigidbody>();
        collisionEffect = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal")*DEFAULT_FORCE;
        float v = Input.GetAxis("Vertical")*DEFAULT_FORCE;
        rig.AddForce(new Vector3(h,0,v));
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "FoodTag")
        {
            collisionEffect.Play();
            score++;
            if (score == 5)
            {
                successText.text = Global.name+"同学，你赢了！";
                successObj.SetActive(true);
                fireworks.SetActive(true);
            }
            scoreText.text ="得分:" + score.ToString();
            Destroy(other.gameObject);
        }
    }
}
