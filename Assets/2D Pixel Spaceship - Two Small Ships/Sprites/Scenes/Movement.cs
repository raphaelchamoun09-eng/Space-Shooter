using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class Mo : MonoBehaviour
{
    [SerializeField,Range(0.5f, 5)] float speed;
    [SerializeField] KeyCode left = KeyCode.A;
    [SerializeField] KeyCode right = KeyCode.D;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(speed);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(left))
        {
            print("Åk vänster");
            transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;
        
        }
        if (Input.GetKeyDown(right)) 
        {
            print("Åk höger");
            transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;


        }
    }
}
