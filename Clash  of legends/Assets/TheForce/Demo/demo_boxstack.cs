using UnityEngine;
using System.Collections;
using TF;

public class demo_boxstack : MonoBehaviour
{
	public GameObject boxPrefab;
	public GameObject physxBoxPrefab;

	public GameObject spherePrefab;
	public GameObject physxSpherePrefab;

	public GameObject capsulePrefab;
	public GameObject physxCapsulePrefab;

	public int numBodies = 0;
	public int numPhysxBodies = 0;

	GameObject CreateInstance(GameObject prefab, string name)
	{
		GameObject instance = GameObject.Instantiate(prefab);
		instance.name = name;
		Vector3 sides = new Vector3(Random.value * 0.5f + 0.1f, Random.value * 0.5f + 0.1f, Random.value * 0.5f + 0.1f);
		instance.transform.localScale = sides;
		instance.transform.position = new Vector3(Random.value * 2f - 1f, Random.value + 2f, Random.value * 2f - 1f);
		instance.transform.rotation = Random.rotation;
		instance.transform.parent = transform;
		return instance;
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
		{
			if (Input.GetKeyDown(KeyCode.B))
			{
				CreateInstance(physxBoxPrefab, "PhysxBox " + numPhysxBodies);
				numPhysxBodies++;
			}

			if (Input.GetKeyDown(KeyCode.C))
			{
				GameObject capsule = CreateInstance(physxCapsulePrefab, "Capsule " + numBodies);
				CapsuleCollider capsuleCollider = capsule.GetComponent<CapsuleCollider>();
				float diameter = capsule.transform.localScale.x;
				capsuleCollider.radius = diameter * 0.5f;
				capsuleCollider.height = capsule.transform.localScale.z + diameter;
				capsule.transform.localScale = Vector3.one;
				capsule.GetComponent<CapsuleHelper>().UpdateSize();
				numBodies++;
			}

			if (Input.GetKeyDown(KeyCode.S))
			{
				GameObject physxSphere = CreateInstance(physxSpherePrefab, "PhysxSphere " + numBodies);
				float radius = physxSphere.transform.localScale.x;
				physxSphere.transform.localScale = new Vector3(radius, radius, radius);
				numPhysxBodies++;
			}

			if (Input.GetKeyDown(KeyCode.X))
			{
				GameObject compoundGO = new GameObject("PhysxCompound " + numBodies);
				compoundGO.transform.parent = transform;

				GameObject sphere = CreateInstance(physxSpherePrefab, "PhysxSphere " + numBodies);
				float radius = sphere.transform.localScale.x;
				sphere.transform.localScale = new Vector3(radius, radius, radius);
				DestroyImmediate(sphere.GetComponent<Rigidbody>());
				sphere.transform.parent = compoundGO.transform;

				GameObject capsule = CreateInstance(physxCapsulePrefab, "Capsule " + numBodies);
				CapsuleCollider capsuleCollider = capsule.GetComponent<CapsuleCollider>();
				float diameter = capsule.transform.localScale.x;
				capsuleCollider.radius = diameter * 0.5f;
				capsuleCollider.height = capsule.transform.localScale.z + diameter;
				capsule.transform.localScale = Vector3.one;
				capsule.GetComponent<CapsuleHelper>().UpdateSize();
				DestroyImmediate(capsule.GetComponent<Rigidbody>());
				capsule.transform.parent = compoundGO.transform;

				GameObject box = CreateInstance(physxBoxPrefab, "PhysxBox " + numBodies);
				DestroyImmediate(box.GetComponent<Rigidbody>());
				box.transform.parent = compoundGO.transform;

				compoundGO.AddComponent<Rigidbody>();

				numPhysxBodies++;
			}
		}
		else
		{
			if (Input.GetKeyDown(KeyCode.B))
			{
				CreateInstance(boxPrefab, "Box " + numBodies);
				numBodies++;
			}

			if (Input.GetKeyDown(KeyCode.S))
			{
				GameObject sphere = CreateInstance(spherePrefab, "Sphere " + numBodies);
				float diameter = sphere.transform.localScale.x;
				sphere.transform.localScale = new Vector3(diameter, diameter, diameter);
				numBodies++;
			}

			if (Input.GetKeyDown(KeyCode.C))
			{
				GameObject capsule = CreateInstance(capsulePrefab, "Capsule " + numBodies);
				float diameter = capsule.transform.localScale.x;
				float length = capsule.transform.localScale.z;
				capsule.transform.localScale = new Vector3(diameter, diameter, length + diameter);
				numBodies++;
			}

			if (Input.GetKeyDown(KeyCode.X))
			{
				GameObject compoundGO = new GameObject("Compound " + numBodies);
				compoundGO.transform.parent = transform;
								
				GameObject sphere = CreateInstance(spherePrefab, "Sphere " + numBodies);
				float radius = sphere.transform.localScale.x;
				sphere.transform.localScale = new Vector3(radius, radius, radius);
				DestroyImmediate(sphere.GetComponent<TFRigidbody>());
				sphere.transform.parent = compoundGO.transform;

				GameObject capsule = CreateInstance(capsulePrefab, "Capsule " + numBodies);
				float diameter = capsule.transform.localScale.x;
				float length = capsule.transform.localScale.z;
				capsule.transform.localScale = new Vector3(diameter, diameter, length + diameter);
				DestroyImmediate(capsule.GetComponent<TFRigidbody>());
				capsule.transform.parent = compoundGO.transform;

				GameObject box = CreateInstance(boxPrefab, "Box " + numBodies);
				DestroyImmediate(box.GetComponent<TFRigidbody>());
				box.transform.parent = compoundGO.transform;

				compoundGO.AddComponent<TFRigidbody>();
				
				numBodies++;
			}
		}
		
		if (Input.GetKeyDown(KeyCode.Delete))
		{
			for (int i=0;i<transform.childCount;i++)
			{
				GameObject.Destroy(transform.GetChild(i).gameObject);
			}
			numBodies = 0;
			numPhysxBodies = 0;
		}
	}

	void OnGUI()
	{
		Rect rect = new Rect(0f, Screen.height - 25f, Screen.width, 25f);
		GUI.Box(rect,"B for box, S for sphere, C for capsule, X for compound object, "
		+ "SHIFT + B for Physx box, SHIFT + S for Physx sphere, SHIFT + X for Physx compound object");
	}
}
