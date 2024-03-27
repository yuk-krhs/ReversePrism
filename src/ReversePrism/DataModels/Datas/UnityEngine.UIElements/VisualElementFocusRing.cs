using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Root                                     0001866B34A0 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 018 DefaultFocusOrder                        0001866FB820 ModelEnumType DefaultFocusOrder DefaultFocusOrder DefaultFocusOrder Int32
    // 020 M_FocusRing                              000185D303C8 ModelClassListType List`1<FocusRingRecord> List`1<FocusRingRecord> List<FocusRingRecord> Pointer
    public partial class VisualElementFocusRing
    {
        public VisualElement?                           Root                                    { get; set; }
        public DefaultFocusOrder                        DefaultFocusOrder                       { get; set; }
        public List<FocusRingRecord>?                   M_FocusRing                             { get; set; }

        public static VisualElementFocusRing? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VisualElementFocusRing();

            value.Root                                      = GetObject<VisualElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualElement.FromPointer); // 02700685B9E0 0x10 Root                        ( 0001866B34A0 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.DefaultFocusOrder                         = (DefaultFocusOrder)GetInt32(new IntPtr(p + 0x018)); // 02700685BA00 0x18 DefaultFocusOrder           ( 0001866FB820 ModelEnumType DefaultFocusOrder DefaultFocusOrder DefaultFocusOrder Int32 )
            value.M_FocusRing                               = GetObjectList<FocusRingRecord>(new IntPtr(p + 0x020), ReversePrism.DataModels.FocusRingRecord.FromPointer); // 02700685BA20 0x20 M_FocusRing                 ( 000185D303C8 ModelClassListType List`1<FocusRingRecord> List`1<FocusRingRecord> List<FocusRingRecord> Pointer )

            return value;
        }
    }
}
