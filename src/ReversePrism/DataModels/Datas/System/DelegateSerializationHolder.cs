using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Delegate                                 0001866BA8B0 ModelClassType Delegate Delegate Delegate Pointer
    public partial class DelegateSerializationHolder
    {
        public Delegate?                                Delegate                                { get; set; }

        public static DelegateSerializationHolder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DelegateSerializationHolder();

            value.Delegate                                  = GetObject<Delegate>(new IntPtr(p + 0x010), ReversePrism.DataModels.Delegate.FromPointer); // 0270D6A66AB8 0x10 Delegate                    ( 0001866BA8B0 ModelClassType Delegate Delegate Delegate Pointer )

            return value;
        }
    }
}
