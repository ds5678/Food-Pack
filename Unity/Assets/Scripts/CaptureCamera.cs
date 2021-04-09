using UnityEngine;
using System.Collections;

public class CaptureCamera : MonoBehaviour
{
    [SerializeField]
    Camera cam;
    [SerializeField] string fileName = "screenshot";
    RenderTexture renderTexture;
    [SerializeField]
    Vector2 targetSize;
    Texture2D lastPicture;
    void Start()
    {


        //
        if (cam == null)
        {
            cam = GetComponent<Camera>();
        }
        if (cam == null)
        {
            Debug.LogError("Camera not found");
            enabled = false;
        }
        else
        {
            renderTexture = new RenderTexture((int)targetSize.x, (int)targetSize.y, 24);
            cam.targetTexture = renderTexture;
        }
    }
    void OnGUI()
    {
        fileName = GUILayout.TextField(fileName, GUILayout.Width(500));
        cam.Render();
        if (GUILayout.Button("Capture"))
        {
            RenderTexture.active = renderTexture;


            Texture2D texture = new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.RGBA32, false);
            texture.ReadPixels(new Rect(0, 0, texture.width, texture.height), 0, 0);
            texture.Apply();

            byte[] bytes;
            bytes = texture.EncodeToPNG();

            System.IO.File.WriteAllBytes(fileName + ".png", bytes);
            Debug.Log(Application.persistentDataPath + "/" + fileName + ".png");
            lastPicture = texture;
        }

        GUILayout.Box(cam.targetTexture, GUILayout.Width(targetSize.x), GUILayout.Height(targetSize.y));
    }
}
