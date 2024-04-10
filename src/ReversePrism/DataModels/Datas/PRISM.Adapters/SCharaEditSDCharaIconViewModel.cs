using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharacterInfoId                          0001865F4940 ModelPrimitiveType int int int Int32
    // 014 IsFriendSupportChara                     000186596AF0 ModelPrimitiveType bool bool bool Bool
    public partial class SCharaEditSDCharaIconViewModel : DataModel
    {
        public int                                      CharacterInfoId                         { get; set; }
        public bool                                     IsFriendSupportChara                    { get; set; }

        public static SCharaEditSDCharaIconViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCharaEditSDCharaIconViewModel() { Pointer= p0 };

            value.CharacterInfoId                           = GetInt32(new IntPtr(p + 0x010)); // 024666278158 0x10 CharacterInfoId             ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.IsFriendSupportChara                      = GetBool(new IntPtr(p + 0x014)); // 024666278178 0x14 IsFriendSupportChara        ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
