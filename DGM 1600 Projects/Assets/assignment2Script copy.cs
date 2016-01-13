using UnityEngine;
using System.Collections;

public class assignment2Script : MonoBehaviour {

//Debug.log allows me to get the value of any variable in the script or game.

//Start is called when the object this script is attached to enters abstract scene.


	int aNumber = 5;

	void Start(){
		SubtractByThree(aNumber);
		aNumber = SubtractByThree(aNumber);
		Debug.Log (aNumber);
	}
	int SubtractByThree(int bNumber){
			int answer;
			answer = bNumber - 3;

			return answer;
		}
}