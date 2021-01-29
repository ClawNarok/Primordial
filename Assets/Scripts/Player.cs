using UnityEngine;

public class Player : MonoBehaviour {
    void Update() {
        if(Input.GetButtonDown("Interact")) {            
            RaycastHit hit;
            if(Physics.Raycast(this.transform.position, transform.TransformDirection(Vector3.forward), out hit, 2)) {
                if(hit.collider.GetComponent<Door>()) {
                    print("this is a door");
                    hit.collider.GetComponent<Door>().Interact();
                }
                else if(hit.collider.CompareTag("Hiding")) {
                    print("this is a bed");
                    Hide hide = hit.collider.GetComponent<Hide>();
                    Transform hidingSpot = hide.HidingSpot;
                    Vector3 hidingPos = hidingSpot.transform.position;
                    Hide(hidingPos);
                }
                else
                    print("interaction attempt");
            } else {
                //nothing detected
            }
        }
    }

    void Hide(Vector3 position) {
        this.transform.position = position;        
    }
}
