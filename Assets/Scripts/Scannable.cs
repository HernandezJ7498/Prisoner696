using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Scannable : MonoBehaviour
{
	public GameObject Player;
	public GameObject distance;
	public void Ping()
	{
		distance.GetComponent<Text>().text = Mathf.Round(Vector3.Distance(GameManager.instance.GameManagerPointOfImpact, transform.position)).ToString();
    }
}
