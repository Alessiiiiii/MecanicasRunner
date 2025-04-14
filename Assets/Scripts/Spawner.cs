using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    GameObject[] Bloke;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnBloke()
        {
        int randomIndex=Random.Range(0, Bloke.Length);
        GameObject Piso = Instantiate(Bloke [randomIndex], transform.position, Quaternion.identity);
        Piso.transform.SetParent(transform);
        }   
}
