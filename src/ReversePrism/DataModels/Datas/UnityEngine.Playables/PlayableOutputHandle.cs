using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Handle                                 <int> IL2CPP_TYPE_I
    // 018 M_Version                                000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 000 m_Null                                   PlayableOutputHandle IL2CPP_TYPE_VALUETYPE
    public partial class PlayableOutputHandle
    {
        public uint                                     M_Version                               { get; set; }

        public static PlayableOutputHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayableOutputHandle();

            value.M_Version                                 = GetUInt32(new IntPtr(p + 0x018)); // 0270021B8810 0x18 M_Version                   ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
