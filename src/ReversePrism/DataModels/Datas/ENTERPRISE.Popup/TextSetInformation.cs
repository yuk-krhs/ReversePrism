using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 StatusType                               0001866865D0 ModelEnumType ToggleStatusType ToggleStatusType ToggleStatusType Int32
    // 03C KindType                                 000186685C00 ModelEnumType ToggleKindType ToggleKindType ToggleKindType Int32
    public partial class TextSetInformation
    {
        public ToggleStatusType                         StatusType                              { get; set; }
        public ToggleKindType                           KindType                                { get; set; }

        public static TextSetInformation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextSetInformation();

            value.StatusType                                = (ToggleStatusType)GetInt32(new IntPtr(p + 0x038)); // 0270D0CA2FB8 0x38 StatusType                  ( 0001866865D0 ModelEnumType ToggleStatusType ToggleStatusType ToggleStatusType Int32 )
            value.KindType                                  = (ToggleKindType)GetInt32(new IntPtr(p + 0x03C)); // 0270D0CA2FD8 0x3C KindType                    ( 000186685C00 ModelEnumType ToggleKindType ToggleKindType ToggleKindType Int32 )

            return value;
        }
    }
}
