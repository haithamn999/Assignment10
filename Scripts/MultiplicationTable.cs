    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Assignment_10 : MonoBehaviour
    {


        int Multiply(int x ,int y)
        {
            int result = x * y;
            return result;
        }
        // Start is called before the first frame update
        void Start()
        {
            for (int i = 1; i <= 10; i++)
            {

            Debug.Log($"5 * {i} = {Multiply(5, i)}");
            }

        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
