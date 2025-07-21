using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 TryHandler                               ModelClassType TryFaultHandler TryFaultHandler TryFaultHandler Pointer
    public partial class EnterTryFaultInstruction : DataModel
    {
        public TryFaultHandler?                         TryHandler                              { get; set; }

        public static EnterTryFaultInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnterTryFaultInstruction() { Pointer= p0 };

            value.TryHandler                                = GetObject<TryFaultHandler>(new IntPtr(p + 0x018), ReversePrism.DataModels.TryFaultHandler.FromPointer); // 0x18 TryHandler                  ( ModelClassType TryFaultHandler TryFaultHandler TryFaultHandler Pointer )

            return value;
        }
    }
}
