using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public float pwSpeed = 0.000001f;
    public float prSpeed = 0.000005f;
    public float clock = 0;
    public ShardTextController shardTextController;
    public StarTextController starTextController;
    public GameTextController gameTextController;

    

	public void OnTriggerEnter2D(Collider2D collision)
	{
        
        if (collision.gameObject.tag == "Shard")
		{
            collision.gameObject.SetActive(false);
            shardTextController.DecreaseShardsAndDisplay();
        }
        else if (collision.gameObject.tag == "Star")
		{
            collision.gameObject.SetActive(false);
            starTextController.PlusStarAndDisplay();
		}
        else if (collision.gameObject.tag == "Wall")
		{
            this.transform.Translate(0, 0, 0);
		}
        
	}

	public void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.gameObject.tag == "Post")
		{
            
            if (shardTextController.GetCurrShard() == 0 && starTextController.GetStar()==3)
            {
                gameTextController.CollectAllDisplayed();
                pwSpeed = 0;
                prSpeed = 0;

            }
			
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        clock += Time.deltaTime;


        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            if (Input.GetKey(KeyCode.Space))
            {
                this.transform.position += new Vector3(0f, prSpeed * Time.fixedDeltaTime * 0.1f, 0f);

            }
            else
            {
                this.transform.position += new Vector3(0f, pwSpeed * Time.fixedDeltaTime * 0.1f, 0f);
            }

        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (Input.GetKey(KeyCode.Space))
            {
                this.transform.position += new Vector3(-prSpeed * Time.fixedDeltaTime * 0.1f, 0f, 0f);
            }
            else
            {
                this.transform.position += new Vector3(-pwSpeed * Time.fixedDeltaTime * 0.1f, 0f, 0f);
            }
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
		{
            if (Input.GetKey(KeyCode.Space))
            {
                this.transform.position += new Vector3(prSpeed * Time.fixedDeltaTime * 0.1f, 0f, 0f);
            }
            else
            {
                this.transform.position += new Vector3(pwSpeed * Time.fixedDeltaTime * 0.1f, 0f, 0f);
            }
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
		{
            if (Input.GetKey(KeyCode.Space))
            {
                this.transform.position += new Vector3(0f, -prSpeed * Time.fixedDeltaTime * 0.1f, 0f);
            }
            else
            {
                this.transform.position += new Vector3(0f, -pwSpeed * Time.fixedDeltaTime * 0.1f , 0f);
            }
        }
    }
}
