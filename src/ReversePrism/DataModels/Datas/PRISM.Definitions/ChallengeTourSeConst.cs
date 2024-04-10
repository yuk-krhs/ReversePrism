using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SheetName                                string IL2CPP_TYPE_STRING
    // 000 GetStar                                  SoundKey IL2CPP_TYPE_VALUETYPE
    // 010 Kirari                                   000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    public partial class ChallengeTourSeConst : DataModel
    {
        public SoundKey                                 Kirari                                  { get; set; }

        public static ChallengeTourSeConst? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourSeConst() { Pointer= p0 };

            value.Kirari                                    = (SoundKey)GetInt32(new IntPtr(p + 0x010)); // 02466A121610 0x10 Kirari                      ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )

            return value;
        }
    }
}
