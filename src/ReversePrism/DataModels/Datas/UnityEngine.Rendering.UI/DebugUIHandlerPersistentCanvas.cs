using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Panel                                    000186630900 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 ValuePrefab                              000186630900 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 030 M_Items                                  000185CD7108 ModelClassListType List`1<DebugUIHandlerValue> List`1<DebugUIHandlerValue> List<DebugUIHandlerValue> Pointer
    // 038 M_ValueTupleWidgets                      000185D21A08 ModelClassListType List`1<ValueTuple> List`1<ValueTuple> List<ValueTuple> Pointer
    public partial class DebugUIHandlerPersistentCanvas
    {
        public RectTransform?                           Panel                                   { get; set; }
        public RectTransform?                           ValuePrefab                             { get; set; }
        public List<DebugUIHandlerValue>?               M_Items                                 { get; set; }
        public List<ValueTuple>?                        M_ValueTupleWidgets                     { get; set; }

        public static DebugUIHandlerPersistentCanvas? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerPersistentCanvas();

            value.Panel                                     = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D916A6F8 0x20 Panel                       ( 000186630900 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ValuePrefab                               = GetObject<RectTransform>(new IntPtr(p + 0x028), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D916A718 0x28 ValuePrefab                 ( 000186630900 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_Items                                   = GetObjectList<DebugUIHandlerValue>(new IntPtr(p + 0x030), ReversePrism.DataModels.DebugUIHandlerValue.FromPointer); // 0270D916A738 0x30 M_Items                     ( 000185CD7108 ModelClassListType List`1<DebugUIHandlerValue> List`1<DebugUIHandlerValue> List<DebugUIHandlerValue> Pointer )
            value.M_ValueTupleWidgets                       = GetObjectList<ValueTuple>(new IntPtr(p + 0x038), ReversePrism.DataModels.ValueTuple.FromPointer); // 0270D916A758 0x38 M_ValueTupleWidgets         ( 000185D21A08 ModelClassListType List`1<ValueTuple> List`1<ValueTuple> List<ValueTuple> Pointer )

            return value;
        }
    }
}
