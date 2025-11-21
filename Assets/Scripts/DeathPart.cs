using UnityEngine;

public class DeathPart : MonoBehaviour
{
    private static readonly int ColorPropertyID = Shader.PropertyToID("_Color");

    private void Start()
    {
        Renderer renderer = GetComponentInChildren<Renderer>();

        if (renderer != null)
        {
            MaterialPropertyBlock block = new MaterialPropertyBlock();

            renderer.GetPropertyBlock(block);

            block.SetColor(ColorPropertyID, Color.red);

            renderer.SetPropertyBlock(block);

            Debug.Log(gameObject.name + " ¡SOLUCIÓN FINAL: Color _Color (Albedo) aplicado!");
        }
        else
        {
            Debug.LogError(gameObject.name + ": ¡FATAL! Renderer no encontrado. La estructura del objeto es el problema.");
        }
    }
}