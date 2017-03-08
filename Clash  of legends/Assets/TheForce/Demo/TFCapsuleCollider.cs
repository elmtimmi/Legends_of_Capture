namespace TF
{
    using UnityEngine;
    using System.Collections.Generic;
    using UnityEngine.Assertions;
    using System;
    using System.Runtime.InteropServices;

    public partial class TFCapsuleCollider : TFCollider
	{
		public float radius = 0.5f;
		public float length = 1f;
		public bool showAutoDisabled;

		public Color disabledColor = new Color32(255, 255, 64, 255);
		Color originalColor = Color.black;

		SkinnedMeshRenderer skinnedMeshRenderer = null;

		void Start()
		{
			skinnedMeshRenderer = gameObject.GetComponentInChildren<SkinnedMeshRenderer>();

			if (skinnedMeshRenderer != null)
			{
				originalColor = gameObject.GetComponent<MeshRenderer>().material.color;
			}
		}

		void Update()
		{
			if (showAutoDisabled && (skinnedMeshRenderer != null))
			{
				if (gameObject.layer == TFEngine.LAYER_DYNAMIC)
				{
					skinnedMeshRenderer.material.color = originalColor;
				}
				else if (gameObject.layer == TFEngine.LAYER_STATIC)
				{
					skinnedMeshRenderer.material.color = disabledColor;
				}
			}
		}

		public override void InitAfterResetScales()
		{
			base.InitAfterResetScales();

			BoxCollider boxCollider = gameObject.GetComponent<BoxCollider>();
			if (boxCollider != null)
			{
				float diameter = boxCollider.size.x;
				this.radius = diameter * 0.5f;
				this.length = boxCollider.size.z - diameter;
			}

			TFMassBehaviour massBehaviour = gameObject.GetComponent<TFMassBehaviour>();
			if (massBehaviour != null)
			{
				switch (massBehaviour.computeMode)
				{
					case TFMassBehaviour.ComputeMode.ValueIsDensity:
						massBehaviour.mass.SetCapsule(massBehaviour.value, 2, this.radius, this.length);
						break;
					case TFMassBehaviour.ComputeMode.ValueIsFinalMass:
						massBehaviour.mass.SetCapsuleTotal(massBehaviour.value, 2, this.radius, this.length);
						break;
				}
			}

			if (skinnedMeshRenderer != null)
			{
				float diameter = radius * 2f;
				skinnedMeshRenderer.transform.localScale = new Vector3(diameter,diameter,diameter);
				skinnedMeshRenderer.SetBlendShapeWeight(0, length / (diameter * 2f));
				skinnedMeshRenderer.SetBlendShapeWeight(1, length / (diameter * 2f));
			}
		}

        [DllImport("Ode")]
        public static extern IntPtr TF_dCreateCapsule();

        [DllImport("Ode")]
        public static extern void TF_dGeomCapsuleSetParams(IntPtr capsule, float radius, float length);

        public override void CreateGeom()
        {
            geom = TF_dCreateCapsule();
            TF_dGeomCapsuleSetParams(geom, radius, length);
        }

        public override void SetGeomPosR()
        {
            TF_dGeomSetPosR(geom, transform.position, transform.rotation);
        }
    }
}