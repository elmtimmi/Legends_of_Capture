using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CapsuleCollider))]
public class CapsuleHelper : MonoBehaviour 
{
	public Color sleepingColor = new Color32(128, 128, 128, 255);
	Color originalColor = Color.black;

	void Start() 
	{
		SkinnedMeshRenderer skinnedMeshRenderer = gameObject.GetComponentInChildren<SkinnedMeshRenderer>();

		if (skinnedMeshRenderer != null)
		{
			originalColor = skinnedMeshRenderer.material.color;
		}
	}

	public void UpdateSize()
	{
		CapsuleCollider capsuleCollider = gameObject.GetComponent<CapsuleCollider>();
		float radius = capsuleCollider.radius;
		float diameter = radius * 2f;

		SkinnedMeshRenderer skinnedMeshRenderer = gameObject.GetComponentInChildren<SkinnedMeshRenderer>();

		if (skinnedMeshRenderer != null)
		{
			skinnedMeshRenderer.transform.localScale = new Vector3(diameter,diameter,diameter);
			skinnedMeshRenderer.SetBlendShapeWeight(0, (capsuleCollider.height - diameter) / (diameter * 2f));
			skinnedMeshRenderer.SetBlendShapeWeight(1,  (capsuleCollider.height - diameter) / (diameter * 2f));
		}
	}
	
	void Update() 
	{
		SkinnedMeshRenderer skinnedMeshRenderer = gameObject.GetComponentInChildren<SkinnedMeshRenderer>();

		if (skinnedMeshRenderer != null)
		{
			Rigidbody rigidBody = gameObject.GetComponent<Collider>().attachedRigidbody;

			if (rigidBody != null)
			{
				if (!rigidBody.IsSleeping())
				{
					skinnedMeshRenderer.material.color = originalColor;
				}
				else
				{
					skinnedMeshRenderer.material.color = sleepingColor;
				}
			}
		}
	}
}
