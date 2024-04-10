using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 VirtualVoiceUsage                        0001865429F0 ModelEnumType ResourceUsage ResourceUsage ResourceUsage Int32
    // 018 SequenceUsage                            0001865429F0 ModelEnumType ResourceUsage ResourceUsage ResourceUsage Int32
    // 020 SequenceTrackUsage                       0001865429F0 ModelEnumType ResourceUsage ResourceUsage ResourceUsage Int32
    // 028 SequenceTrackItemUsage                   0001865429F0 ModelEnumType ResourceUsage ResourceUsage ResourceUsage Int32
    public partial class ResourcesInfo : DataModel
    {
        public ResourceUsage                            VirtualVoiceUsage                       { get; set; }
        public ResourceUsage                            SequenceUsage                           { get; set; }
        public ResourceUsage                            SequenceTrackUsage                      { get; set; }
        public ResourceUsage                            SequenceTrackItemUsage                  { get; set; }

        public static ResourcesInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResourcesInfo() { Pointer= p0 };

            value.VirtualVoiceUsage                         = (ResourceUsage)GetInt32(new IntPtr(p + 0x010)); // 02466AD28D60 0x10 VirtualVoiceUsage           ( 0001865429F0 ModelEnumType ResourceUsage ResourceUsage ResourceUsage Int32 )
            value.SequenceUsage                             = (ResourceUsage)GetInt32(new IntPtr(p + 0x018)); // 02466AD28D80 0x18 SequenceUsage               ( 0001865429F0 ModelEnumType ResourceUsage ResourceUsage ResourceUsage Int32 )
            value.SequenceTrackUsage                        = (ResourceUsage)GetInt32(new IntPtr(p + 0x020)); // 02466AD28DA0 0x20 SequenceTrackUsage          ( 0001865429F0 ModelEnumType ResourceUsage ResourceUsage ResourceUsage Int32 )
            value.SequenceTrackItemUsage                    = (ResourceUsage)GetInt32(new IntPtr(p + 0x028)); // 02466AD28DC0 0x28 SequenceTrackItemUsage      ( 0001865429F0 ModelEnumType ResourceUsage ResourceUsage ResourceUsage Int32 )

            return value;
        }
    }
}
