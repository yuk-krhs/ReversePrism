using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Delegate                                 ModelClassType Delegate Delegate Delegate Pointer
    public partial class DelegateSerializationHolder : DataModel
    {
        public Delegate?                                Delegate                                { get; set; }

        public static DelegateSerializationHolder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DelegateSerializationHolder() { Pointer= p0 };

            value.Delegate                                  = GetObject<Delegate>(new IntPtr(p + 0x010), ReversePrism.DataModels.Delegate.FromPointer); // 0x10 Delegate                    ( ModelClassType Delegate Delegate Delegate Pointer )

            return value;
        }
    }
}
