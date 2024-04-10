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
    public partial class PrismView : DataModel
    {
        public string                                   Guid                                    { get; set; }
        public IPrismStreamingObservable?               PrismStreamingObservable                { get; set; }

        public static PrismView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrismView() { Pointer= p0 };

            value.Guid                                      = GetString(new IntPtr(p + 0x020)); // 024664F8B570 0x20 Guid                        ( 000186671910 ModelPrimitiveType string string string String )
            value.PrismStreamingObservable                  = GetObject<IPrismStreamingObservable>(new IntPtr(p + 0x028), ReversePrism.DataModels.IPrismStreamingObservable.FromPointer); // 024664F8B590 0x28 PrismStreamingObservable    ( 0001865DE920 ModelClassType IPrismStreamingObservable IPrismStreamingObservable IPrismStreamingObservable Pointer )

            return value;
        }
    }
}
