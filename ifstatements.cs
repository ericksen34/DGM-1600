using UnityEngine;
using System.Collections;


public class ifstatements : MonoBehaviour
{
	float yourScore = 10;
	float averageScore = 7;
	float lowScore = 5;
	
	// Use this for initialization
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			popQuiz();
		yourScore -= Time.deltaTime * 1;
	}
		
	// Update is called once per frame
	void popQuiz ()
	{

		if (yourScore > averageScore){ 

			print ("You did amazing!");
		}
		else if (yourScore < lowScore){
			print ("You failed");
		}
		else {
			print ("Good Job.");
		}
	}
}