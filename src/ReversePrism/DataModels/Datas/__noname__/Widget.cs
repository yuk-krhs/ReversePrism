using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Panel                                  ModelClassType Panel Panel Panel Pointer
    // 018 M_Parent                                 ModelClassType IContainer IContainer IContainer Pointer
    // 020 Flags                                    ModelEnumType Flags Flags Flags Int32
    // 028 DisplayName                              ModelPrimitiveType string string string String
    // 030 Tooltip                                  ModelPrimitiveType string string string String
    // 038 QueryPath                                ModelPrimitiveType string string string String
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

            value.M_Panel                                   = GetObject<Panel>(new IntPtr(p + 0x010), ReversePrism.DataModels.Panel.FromPointer); // 0x10 M_Panel                     ( ModelClassType Panel Panel Panel Pointer )
            value.M_Parent                                  = GetObject<IContainer>(new IntPtr(p + 0x018), ReversePrism.DataModels.IContainer.FromPointer); // 0x18 M_Parent                    ( ModelClassType IContainer IContainer IContainer Pointer )
            value.Flags                                     = (Flags)GetInt32(new IntPtr(p + 0x020)); // 0x20 Flags                       ( ModelEnumType Flags Flags Flags Int32 )
            value.DisplayName                               = GetString(new IntPtr(p + 0x028)); // 0x28 DisplayName                 ( ModelPrimitiveType string string string String )
            value.Tooltip                                   = GetString(new IntPtr(p + 0x030)); // 0x30 Tooltip                     ( ModelPrimitiveType string string string String )
            value.QueryPath                                 = GetString(new IntPtr(p + 0x038)); // 0x38 QueryPath                   ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
