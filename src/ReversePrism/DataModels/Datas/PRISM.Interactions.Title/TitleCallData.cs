using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SoundKey                                 ModelEnumType SoundKey SoundKey SoundKey Int32
    public partial class TitleCallData : DataModel
    {
        public SoundKey                                 SoundKey                                { get; set; }

        public static TitleCallData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TitleCallData() { Pointer= p0 };

            value.SoundKey                                  = (SoundKey)GetInt32(new IntPtr(p + 0x010)); // 0x10 SoundKey                    ( ModelEnumType SoundKey SoundKey SoundKey Int32 )

            return value;
        }
    }
}
