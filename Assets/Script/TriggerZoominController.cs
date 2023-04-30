using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoominController : MonoBehaviour
{
   public Collider bola;
  public KameraController kameraController;
  public float length;

  private void OnTriggerEnter(Collider other)
  {
    if (other == bola)
    {
        kameraController (FollowTarget(bola.transform, length));
    }
  }
}
