using UnityEngine;

public class TomatoPickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand")) // تأكد من أن الأيدي تحتوي على Tag باسم "Hand"
        {
            // أضف الطماطم إلى المخزون أو قم بإخفائها
            Destroy(gameObject); // يمكنك استبدالها بإضافة الطماطم للمخزون
            Debug.Log("تم جمع الطماطم!");
        }
    }
}