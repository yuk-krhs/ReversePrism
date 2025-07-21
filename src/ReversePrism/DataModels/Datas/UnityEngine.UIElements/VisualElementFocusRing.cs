using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Root                                     ModelClassType VisualElement VisualElement VisualElement Pointer
    // 018 DefaultFocusOrder                        ModelEnumType DefaultFocusOrder DefaultFocusOrder DefaultFocusOrder Int32
    // 020 M_FocusRing                              ModelClassListType List`1<FocusRingRecord> List`1<FocusRingRecord> List<FocusRingRecord> Pointer
    public partial class VisualElementFocusRing : DataModel
    {
        public VisualElement?                           Root                                    { get; set; }
        public DefaultFocusOrder                        DefaultFocusOrder                       { get; set; }
        public List<FocusRingRecord>?                   M_FocusRing                             { get; set; }

        public static VisualElementFocusRing? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VisualElementFocusRing() { Pointer= p0 };

            value.Root                                      = GetObject<VisualElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualElement.FromPointer); // 0x10 Root                        ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.DefaultFocusOrder                         = (DefaultFocusOrder)GetInt32(new IntPtr(p + 0x018)); // 0x18 DefaultFocusOrder           ( ModelEnumType DefaultFocusOrder DefaultFocusOrder DefaultFocusOrder Int32 )
            value.M_FocusRing                               = GetObjectList<FocusRingRecord>(new IntPtr(p + 0x020), ReversePrism.DataModels.FocusRingRecord.FromPointer); // 0x20 M_FocusRing                 ( ModelClassListType List`1<FocusRingRecord> List`1<FocusRingRecord> List<FocusRingRecord> Pointer )

            return value;
        }
    }
}
