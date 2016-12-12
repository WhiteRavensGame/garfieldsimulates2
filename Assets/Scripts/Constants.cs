using UnityEngine;
using System.Collections;

public class Constants : MonoBehaviour {

	public static Constants Instance;
	void Awake() { Instance = this; }

	[HideInInspector]public int startingCoins = 0;
}
