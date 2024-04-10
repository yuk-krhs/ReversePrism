using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 StatusType                               0001866865D0 ModelEnumType ToggleStatusType ToggleStatusType ToggleStatusType Int32
    // 034 KindType                                 000186685C00 ModelEnumType ToggleKindType ToggleKindType ToggleKindType Int32
    public partial class ImageSetInformation : DataModel
    {
        public ToggleStatusType                         StatusType                              { get; set; }
        public ToggleKindType                           KindType                                { get; set; }

        public static ImageSetInformation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ImageSetInformation() { Pointer= p0 };

            value.StatusType                                = (ToggleStatusType)GetInt32(new IntPtr(p + 0x030)); // 024660CCD180 0x30 StatusType                  ( 0001866865D0 ModelEnumType ToggleStatusType ToggleStatusType ToggleStatusType Int32 )
            value.KindType                                  = (ToggleKindType)GetInt32(new IntPtr(p + 0x034)); // 024660CCD1A0 0x34 KindType                    ( 000186685C00 ModelEnumType ToggleKindType ToggleKindType ToggleKindType Int32 )

            return value;
        }
    }
}
