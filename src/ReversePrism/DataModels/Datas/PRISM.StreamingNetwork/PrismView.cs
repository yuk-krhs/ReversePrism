using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Guid                                     ModelPrimitiveType string string string String
    // 028 PrismStreamingObservable                 ModelClassType IPrismStreamingObservable IPrismStreamingObservable IPrismStreamingObservable Pointer
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

            value.Guid                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Guid                        ( ModelPrimitiveType string string string String )
            value.PrismStreamingObservable                  = GetObject<IPrismStreamingObservable>(new IntPtr(p + 0x028), ReversePrism.DataModels.IPrismStreamingObservable.FromPointer); // 0x28 PrismStreamingObservable    ( ModelClassType IPrismStreamingObservable IPrismStreamingObservable IPrismStreamingObservable Pointer )

            return value;
        }
    }
}
