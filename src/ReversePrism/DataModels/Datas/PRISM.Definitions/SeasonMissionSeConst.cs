using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SheetName                                string IL2CPP_TYPE_STRING
    // 000 SeasonGaugeUp                            SoundKey IL2CPP_TYPE_VALUETYPE
    // 010 SeasonRankUp                             000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 020 SeasonMissionEnd                         000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    public partial class SeasonMissionSeConst : DataModel
    {
        public SoundKey                                 SeasonRankUp                            { get; set; }
        public SoundKey                                 SeasonMissionEnd                        { get; set; }

        public static SeasonMissionSeConst? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionSeConst() { Pointer= p0 };

            value.SeasonRankUp                              = (SoundKey)GetInt32(new IntPtr(p + 0x010)); // 024665EC8950 0x10 SeasonRankUp                ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.SeasonMissionEnd                          = (SoundKey)GetInt32(new IntPtr(p + 0x020)); // 024665EC8970 0x20 SeasonMissionEnd            ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )

            return value;
        }
    }
}
