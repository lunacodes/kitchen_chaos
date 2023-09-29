using UnityEngine;

[CreateAssetMenu()]
public class KitchenObjectSO : ScriptableObject {
	// public Transform prefab;
	// public Sprite sprite;
	// public string objectName;

	public Transform prefab;
	[SerializeField] private Sprite sprite;
	public string objectName;
}
