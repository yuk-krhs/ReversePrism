using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProjMatrix                               ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 050 ViewMatrix                               ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 090 Viewport                                 ModelEnumType Rect Rect Rect Int32
    // 0A0 OcclusionMesh                            ModelClassType Mesh Mesh Mesh Pointer
    // 0A8 TextureArraySlice                        ModelPrimitiveType int int int Int32
    // 0AC EyeCenterUV                              ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class XRView : DataModel
    {
        public Matrix4x4                                ProjMatrix                              { get; set; }
        public Matrix4x4                                ViewMatrix                              { get; set; }
        public Rect                                     Viewport                                { get; set; }
        public Mesh?                                    OcclusionMesh                           { get; set; }
        public int                                      TextureArraySlice                       { get; set; }
        public Vector2                                  EyeCenterUV                             { get; set; }

        public static XRView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XRView() { Pointer= p0 };

            value.ProjMatrix                                = (Matrix4x4)GetInt32(new IntPtr(p + 0x010)); // 0x10 ProjMatrix                  ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.ViewMatrix                                = (Matrix4x4)GetInt32(new IntPtr(p + 0x050)); // 0x50 ViewMatrix                  ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.Viewport                                  = (Rect)GetInt32(new IntPtr(p + 0x090)); // 0x90 Viewport                    ( ModelEnumType Rect Rect Rect Int32 )
            value.OcclusionMesh                             = GetObject<Mesh>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Mesh.FromPointer); // 0xA0 OcclusionMesh               ( ModelClassType Mesh Mesh Mesh Pointer )
            value.TextureArraySlice                         = GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 TextureArraySlice           ( ModelPrimitiveType int int int Int32 )
            value.EyeCenterUV                               = (Vector2)GetInt32(new IntPtr(p + 0x0AC)); // 0xAC EyeCenterUV                 ( ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
