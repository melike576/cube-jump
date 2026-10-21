using UnityEngine;
/*Adı Soyadı:Melike Duman
Öğrenci Numarası:262484053 
 */

public class EnemyDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) 
        {
            Destroy(collision.gameObject);
        }
    }

}
