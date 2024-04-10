using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Touches                                  000185D04048 ModelEnumListType List`1<RhythmGameTouch> List`1<RhythmGameTouch> List<RhythmGameTouch> Pointer
    // 018 <ScreenToLaneIndex>k__BackingField       Func`2<float, float> IL2CPP_TYPE_GENERICINST
    // 020 Keys                                     000185B8F460 ModelEnumListType KeyCode[] KeyCode[] List<KeyCode> Pointer
    public partial class TouchInputService : DataModel
    {
        public List<RhythmGameTouch>?                   Touches                                 { get; set; }
        public List<KeyCode>?                           Keys                                    { get; set; }

        public static TouchInputService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TouchInputService() { Pointer= p0 };

            value.Touches                                   = GetEnumList<RhythmGameTouch>(new IntPtr(p + 0x010)); // 024664FEC0F0 0x10 Touches                     ( 000185D04048 ModelEnumListType List`1<RhythmGameTouch> List`1<RhythmGameTouch> List<RhythmGameTouch> Pointer )
            value.Keys                                      = GetEnumList<KeyCode>(new IntPtr(p + 0x020)); // 024664FEC130 0x20 Keys                        ( 000185B8F460 ModelEnumListType KeyCode[] KeyCode[] List<KeyCode> Pointer )

            return value;
        }
    }
}
