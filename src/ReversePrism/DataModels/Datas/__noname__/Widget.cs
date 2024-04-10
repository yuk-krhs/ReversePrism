using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Panel                                  0001865881E0 ModelClassType Panel Panel Panel Pointer
    // 018 M_Parent                                 000186586550 ModelClassType IContainer IContainer IContainer Pointer
    // 020 Flags                                    000186584BC0 ModelEnumType Flags Flags Flags Int32
    // 028 DisplayName                              000186671910 ModelPrimitiveType string string string String
    // 030 Tooltip                                  000186671910 ModelPrimitiveType string string string String
    // 038 QueryPath                                000186671910 ModelPrimitiveType string string string String
    // 040 isHiddenCallback                         Func`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class Widget : DataModel
    {
        public Panel?                                   M_Panel                                 { get; set; }
        public IContainer?                              M_Parent                                { get; set; }
        public Flags                                    Flags                                   { get; set; }
        public string                                   DisplayName                             { get; set; }
        public string                                   Tooltip                                 { get; set; }
        public string                                   QueryPath                               { get; set; }

        public static Widget? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Widget() { Pointer= p0 };

            value.M_Panel                                   = GetObject<Panel>(new IntPtr(p + 0x010), ReversePrism.DataModels.Panel.FromPointer); // 0246690BD588 0x10 M_Panel                     ( 0001865881E0 ModelClassType Panel Panel Panel Pointer )
            value.M_Parent                                  = GetObject<IContainer>(new IntPtr(p + 0x018), ReversePrism.DataModels.IContainer.FromPointer); // 0246690BD5A8 0x18 M_Parent                    ( 000186586550 ModelClassType IContainer IContainer IContainer Pointer )
            value.Flags                                     = (Flags)GetInt32(new IntPtr(p + 0x020)); // 0246690BD5C8 0x20 Flags                       ( 000186584BC0 ModelEnumType Flags Flags Flags Int32 )
            value.DisplayName                               = GetString(new IntPtr(p + 0x028)); // 0246690BD5E8 0x28 DisplayName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Tooltip                                   = GetString(new IntPtr(p + 0x030)); // 0246690BD608 0x30 Tooltip                     ( 000186671910 ModelPrimitiveType string string string String )
            value.QueryPath                                 = GetString(new IntPtr(p + 0x038)); // 0246690BD628 0x38 QueryPath                   ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
