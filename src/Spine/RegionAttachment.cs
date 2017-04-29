using System;

namespace Spine
{
	public class RegionAttachment : Attachment
	{
		public const int X1 = 0;

		public const int Y1 = 1;

		public const int X2 = 2;

		public const int Y2 = 3;

		public const int X3 = 4;

		public const int Y3 = 5;

		public const int X4 = 6;

		public const int Y4 = 7;

		internal float x;

		internal float y;

		internal float rotation;

		internal float scaleX = 1f;

		internal float scaleY = 1f;

		internal float width;

		internal float height;

		internal float regionOffsetX;

		internal float regionOffsetY;

		internal float regionWidth;

		internal float regionHeight;

		internal float regionOriginalWidth;

		internal float regionOriginalHeight;

		internal float[] offset = new float[8];

		internal float[] uvs = new float[8];

		internal float r = 1f;

		internal float g = 1f;

		internal float b = 1f;

		internal float a = 1f;

		public float X
		{
			get
			{
				return this.x;
			}
			set
			{
				this.x = value;
			}
		}

		public float Y
		{
			get
			{
				return this.y;
			}
			set
			{
				this.y = value;
			}
		}

		public float Rotation
		{
			get
			{
				return this.rotation;
			}
			set
			{
				this.rotation = value;
			}
		}

		public float ScaleX
		{
			get
			{
				return this.scaleX;
			}
			set
			{
				this.scaleX = value;
			}
		}

		public float ScaleY
		{
			get
			{
				return this.scaleY;
			}
			set
			{
				this.scaleY = value;
			}
		}

		public float Width
		{
			get
			{
				return this.width;
			}
			set
			{
				this.width = value;
			}
		}

		public float Height
		{
			get
			{
				return this.height;
			}
			set
			{
				this.height = value;
			}
		}

		public float R
		{
			get
			{
				return this.r;
			}
			set
			{
				this.r = value;
			}
		}

		public float G
		{
			get
			{
				return this.g;
			}
			set
			{
				this.g = value;
			}
		}

		public float B
		{
			get
			{
				return this.b;
			}
			set
			{
				this.b = value;
			}
		}

		public float A
		{
			get
			{
				return this.a;
			}
			set
			{
				this.a = value;
			}
		}

		public string Path
		{
			get;
			set;
		}

		public object RendererObject
		{
			get;
			set;
		}

		public float RegionOffsetX
		{
			get
			{
				return this.regionOffsetX;
			}
			set
			{
				this.regionOffsetX = value;
			}
		}

		public float RegionOffsetY
		{
			get
			{
				return this.regionOffsetY;
			}
			set
			{
				this.regionOffsetY = value;
			}
		}

		public float RegionWidth
		{
			get
			{
				return this.regionWidth;
			}
			set
			{
				this.regionWidth = value;
			}
		}

		public float RegionHeight
		{
			get
			{
				return this.regionHeight;
			}
			set
			{
				this.regionHeight = value;
			}
		}

		public float RegionOriginalWidth
		{
			get
			{
				return this.regionOriginalWidth;
			}
			set
			{
				this.regionOriginalWidth = value;
			}
		}

		public float RegionOriginalHeight
		{
			get
			{
				return this.regionOriginalHeight;
			}
			set
			{
				this.regionOriginalHeight = value;
			}
		}

		public float[] Offset
		{
			get
			{
				return this.offset;
			}
		}

		public float[] UVs
		{
			get
			{
				return this.uvs;
			}
		}

		public RegionAttachment(string name) : base(name)
		{
		}

		public void SetUVs(float u, float v, float u2, float v2, bool rotate)
		{
			float[] array = this.uvs;
			if (rotate)
			{
				array[2] = u;
				array[3] = v2;
				array[4] = u;
				array[5] = v;
				array[6] = u2;
				array[7] = v;
				array[0] = u2;
				array[1] = v2;
			}
			else
			{
				array[0] = u;
				array[1] = v2;
				array[2] = u;
				array[3] = v;
				array[4] = u2;
				array[5] = v;
				array[6] = u2;
				array[7] = v2;
			}
		}

		public void UpdateOffset()
		{
			float num = this.width;
			float num2 = this.height;
			float num3 = this.scaleX;
			float num4 = this.scaleY;
			float num5 = num / this.regionOriginalWidth * num3;
			float num6 = num2 / this.regionOriginalHeight * num4;
			float num7 = -num / 2f * num3 + this.regionOffsetX * num5;
			float num8 = -num2 / 2f * num4 + this.regionOffsetY * num6;
			float num9 = num7 + this.regionWidth * num5;
			float num10 = num8 + this.regionHeight * num6;
			float num11 = this.rotation * 3.14159274f / 180f;
			float num12 = (float)Math.Cos((double)num11);
			float num13 = (float)Math.Sin((double)num11);
			float num14 = this.x;
			float num15 = this.y;
			float num16 = num7 * num12 + num14;
			float num17 = num7 * num13;
			float num18 = num8 * num12 + num15;
			float num19 = num8 * num13;
			float num20 = num9 * num12 + num14;
			float num21 = num9 * num13;
			float num22 = num10 * num12 + num15;
			float num23 = num10 * num13;
			float[] array = this.offset;
			array[0] = num16 - num19;
			array[1] = num18 + num17;
			array[2] = num16 - num23;
			array[3] = num22 + num17;
			array[4] = num20 - num23;
			array[5] = num22 + num21;
			array[6] = num20 - num19;
			array[7] = num18 + num21;
		}

		public void ComputeWorldVertices(Bone bone, float[] worldVertices)
		{
			float num = bone.skeleton.x + bone.worldX;
			float num2 = bone.skeleton.y + bone.worldY;
			float m = bone.m00;
			float m2 = bone.m01;
			float m3 = bone.m10;
			float m4 = bone.m11;
			float[] array = this.offset;
			worldVertices[0] = array[0] * m + array[1] * m2 + num;
			worldVertices[1] = array[0] * m3 + array[1] * m4 + num2;
			worldVertices[2] = array[2] * m + array[3] * m2 + num;
			worldVertices[3] = array[2] * m3 + array[3] * m4 + num2;
			worldVertices[4] = array[4] * m + array[5] * m2 + num;
			worldVertices[5] = array[4] * m3 + array[5] * m4 + num2;
			worldVertices[6] = array[6] * m + array[7] * m2 + num;
			worldVertices[7] = array[6] * m3 + array[7] * m4 + num2;
		}
	}
}
