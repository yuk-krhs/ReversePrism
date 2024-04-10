using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Mixer                                    00018674C490 ModelEnumType Playable Playable Playable Int32
    // 020 ParentMixer                              00018674C490 ModelEnumType Playable Playable Playable Int32
    // 030 Port                                     0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class WeightInfo : DataModel
    {
        public Playable                                 Mixer                                   { get; set; }
        public Playable                                 ParentMixer                             { get; set; }
        public int                                      Port                                    { get; set; }

        public static WeightInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WeightInfo() { Pointer= p0 };

            value.Mixer                                     = (Playable)GetInt32(new IntPtr(p + 0x010)); // 02466B294230 0x10 Mixer                       ( 00018674C490 ModelEnumType Playable Playable Playable Int32 )
            value.ParentMixer                               = (Playable)GetInt32(new IntPtr(p + 0x020)); // 02466B294250 0x20 ParentMixer                 ( 00018674C490 ModelEnumType Playable Playable Playable Int32 )
            value.Port                                      = GetInt32(new IntPtr(p + 0x030)); // 02466B294270 0x30 Port                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
