using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShardTextController : MonoBehaviour
{
    // Start is called before the first frame update

    public int initialCount = 161;
    public int currCount;
    public Text shardText_;

    public void DecreaseShardsAndDisplay()
	{
        currCount--;

        if (currCount == 0)
		{
            shardText_.text = "Shards Left : All Collect!";
        }
		else
		{
            shardText_.text = "Shards Left : " + currCount.ToString();
        }
        
    }

    public int GetCurrShard()
	{
        return currCount;
	}
    void Start()
    {
        shardText_ = this.GetComponent<Text>();
        currCount = initialCount;
        shardText_.text = "Shards Left : " + currCount.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
