using UnityEngine;

public class ApplePicker : MonoBehaviour
{
    public GameObject basketPrefab;

    public int numBaskets = 3;
    public float basketBottomY = -14f;

    public float basketSpacingY = 2f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
