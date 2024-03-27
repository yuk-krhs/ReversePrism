using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CurrentRandomPositionListMaxLength       000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 028 handle                                   <int> IL2CPP_TYPE_I
    public partial class CriAtomEx3dSource
    {
        public uint                                     CurrentRandomPositionListMaxLength      { get; set; }

        public static CriAtomEx3dSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomEx3dSource();

            value.CurrentRandomPositionListMaxLength        = GetUInt32(new IntPtr(p + 0x020)); // 0270D188F368 0x20 CurrentRandomPositionListMaxLength ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
