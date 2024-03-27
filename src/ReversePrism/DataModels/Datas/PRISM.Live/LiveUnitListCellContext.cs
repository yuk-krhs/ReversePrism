using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 <TryCalculateUnitParameterBonus>k__BackingField Action`1<LiveUnit> IL2CPP_TYPE_GENERICINST
    // 040 MusicData                                000186664B50 ModelClassType MusicData MusicData MusicData Pointer
    public partial class LiveUnitListCellContext
    {
        public MusicData?                               MusicData                               { get; set; }

        public static LiveUnitListCellContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitListCellContext();

            value.MusicData                                 = GetObject<MusicData>(new IntPtr(p + 0x040), ReversePrism.DataModels.MusicData.FromPointer); // 0270D52B1110 0x40 MusicData                   ( 000186664B50 ModelClassType MusicData MusicData MusicData Pointer )

            return value;
        }
    }
}
