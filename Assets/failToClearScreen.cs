using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Plane))]
public class failToClearScreen : MonoBehaviour
{
    public Texture dvdLogo;
    RenderTexture rt;
    Material mat;
    public Shader shader;
    public Vector2 newDrawPosition;
    // Start is called before the first frame update
    void Start()
    {
        rt = RenderTexture.GetTemporary(1600, 900);
        mat = new Material(shader);
        mat.SetFloat("_Size", 0.3f);
        GetComponent<MeshRenderer>().material = new Material( Shader.Find("Standard"));
        GetComponent<MeshRenderer>().material.SetTexture("_MainTex", rt);
    }

    // Update is called once per frame
    void Update()
    {
        newDrawPosition.x = Mathf.Abs( Mathf.Sin(Time.time));
        newDrawPosition.y = Mathf.Abs( Mathf.Sin(Time.time+0.5f));
        mat.SetVector("_Center", new Vector4(newDrawPosition.x,newDrawPosition.y));

        Graphics.Blit(dvdLogo, rt,mat);
    }
    void OnDestroy()
    {
        RenderTexture.ReleaseTemporary(rt);
    }
}
