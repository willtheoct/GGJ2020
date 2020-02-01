Shader "Hidden/drawSomething"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _Center("Center", Vector)=(0,0,0,0)
        _Size("Size", Float)=0
    }
    SubShader
    {
        // No culling or depth
        Cull Off ZWrite Off ZTest Always
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"
            float4 _Center;
            float _Size;

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            sampler2D _MainTex;

            fixed4 frag (v2f i) : SV_Target
            {
                if(i.uv.x > _Center.x - _Size)
                if(i.uv.y > _Center.y - _Size)
                if(i.uv.x < _Center.x + _Size)
                if(i.uv.y < _Center.y + _Size)
                return tex2D(_MainTex, (i.uv-_Center.xy)/_Size/2+0.5);
                discard;
                return fixed4(0,0,0,0);
            }
            ENDCG
        }
    }
}
