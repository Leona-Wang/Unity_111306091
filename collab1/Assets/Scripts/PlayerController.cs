using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 10;
    public Animator animator;
    public ScoreTextController score;
    

	public void OnCollisionEnter2D(Collision2D collision)
	{
        Destroy(collision.gameObject);

        if (collision.gameObject.tag == "coke")
		{
            
            animator.Play("shut");
            
		}
		else
		{
            animator.Play("eat");
            animator.Play("open");

            if (collision.gameObject.tag == "spicySauce")
			{
                
                
			}
            else if (collision.gameObject.tag == "coffee")
			{

			}
            else if (collision.gameObject.tag == "twice")
			{
                score.AddScoreAndDisplay(10);
			}
            else if (collision.gameObject.tag == "once")
			{
                score.AddScoreAndDisplay(20);
			}
        }
        
        
	}
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
		{
            if (this.transform.position.x < 23)
			{
                this.transform.position += new Vector3(speed, 0, 0);
            }
            
		}
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
		{
            if (this.transform.position.x > -23)
			{
                this.transform.position += new Vector3(-speed, 0, 0);
            }
			
		}

        
    }
}
