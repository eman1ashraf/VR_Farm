using UnityEngine;

public class ObjectThrow : MonoBehaviour
{
    public float throwForce = 10f;  // قوة الرمي
    public Transform targetBox;  // المكان الذي سيتم رمي العنصر فيه (مثل Box)
    private Rigidbody rb;  // الـ Rigidbody الخاص بالعناصر

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // الرمي عند الضغط على زر (مثلاً، G)
        if (Input.GetKeyDown(KeyCode.G) && rb != null)
        {
            ThrowObject();
        }
    }

    void ThrowObject()
    {
        // تعطيل الإمساك بالعناصر
        rb.isKinematic = false;  // ليكون العنصر تفاعلي مع الفيزياء

        // حساب الاتجاه الصحيح نحو الـ Box (المربع)
        Vector3 directionToTarget = targetBox.position - transform.position;

        // جعل الاتجاه متوازن وتحريك العنصر في الاتجاه الصحيح
        Vector3 throwDirection = directionToTarget.normalized;  // الاتجاه المطلوب

        // رمي العنصر بقوة في الاتجاه المحسوب
        rb.AddForce(throwDirection * throwForce, ForceMode.Impulse);
    }
}
