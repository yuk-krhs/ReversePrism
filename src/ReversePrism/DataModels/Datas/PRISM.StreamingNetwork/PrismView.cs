using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Guid                                     000186671910 ModelPrimitiveType string string string String
    // 028 PrismStreamingObservable                 0001865DE920 ModelClassType IPrismStreamingObservable IPrismStreamingObservable IPrismStreamingObservable Pointer
    public partial class PrismView
    {
        public string                                   Guid                                    { get; set; }
        public IPrismStreamingObservable?               PrismStreamingObservable                { get; set; }

        public static PrismView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrismView();

            value.Guid                                      = GetString(new IntPtr(p + 0x020)); // 0270D4F24AC0 0x20 Guid                        ( 000186671910 ModelPrimitiveType string string string String )
            value.PrismStreamingObservable                  = GetObject<IPrismStreamingObservable>(new IntPtr(p + 0x028), ReversePrism.DataModels.IPrismStreamingObservable.FromPointer); // 0270D4F24AE0 0x28 PrismStreamingObservable    ( 0001865DE920 ModelClassType IPrismStreamingObservable IPrismStreamingObservable IPrismStreamingObservable Pointer )

            return value;
        }
    }
}
