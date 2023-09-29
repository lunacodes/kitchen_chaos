using UnityEngine;

public class KitchenObject : MonoBehaviour {
	[SerializeField] private KitchenObjectSO kitchenObjectSO;

	private IKitchenObjectParent kitchenObjectParent;

	public KitchenObjectSO GetKitchenObjectSO() {
		return kitchenObjectSO;
	}

	public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent) {
		if (this.kitchenObjectParent != null) {
			this.kitchenObjectParent.ClearKitchenObject();
		}

		if (kitchenObjectParent.HasKitchenObject()) {
			Debug.LogError("Counter already has a KitchenObject!");
		} else {
			// This was originally outside of the if clause
			// If there's an issue, move it back out
			this.kitchenObjectParent = kitchenObjectParent;
			kitchenObjectParent.SetKitchenObject(this);
		}

		transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
		transform.localPosition = Vector3.zero;
	}
	public IKitchenObjectParent GetKitchenObjectParent() {
		return kitchenObjectParent;
	}
}
