using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 <TryCalculateUnitParameterBonus>k__BackingField Action`1<LiveUnit> IL2CPP_TYPE_GENERICINST
    // 048 MusicData                                ModelClassType MusicData MusicData MusicData Pointer
    public partial class LiveUnitListCellContext : DataModel
    {
        public MusicData?                               MusicData                               { get; set; }

        public static LiveUnitListCellContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitListCellContext() { Pointer= p0 };

            value.MusicData                                 = GetObject<MusicData>(new IntPtr(p + 0x048), ReversePrism.DataModels.MusicData.FromPointer); // 0x48 MusicData                   ( ModelClassType MusicData MusicData MusicData Pointer )

            return value;
        }
    }
}
