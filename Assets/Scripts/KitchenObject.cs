using UnityEngine;

public class KitchenObject : MonoBehaviour {
	[SerializeField] private KitchenObjectSO kitchenObjectSO;

	private ClearCounter clearCounter;

	public KitchenObjectSO GetKitchenObjectSO() {
		return kitchenObjectSO;
	}

	public void SetClearCounter(ClearCounter clearCounter) {
		if (this.clearCounter != null) {
			// Previous clear counter
			this.clearCounter.ClearKitchenObject();
		}

		// New clear counter
		if (clearCounter.HasKitchenObject()) {
			Debug.LogError("Counter already has a KitchenObject!");
		} else {
			this.clearCounter = clearCounter;
			clearCounter.SetKitchenObject(this);
		}

		//this.clearCounter = clearCounter;
		//clearCounter.SetKitchenObject(this);

		transform.parent = clearCounter.GetKitchenObjectFollowTransform();
		transform.localPosition = Vector3.zero;
	}
	public ClearCounter GetClearCounter() {
		return clearCounter;
	}
}
