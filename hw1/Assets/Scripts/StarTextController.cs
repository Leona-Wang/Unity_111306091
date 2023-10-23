using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarTextController : MonoBehaviour
{
    public int initialCount = 0;
    public int currCount;
    public Text starText_;

    public void PlusStarAndDisplay()
	{
        currCount++;
        if (currCount == 3)
		{
            starText_.text = "Stars Get : All Get!";
        }
		else
		{
            starText_.text = "Stars Get : " + currCount.ToString();
        }
	}

    public int GetStar()
	{
        return currCount;
	}
    // Start is called before the first frame update
    void Start()
    {
        starText_ = this.GetComponent<Text>();
        currCount = initialCount;
        starText_.text = "Stars Get : " + currCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
