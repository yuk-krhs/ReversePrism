using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SheetName                                string IL2CPP_TYPE_STRING
    // 008 ButtonTurnPage                           SoundKey IL2CPP_TYPE_VALUETYPE
    // 018 WordOn                                   000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 028 ButtonSkip                               000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    public partial class ADVWindowSeConst
    {
        public SoundKey                                 WordOn                                  { get; set; }
        public SoundKey                                 ButtonSkip                              { get; set; }

        public static ADVWindowSeConst? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ADVWindowSeConst();

            value.WordOn                                    = (SoundKey)GetInt32(new IntPtr(p + 0x018)); // 0270069A33A8 0x18 WordOn                      ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ButtonSkip                                = (SoundKey)GetInt32(new IntPtr(p + 0x028)); // 0270069A33C8 0x28 ButtonSkip                  ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )

            return value;
        }
    }
}
