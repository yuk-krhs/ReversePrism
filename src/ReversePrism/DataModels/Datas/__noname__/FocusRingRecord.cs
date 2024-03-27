using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_AutoIndex                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 M_Focusable                              0001865D4190 ModelClassType Focusable Focusable Focusable Pointer
    // 020 M_IsSlot                                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 028 M_ScopeNavigationOrder                   000185D30418 ModelClassListType List`1<FocusRingRecord> List`1<FocusRingRecord> List<FocusRingRecord> Pointer
    public partial class FocusRingRecord
    {
        public int                                      M_AutoIndex                             { get; set; }
        public Focusable?                               M_Focusable                             { get; set; }
        public bool                                     M_IsSlot                                { get; set; }
        public List<FocusRingRecord>?                   M_ScopeNavigationOrder                  { get; set; }

        public static FocusRingRecord? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FocusRingRecord();

            value.M_AutoIndex                               = GetInt32(new IntPtr(p + 0x010)); // 02700685BB00 0x10 M_AutoIndex                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.M_Focusable                               = GetObject<Focusable>(new IntPtr(p + 0x018), ReversePrism.DataModels.Focusable.FromPointer); // 02700685BB20 0x18 M_Focusable                 ( 0001865D4190 ModelClassType Focusable Focusable Focusable Pointer )
            value.M_IsSlot                                  = GetBool(new IntPtr(p + 0x020)); // 02700685BB40 0x20 M_IsSlot                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.M_ScopeNavigationOrder                    = GetObjectList<FocusRingRecord>(new IntPtr(p + 0x028), ReversePrism.DataModels.FocusRingRecord.FromPointer); // 02700685BB60 0x28 M_ScopeNavigationOrder      ( 000185D30418 ModelClassListType List`1<FocusRingRecord> List`1<FocusRingRecord> List<FocusRingRecord> Pointer )

            return value;
        }
    }
}
