using UnityEngine;

public class Parrallax : MonoBehaviour
{
    Material _mat;
    float distance;
    float timeSinceLastIncrease = 0;
    [SerializeField] float initialSpeed;
    [SerializeField] float speedIncreaseAmount = 0.01f;
    [SerializeField] float maxSpeed;
    /*Adı Soyadı:Melike Duman
Öğrenci Numarası:262484053 
 */

    void Start()
    {
        _mat= GetComponent<Renderer>().material;
    }

    
    void Update()
    {
        timeSinceLastIncrease += Time.deltaTime;
        if(timeSinceLastIncrease>=10f)
        {
            initialSpeed += speedIncreaseAmount;
            initialSpeed = Mathf.Min(initialSpeed, maxSpeed);
            timeSinceLastIncrease = 0f;
              
        }

        distance += Time.deltaTime * initialSpeed;
        _mat.SetTextureOffset("_MainTex", new Vector2(distance, 0));



    }






}
