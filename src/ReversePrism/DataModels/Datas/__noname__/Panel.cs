using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Flags                                    ModelEnumType Flags Flags Flags Int32
    // 018 DisplayName                              ModelPrimitiveType string string string String
    // 020 GroupIndex                               ModelPrimitiveType int int int Int32
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

            value.Flags                                     = (Flags)GetInt32(new IntPtr(p + 0x010)); // 0x10 Flags                       ( ModelEnumType Flags Flags Flags Int32 )
            value.DisplayName                               = GetString(new IntPtr(p + 0x018)); // 0x18 DisplayName                 ( ModelPrimitiveType string string string String )
            value.GroupIndex                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 GroupIndex                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
