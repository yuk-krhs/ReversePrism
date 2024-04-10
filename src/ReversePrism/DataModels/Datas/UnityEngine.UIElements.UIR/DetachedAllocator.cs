using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_VertsPool                              TempAllocator`1<Vertex> IL2CPP_TYPE_GENERICINST
    // 018 m_IndexPool                              TempAllocator`1<ushort> IL2CPP_TYPE_GENERICINST
    // 020 M_MeshWriteDataPool                      000185CF3288 ModelClassListType List`1<MeshWriteData> List`1<MeshWriteData> List<MeshWriteData> Pointer
    // 028 M_MeshWriteDataCount                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C M_Disposed                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class DetachedAllocator : DataModel
    {
        public List<MeshWriteData>?                     M_MeshWriteDataPool                     { get; set; }
        public int                                      M_MeshWriteDataCount                    { get; set; }
        public bool                                     M_Disposed                              { get; set; }

        public static DetachedAllocator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DetachedAllocator() { Pointer= p0 };

            value.M_MeshWriteDataPool                       = GetObjectList<MeshWriteData>(new IntPtr(p + 0x020), ReversePrism.DataModels.MeshWriteData.FromPointer); // 0245A6822000 0x20 M_MeshWriteDataPool         ( 000185CF3288 ModelClassListType List`1<MeshWriteData> List`1<MeshWriteData> List<MeshWriteData> Pointer )
            value.M_MeshWriteDataCount                      = GetInt32(new IntPtr(p + 0x028)); // 0245A6822020 0x28 M_MeshWriteDataCount        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Disposed                                = GetBool(new IntPtr(p + 0x02C)); // 0245A6822040 0x2C M_Disposed                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
