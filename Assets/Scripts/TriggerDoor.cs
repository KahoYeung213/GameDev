using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
   [SerializeField] private Animator myDoor = null;
   
   [SerializeField] private bool openTrigger = false;
   [SerializeField] private bool closeTrigger = false;

   [SerializeField] private string doorOpen = "DoorOpen";
   [SerializeField] private string doorClose = "DoorClose";

   private void OnTriggerEnter(Collider other)
   {
      if (openTrigger)
      {
         myDoor.Play(doorOpen, 0, 0.0f);
         gameObject.SetActive(false);
      }
      else if (closeTrigger)
      {
         myDoor.Play(doorClose, 0, 0.0f);
         gameObject.SetActive(false);
      }
   }
}