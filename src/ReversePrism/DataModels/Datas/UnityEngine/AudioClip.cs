using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_PCMReaderCallback                      ModelClassType PCMReaderCallback PCMReaderCallback PCMReaderCallback Pointer
    // 020 M_PCMSetPositionCallback                 ModelClassType PCMSetPositionCallback PCMSetPositionCallback PCMSetPositionCallback Pointer
    public partial class AudioClip : DataModel
    {
        public PCMReaderCallback?                       M_PCMReaderCallback                     { get; set; }
        public PCMSetPositionCallback?                  M_PCMSetPositionCallback                { get; set; }

        public static AudioClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AudioClip() { Pointer= p0 };

            value.M_PCMReaderCallback                       = GetObject<PCMReaderCallback>(new IntPtr(p + 0x018), ReversePrism.DataModels.PCMReaderCallback.FromPointer); // 0x18 M_PCMReaderCallback         ( ModelClassType PCMReaderCallback PCMReaderCallback PCMReaderCallback Pointer )
            value.M_PCMSetPositionCallback                  = GetObject<PCMSetPositionCallback>(new IntPtr(p + 0x020), ReversePrism.DataModels.PCMSetPositionCallback.FromPointer); // 0x20 M_PCMSetPositionCallback    ( ModelClassType PCMSetPositionCallback PCMSetPositionCallback PCMSetPositionCallback Pointer )

            return value;
        }
    }
}
