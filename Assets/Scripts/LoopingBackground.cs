using UnityEngine;
public class LoopingBackground : MonoBehaviour
{
    [SerializeField] float backgroundSpeed;
    [SerializeField] Renderer backgroundRenderer;
    
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            backgroundSpeed = 5;
            
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            backgroundSpeed = 1;
           

        }
    }


 
}
