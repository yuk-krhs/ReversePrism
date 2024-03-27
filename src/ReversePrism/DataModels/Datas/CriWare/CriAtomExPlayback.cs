using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 000 invalidId                                uint IL2CPP_TYPE_U4
    public partial class CriAtomExPlayback
    {
        public uint                                     Id                                      { get; set; }

        public static CriAtomExPlayback? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomExPlayback();

            value.Id                                        = GetUInt32(new IntPtr(p + 0x010)); // 02700414F4F8 0x10 Id                          ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
