using UnityEngine;

public class Hide : MonoBehaviour {

    [SerializeField] Transform hidingSpot;
    public Transform HidingSpot { get { return hidingSpot; } private set { } }
}
