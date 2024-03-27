using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Ptr                                    <int> IL2CPP_TYPE_I
    // 018 M_Version                                0001865F2F90 ModelPrimitiveType int int int Int32
    // 01C M_FenceType                              000186695B80 ModelEnumType GraphicsFenceType GraphicsFenceType GraphicsFenceType Int32
    public partial class GraphicsFence
    {
        public int                                      M_Version                               { get; set; }
        public GraphicsFenceType                        M_FenceType                             { get; set; }

        public static GraphicsFence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GraphicsFence();

            value.M_Version                                 = GetInt32(new IntPtr(p + 0x018)); // 02700246C5F8 0x18 M_Version                   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_FenceType                               = (GraphicsFenceType)GetInt32(new IntPtr(p + 0x01C)); // 02700246C618 0x1C M_FenceType                 ( 000186695B80 ModelEnumType GraphicsFenceType GraphicsFenceType GraphicsFenceType Int32 )

            return value;
        }
    }
}
