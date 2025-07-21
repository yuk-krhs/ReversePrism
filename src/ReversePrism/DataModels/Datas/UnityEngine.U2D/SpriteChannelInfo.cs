using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Buffer                                 <int> IL2CPP_TYPE_I
    // 018 M_Count                                  ModelPrimitiveType int int int Int32
    // 01C M_Offset                                 ModelPrimitiveType int int int Int32
    // 020 M_Stride                                 ModelPrimitiveType int int int Int32
    public partial class SpriteChannelInfo : DataModel
    {
        public int                                      M_Count                                 { get; set; }
        public int                                      M_Offset                                { get; set; }
        public int                                      M_Stride                                { get; set; }

        public static SpriteChannelInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpriteChannelInfo() { Pointer= p0 };

            value.M_Count                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Count                     ( ModelPrimitiveType int int int Int32 )
            value.M_Offset                                  = GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_Offset                    ( ModelPrimitiveType int int int Int32 )
            value.M_Stride                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_Stride                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
