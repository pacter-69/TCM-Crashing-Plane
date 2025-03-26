using UnityEngine;

public class StarCollector : MonoBehaviour
{
    public int starCounter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D star)
    {
        starCounter++;
        Debug.Log(starCounter);
    }
}
