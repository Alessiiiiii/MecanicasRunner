using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    GameObject[] Piso;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnPiso()
        {
        int randomIndex=Random.Range(0, Piso.Length);
        GameObject Piso = Instantiate(Piso[randomIndex], transform.position, Quaternion.identity);
        Piso.transform.SetParent(transform);
        }   
}
