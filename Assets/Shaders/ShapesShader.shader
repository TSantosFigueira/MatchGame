// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'


Shader "Unlit/ShapesShader"
{
	Properties
    {	
		_MainTex("Texture", 2D) = "white" {}
		_MainColour("Colour", Color) = (1, 0, 0, 1)
    }

    SubShader
	{
		GrabPass { "_GrabTexture" }

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			sampler2D _GrabTexture;
			sampler2D _MainTex;
			half4 _MainColour;

			struct vin_vct
			{
				float4 vertex : POSITION;
				float4 color : COLOR;
				float2 texcoord : TEXCOORD0;
			};

			struct v2f_vct
			{
				float4 vertex : POSITION;
				fixed4 color : COLOR;
			};

			// Vertex function 
			v2f_vct vert (vin_vct v)
			{
				v2f_vct o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.color = v.color;
				return o;
			}

			// Fragment function
			half4 frag (v2f_vct i) : COLOR
			{
				//fixed4 col = tex2Dproj( _GrabTexture, UNITY_PROJ_COORD(i.uvgrab));
				return _MainColour;
			}

			ENDCG
		}


	}
}
