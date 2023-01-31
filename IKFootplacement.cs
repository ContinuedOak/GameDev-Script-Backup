using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKFootplacement : MonoBehaviour
{
    [Range (0, 1f)]
    public float DistantFromGround = 0.6f;
    public Animator anim;

    public LayerMask Mask;

    void OnAnimatorIK(int layerIndex)
    {
        if (anim)
        {
            anim.SetIKPositionWeight(AvatarIKGoal.LeftFoot, 1f);
            anim.SetIKRotationWeight(AvatarIKGoal.LeftFoot, 1f);
            anim.SetIKPositionWeight(AvatarIKGoal.RightFoot, 1f);
            anim.SetIKRotationWeight(AvatarIKGoal.RightFoot, 1f);

            // Left Foot
            RaycastHit hit;
            Ray ray = new Ray(anim.GetIKPosition(AvatarIKGoal.LeftFoot) + Vector3.up, Vector3.down);
            if (Physics.Raycast(ray, out hit, DistantFromGround + 1f, Mask))
            {
                if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Default"))
                {
                    Vector3 FootPosition = hit.point;
                    FootPosition.y += DistantFromGround;

                    anim.SetIKPosition(AvatarIKGoal.LeftFoot, FootPosition);
                    anim.SetIKRotation(AvatarIKGoal.LeftFoot, Quaternion.LookRotation(transform.forward, hit.normal));
                }
            }

            // Right Foot
            ray = new Ray(anim.GetIKPosition(AvatarIKGoal.RightFoot) + Vector3.up, Vector3.down);
            if (Physics.Raycast(ray, out hit, DistantFromGround + 1f, Mask))
            {
                if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Default"))
                {
                    Vector3 FootPosition = hit.point;
                    FootPosition.y += DistantFromGround;

                    anim.SetIKPosition(AvatarIKGoal.RightFoot, FootPosition);
                    anim.SetIKRotation(AvatarIKGoal.RightFoot, Quaternion.LookRotation(transform.forward, hit.normal));
                }
            }

        }
    }
}
