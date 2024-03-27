using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 020 Idols                                    000185B90FE0 ModelClassListType LiveMVIdol[] LiveMVIdol[] List<LiveMVIdol> Pointer
    // 028 MusicData                                000186665050 ModelClassType MusicData MusicData MusicData Pointer
    public partial class LiveMVUnit
    {
        public string                                   Name                                    { get; set; }
        public int                                      Id                                      { get; set; }
        public List<LiveMVIdol>?                        Idols                                   { get; set; }
        public MusicData?                               MusicData                               { get; set; }

        public static LiveMVUnit? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVUnit();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D518AA80 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Id                                        = GetInt32(new IntPtr(p + 0x018)); // 0270D518AAA0 0x18 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Idols                                     = GetObjectList<LiveMVIdol>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveMVIdol.FromPointer); // 0270D518AAC0 0x20 Idols                       ( 000185B90FE0 ModelClassListType LiveMVIdol[] LiveMVIdol[] List<LiveMVIdol> Pointer )
            value.MusicData                                 = GetObject<MusicData>(new IntPtr(p + 0x028), ReversePrism.DataModels.MusicData.FromPointer); // 0270D518AAE0 0x28 MusicData                   ( 000186665050 ModelClassType MusicData MusicData MusicData Pointer )

            return value;
        }
    }
}
