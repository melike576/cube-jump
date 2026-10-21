using UnityEngine;
/*Adı Soyadı:Melike Duman
Öğrenci Numarası:262484053 
 */

public class Obstacle : MonoBehaviour
{
    float speed = 10f;
    
   public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(speed);
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

}
