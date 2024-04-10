using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Signals                                000185D09CC8 ModelClassListType List`1<SignalAsset> List`1<SignalAsset> List<SignalAsset> Pointer
    // 018 M_Events                                 000185D19ED8 ModelClassListType List`1<UnityEvent> List`1<UnityEvent> List<UnityEvent> Pointer
    public partial class EventKeyValue : DataModel
    {
        public List<SignalAsset>?                       M_Signals                               { get; set; }
        public List<UnityEvent>?                        M_Events                                { get; set; }

        public static EventKeyValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventKeyValue() { Pointer= p0 };

            value.M_Signals                                 = GetObjectList<SignalAsset>(new IntPtr(p + 0x010), ReversePrism.DataModels.SignalAsset.FromPointer); // 02466B2F5B38 0x10 M_Signals                   ( 000185D09CC8 ModelClassListType List`1<SignalAsset> List`1<SignalAsset> List<SignalAsset> Pointer )
            value.M_Events                                  = GetObjectList<UnityEvent>(new IntPtr(p + 0x018), ReversePrism.DataModels.UnityEvent.FromPointer); // 02466B2F5B58 0x18 M_Events                    ( 000185D19ED8 ModelClassListType List`1<UnityEvent> List`1<UnityEvent> List<UnityEvent> Pointer )

            return value;
        }
    }
}
