using UnityEngine;
using System.Collections;

public class Scannable : MonoBehaviour
{
	public void Ping()
	{
		Debug.Log (transform.position);
    }
}
