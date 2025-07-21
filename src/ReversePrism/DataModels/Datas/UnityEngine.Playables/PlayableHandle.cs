using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Handle                                 <int> IL2CPP_TYPE_I
    // 018 M_Version                                ModelPrimitiveType uint uint uint UInt32
    // 000 m_Null                                   PlayableHandle IL2CPP_TYPE_VALUETYPE
    public partial class PlayableHandle : DataModel
    {
        public uint                                     M_Version                               { get; set; }

        public static PlayableHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayableHandle() { Pointer= p0 };

            value.M_Version                                 = GetUInt32(new IntPtr(p + 0x018)); // 0x18 M_Version                   ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
