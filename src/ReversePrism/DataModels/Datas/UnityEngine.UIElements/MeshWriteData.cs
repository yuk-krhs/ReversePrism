using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Vertices                               NativeSlice`1<Vertex> IL2CPP_TYPE_GENERICINST
    // 020 m_Indices                                NativeSlice`1<ushort> IL2CPP_TYPE_GENERICINST
    // 030 M_UVRegion                               00018664F8A0 ModelEnumType Rect Rect Rect Int32
    // 040 CurrentIndex                             0001865F2F90 ModelPrimitiveType int int int Int32
    // 044 CurrentVertex                            0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class MeshWriteData
    {
        public Rect                                     M_UVRegion                              { get; set; }
        public int                                      CurrentIndex                            { get; set; }
        public int                                      CurrentVertex                           { get; set; }

        public static MeshWriteData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MeshWriteData();

            value.M_UVRegion                                = (Rect)GetInt32(new IntPtr(p + 0x030)); // 0270067E3D20 0x30 M_UVRegion                  ( 00018664F8A0 ModelEnumType Rect Rect Rect Int32 )
            value.CurrentIndex                              = GetInt32(new IntPtr(p + 0x040)); // 0270067E3D40 0x40 CurrentIndex                ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.CurrentVertex                             = GetInt32(new IntPtr(p + 0x044)); // 0270067E3D60 0x44 CurrentVertex               ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
