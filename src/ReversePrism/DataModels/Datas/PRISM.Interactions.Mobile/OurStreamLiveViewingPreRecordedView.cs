using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 StreamingCDN                             ModelClassType PrismStreamingCDN PrismStreamingCDN PrismStreamingCDN Pointer
    // 028 SoundView                                ModelClassType SoundView SoundView SoundView Pointer
    // 030 IsPlayStart                              ModelPrimitiveType bool bool bool Bool
    public partial class OurStreamLiveViewingPreRecordedView : DataModel
    {
        public PrismStreamingCDN?                       StreamingCDN                            { get; set; }
        public SoundView?                               SoundView                               { get; set; }
        public bool                                     IsPlayStart                             { get; set; }

        public static OurStreamLiveViewingPreRecordedView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamLiveViewingPreRecordedView() { Pointer= p0 };

            value.StreamingCDN                              = GetObject<PrismStreamingCDN>(new IntPtr(p + 0x020), ReversePrism.DataModels.PrismStreamingCDN.FromPointer); // 0x20 StreamingCDN                ( ModelClassType PrismStreamingCDN PrismStreamingCDN PrismStreamingCDN Pointer )
            value.SoundView                                 = GetObject<SoundView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SoundView.FromPointer); // 0x28 SoundView                   ( ModelClassType SoundView SoundView SoundView Pointer )
            value.IsPlayStart                               = GetBool(new IntPtr(p + 0x030)); // 0x30 IsPlayStart                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
