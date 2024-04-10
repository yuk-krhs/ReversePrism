using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Self                                     0001866CE7E0 ModelClassType DiagnosticsHandler DiagnosticsHandler DiagnosticsHandler Pointer
    // 018 Payload                                  CachedPayload`1<DiagnosticsPayload> IL2CPP_TYPE_GENERICINST
    public partial class SendState : DataModel
    {
        public DiagnosticsHandler?                      Self                                    { get; set; }

        public static SendState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SendState() { Pointer= p0 };

            value.Self                                      = GetObject<DiagnosticsHandler>(new IntPtr(p + 0x010), ReversePrism.DataModels.DiagnosticsHandler.FromPointer); // 02466BE09B60 0x10 Self                        ( 0001866CE7E0 ModelClassType DiagnosticsHandler DiagnosticsHandler DiagnosticsHandler Pointer )

            return value;
        }
    }
}
