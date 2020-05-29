using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingPrefab : MonoBehaviour
{

	public Transform effect;
	public int damage = 100;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{

		RaycastHit hit = new RaycastHit();
		Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));

		if (Input.GetMouseButtonDown(0))
		{
			if (Physics.Raycast(ray, out hit, 100))
			{
				Transform particleClone = Instantiate(effect, hit.point, Quaternion.LookRotation(hit.normal)) as Transform;
				Destroy(particleClone.gameObject, 2);
				hit.transform.SendMessage("ApplyDamage", damage, SendMessageOptions.DontRequireReceiver);
			}
		}
	}
}

