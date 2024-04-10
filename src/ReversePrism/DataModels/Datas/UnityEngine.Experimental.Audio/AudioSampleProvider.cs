using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SampleFramesAvailable                    0001866D5280 ModelClassType SampleFramesHandler SampleFramesHandler SampleFramesHandler Pointer
    // 018 SampleFramesOverflow                     0001866D5280 ModelClassType SampleFramesHandler SampleFramesHandler SampleFramesHandler Pointer
    public partial class AudioSampleProvider : DataModel
    {
        public SampleFramesHandler?                     SampleFramesAvailable                   { get; set; }
        public SampleFramesHandler?                     SampleFramesOverflow                    { get; set; }

        public static AudioSampleProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AudioSampleProvider() { Pointer= p0 };

            value.SampleFramesAvailable                     = GetObject<SampleFramesHandler>(new IntPtr(p + 0x010), ReversePrism.DataModels.SampleFramesHandler.FromPointer); // 0245A21BEDC0 0x10 SampleFramesAvailable       ( 0001866D5280 ModelClassType SampleFramesHandler SampleFramesHandler SampleFramesHandler Pointer )
            value.SampleFramesOverflow                      = GetObject<SampleFramesHandler>(new IntPtr(p + 0x018), ReversePrism.DataModels.SampleFramesHandler.FromPointer); // 0245A21BEDE0 0x18 SampleFramesOverflow        ( 0001866D5280 ModelClassType SampleFramesHandler SampleFramesHandler SampleFramesHandler Pointer )

            return value;
        }
    }
}
