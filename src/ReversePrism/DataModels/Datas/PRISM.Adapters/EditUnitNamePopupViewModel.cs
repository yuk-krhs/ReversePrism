using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ForProduce                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 CurrentName                              000186671910 ModelPrimitiveType string string string String
    // 020 MaxNameLength                            0001865F4260 ModelPrimitiveType int int int Int32
    // 024 InputOverCount                           0001865F4260 ModelPrimitiveType int int int Int32
    public partial class EditUnitNamePopupViewModel
    {
        public bool                                     ForProduce                              { get; set; }
        public string                                   CurrentName                             { get; set; }
        public int                                      MaxNameLength                           { get; set; }
        public int                                      InputOverCount                          { get; set; }

        public static EditUnitNamePopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EditUnitNamePopupViewModel();

            value.ForProduce                                = GetBool(new IntPtr(p + 0x010)); // 0270D5F2CAC0 0x10 ForProduce                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CurrentName                               = GetString(new IntPtr(p + 0x018)); // 0270D5F2CAE0 0x18 CurrentName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.MaxNameLength                             = GetInt32(new IntPtr(p + 0x020)); // 0270D5F2CB00 0x20 MaxNameLength               ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.InputOverCount                            = GetInt32(new IntPtr(p + 0x024)); // 0270D5F2CB20 0x24 InputOverCount              ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
