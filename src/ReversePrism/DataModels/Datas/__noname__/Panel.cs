using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Flags                                    000186584BC0 ModelEnumType Flags Flags Flags Int32
    // 018 DisplayName                              000186671910 ModelPrimitiveType string string string String
    // 020 GroupIndex                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 <children>k__BackingField                ObservableList`1<Widget> IL2CPP_TYPE_GENERICINST
    // 030 onSetDirty                               Action`1<Panel> IL2CPP_TYPE_GENERICINST
    public partial class Panel : DataModel
    {
        public Flags                                    Flags                                   { get; set; }
        public string                                   DisplayName                             { get; set; }
        public int                                      GroupIndex                              { get; set; }

        public static Panel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Panel() { Pointer= p0 };

            value.Flags                                     = (Flags)GetInt32(new IntPtr(p + 0x010)); // 0246690BE360 0x10 Flags                       ( 000186584BC0 ModelEnumType Flags Flags Flags Int32 )
            value.DisplayName                               = GetString(new IntPtr(p + 0x018)); // 0246690BE380 0x18 DisplayName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.GroupIndex                                = GetInt32(new IntPtr(p + 0x020)); // 0246690BE3A0 0x20 GroupIndex                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
