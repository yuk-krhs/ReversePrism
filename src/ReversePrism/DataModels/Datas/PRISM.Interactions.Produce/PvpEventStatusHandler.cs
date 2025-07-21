using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 OnEventStatusOpened                      ModelClassType UnityEvent UnityEvent UnityEvent Pointer
    // 028 OnEventStatusAggregation                 ModelClassType UnityEvent UnityEvent UnityEvent Pointer
    // 030 OnEventStatusDefault                     ModelClassType UnityEvent UnityEvent UnityEvent Pointer
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

            value.OnEventStatusOpened                       = GetObject<UnityEvent>(new IntPtr(p + 0x020), ReversePrism.DataModels.UnityEvent.FromPointer); // 0x20 OnEventStatusOpened         ( ModelClassType UnityEvent UnityEvent UnityEvent Pointer )
            value.OnEventStatusAggregation                  = GetObject<UnityEvent>(new IntPtr(p + 0x028), ReversePrism.DataModels.UnityEvent.FromPointer); // 0x28 OnEventStatusAggregation    ( ModelClassType UnityEvent UnityEvent UnityEvent Pointer )
            value.OnEventStatusDefault                      = GetObject<UnityEvent>(new IntPtr(p + 0x030), ReversePrism.DataModels.UnityEvent.FromPointer); // 0x30 OnEventStatusDefault        ( ModelClassType UnityEvent UnityEvent UnityEvent Pointer )

            return value;
        }
    }
}
