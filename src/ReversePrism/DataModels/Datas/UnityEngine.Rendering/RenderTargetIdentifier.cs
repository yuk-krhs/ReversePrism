using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AllDepthSlices                           int IL2CPP_TYPE_I4
    // 010 M_Type                                   00018650FFA0 ModelEnumType BuiltinRenderTextureType BuiltinRenderTextureType BuiltinRenderTextureType Int32
    // 014 M_NameID                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 M_InstanceID                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 m_BufferPointer                          <int> IL2CPP_TYPE_I
    // 028 M_MipLevel                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C M_CubeFace                               0001866626C0 ModelEnumType CubemapFace CubemapFace CubemapFace Int32
    // 030 M_DepthSlice                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class RenderTargetIdentifier : DataModel
    {
        public BuiltinRenderTextureType                 M_Type                                  { get; set; }
        public int                                      M_NameID                                { get; set; }
        public int                                      M_InstanceID                            { get; set; }
        public int                                      M_MipLevel                              { get; set; }
        public CubemapFace                              M_CubeFace                              { get; set; }
        public int                                      M_DepthSlice                            { get; set; }

        public static RenderTargetIdentifier? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderTargetIdentifier() { Pointer= p0 };

            value.M_Type                                    = (BuiltinRenderTextureType)GetInt32(new IntPtr(p + 0x010)); // 0245A35D1380 0x10 M_Type                      ( 00018650FFA0 ModelEnumType BuiltinRenderTextureType BuiltinRenderTextureType BuiltinRenderTextureType Int32 )
            value.M_NameID                                  = GetInt32(new IntPtr(p + 0x014)); // 0245A35D13A0 0x14 M_NameID                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_InstanceID                              = GetInt32(new IntPtr(p + 0x018)); // 0245A35D13C0 0x18 M_InstanceID                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_MipLevel                                = GetInt32(new IntPtr(p + 0x028)); // 0245A35D1400 0x28 M_MipLevel                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_CubeFace                                = (CubemapFace)GetInt32(new IntPtr(p + 0x02C)); // 0245A35D1420 0x2C M_CubeFace                  ( 0001866626C0 ModelEnumType CubemapFace CubemapFace CubemapFace Int32 )
            value.M_DepthSlice                              = GetInt32(new IntPtr(p + 0x030)); // 0245A35D1440 0x30 M_DepthSlice                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
