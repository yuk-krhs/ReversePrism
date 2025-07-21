using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 StatusType                               ModelEnumType ToggleStatusType ToggleStatusType ToggleStatusType Int32
    // 03C KindType                                 ModelEnumType ToggleKindType ToggleKindType ToggleKindType Int32
    public partial class TextSetInformation : DataModel
    {
        public ToggleStatusType                         StatusType                              { get; set; }
        public ToggleKindType                           KindType                                { get; set; }

        public static TextSetInformation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextSetInformation() { Pointer= p0 };

            value.StatusType                                = (ToggleStatusType)GetInt32(new IntPtr(p + 0x038)); // 0x38 StatusType                  ( ModelEnumType ToggleStatusType ToggleStatusType ToggleStatusType Int32 )
            value.KindType                                  = (ToggleKindType)GetInt32(new IntPtr(p + 0x03C)); // 0x3C KindType                    ( ModelEnumType ToggleKindType ToggleKindType ToggleKindType Int32 )

            return value;
        }
    }
}
