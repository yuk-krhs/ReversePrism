using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 CanSelectMusic                           ModelPrimitiveType bool bool bool Bool
    public partial class MusicRateTargetMusicListViewContext : DataModel
    {
        public bool                                     CanSelectMusic                          { get; set; }

        public static MusicRateTargetMusicListViewContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRateTargetMusicListViewContext() { Pointer= p0 };

            value.CanSelectMusic                            = GetBool(new IntPtr(p + 0x040)); // 0x40 CanSelectMusic              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
