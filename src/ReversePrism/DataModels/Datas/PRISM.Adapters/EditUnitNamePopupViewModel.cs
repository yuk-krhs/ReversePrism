using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ForProduce                               ModelPrimitiveType bool bool bool Bool
    // 018 CurrentName                              ModelPrimitiveType string string string String
    // 020 MaxNameLength                            ModelPrimitiveType int int int Int32
    // 024 InputOverCount                           ModelPrimitiveType int int int Int32
    public partial class EditUnitNamePopupViewModel : DataModel
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
            var value   = new EditUnitNamePopupViewModel() { Pointer= p0 };

            value.ForProduce                                = GetBool(new IntPtr(p + 0x010)); // 0x10 ForProduce                  ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentName                               = GetString(new IntPtr(p + 0x018)); // 0x18 CurrentName                 ( ModelPrimitiveType string string string String )
            value.MaxNameLength                             = GetInt32(new IntPtr(p + 0x020)); // 0x20 MaxNameLength               ( ModelPrimitiveType int int int Int32 )
            value.InputOverCount                            = GetInt32(new IntPtr(p + 0x024)); // 0x24 InputOverCount              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
