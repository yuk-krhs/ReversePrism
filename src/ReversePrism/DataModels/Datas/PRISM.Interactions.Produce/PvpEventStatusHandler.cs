using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 OnEventStatusOpened                      0001866A1810 ModelClassType UnityEvent UnityEvent UnityEvent Pointer
    // 028 OnEventStatusAggregation                 0001866A1810 ModelClassType UnityEvent UnityEvent UnityEvent Pointer
    // 030 OnEventStatusDefault                     0001866A1810 ModelClassType UnityEvent UnityEvent UnityEvent Pointer
    public partial class PvpEventStatusHandler : DataModel
    {
        public UnityEvent?                              OnEventStatusOpened                     { get; set; }
        public UnityEvent?                              OnEventStatusAggregation                { get; set; }
        public UnityEvent?                              OnEventStatusDefault                    { get; set; }

        public static PvpEventStatusHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpEventStatusHandler() { Pointer= p0 };

            value.OnEventStatusOpened                       = GetObject<UnityEvent>(new IntPtr(p + 0x020), ReversePrism.DataModels.UnityEvent.FromPointer); // 02466A0F5B58 0x20 OnEventStatusOpened         ( 0001866A1810 ModelClassType UnityEvent UnityEvent UnityEvent Pointer )
            value.OnEventStatusAggregation                  = GetObject<UnityEvent>(new IntPtr(p + 0x028), ReversePrism.DataModels.UnityEvent.FromPointer); // 02466A0F5B78 0x28 OnEventStatusAggregation    ( 0001866A1810 ModelClassType UnityEvent UnityEvent UnityEvent Pointer )
            value.OnEventStatusDefault                      = GetObject<UnityEvent>(new IntPtr(p + 0x030), ReversePrism.DataModels.UnityEvent.FromPointer); // 02466A0F5B98 0x30 OnEventStatusDefault        ( 0001866A1810 ModelClassType UnityEvent UnityEvent UnityEvent Pointer )

            return value;
        }
    }
}
