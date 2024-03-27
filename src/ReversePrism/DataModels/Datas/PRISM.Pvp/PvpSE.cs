using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SheetName                                string IL2CPP_TYPE_STRING
    // 000 JinglePvpWin                             SoundKey IL2CPP_TYPE_VALUETYPE
    // 010 JinglePvpLose                            000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    public partial class PvpSE
    {
        public SoundKey                                 JinglePvpLose                           { get; set; }

        public static PvpSE? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpSE();

            value.JinglePvpLose                             = (SoundKey)GetInt32(new IntPtr(p + 0x010)); // 0270D50933D8 0x10 JinglePvpLose               ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )

            return value;
        }
    }
}
