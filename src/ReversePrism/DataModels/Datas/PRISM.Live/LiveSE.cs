using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SheetName                                string IL2CPP_TYPE_STRING
    // 000 Pause                                    SoundKey IL2CPP_TYPE_VALUETYPE
    // 010 MVSeekBarAppear                          ModelEnumType SoundKey SoundKey SoundKey Int32
    // 020 MVSeekBarSlide                           ModelEnumType SoundKey SoundKey SoundKey Int32
    public partial class LiveSE : DataModel
    {
        public SoundKey                                 MVSeekBarAppear                         { get; set; }
        public SoundKey                                 MVSeekBarSlide                          { get; set; }

        public static LiveSE? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveSE() { Pointer= p0 };

            value.MVSeekBarAppear                           = (SoundKey)GetInt32(new IntPtr(p + 0x010)); // 0x10 MVSeekBarAppear             ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.MVSeekBarSlide                            = (SoundKey)GetInt32(new IntPtr(p + 0x020)); // 0x20 MVSeekBarSlide              ( ModelEnumType SoundKey SoundKey SoundKey Int32 )

            return value;
        }
    }
}
