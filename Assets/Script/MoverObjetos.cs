using UnityEngine;

public class MoverObjetos : MonoBehaviour
{
    public float empuje = 2.0f;
    //private float TargetMass;
    private void OnControllerColliderHit(ControllerColliderHit hit) {
        Rigidbody body = hit.collider.attachedRigidbody;

        if (body == null || body.isKinematic)
        {
            return;
        }
        if (hit.moveDirection.y< -0.3)
        {
            return;
        }

        //TargetMass = body.mass;

        Vector3 empujeDir = new Vector3(hit.moveDirection.x,0,hit.moveDirection.z);
        body.linearVelocity = empujeDir * empuje;
        //body.linearVelocity = empujeDir * empuje / TargetMass;
    }
}
