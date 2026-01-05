using UnityEngine;
using UnityEngine.UIElements;

public class ItemSpawner : MonoBehaviour
{
    public GameObject itemPrefab;
    public GameObject customerPrefab;
    public SpriteRenderer background; // objekt se SpriteRendererem
    Vector2 bgSize;

    void Start()
    {
        bgSize = background.GetComponent<BackgroundSize>().Size;
        SpawnNew();
    }

    public void SpawnNew()
    {
        // Získáme world space hranice sprite pozadí
        var min = background.bounds.min;
        var max = background.bounds.max;

        // Náhodná pozice uvnitø sprite
        float x = Random.Range(min.x, max.x);
        float y = Random.Range(min.y, max.y);



        Instantiate(itemPrefab, new Vector3(x, y, 0), Quaternion.identity);

        // Náhodná pozice uvnitø sprite
        x = Random.Range(min.x, max.x);
        y = Random.Range(min.y, max.y);



        Instantiate(customerPrefab, new Vector3(x, y, 0), Quaternion.identity);
    }
}