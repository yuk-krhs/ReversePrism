using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_IgnoreLayout                           ModelPrimitiveType bool bool bool Bool
    // 024 M_MinWidth                               ModelPrimitiveType float float float Single
    // 028 M_MinHeight                              ModelPrimitiveType float float float Single
    // 02C M_PreferredWidth                         ModelPrimitiveType float float float Single
    // 030 M_PreferredHeight                        ModelPrimitiveType float float float Single
    // 034 M_FlexibleWidth                          ModelPrimitiveType float float float Single
    // 038 M_FlexibleHeight                         ModelPrimitiveType float float float Single
    // 03C M_LayoutPriority                         ModelPrimitiveType int int int Int32
    public partial class LayoutElement : DataModel
    {
        public bool                                     M_IgnoreLayout                          { get; set; }
        public float                                    M_MinWidth                              { get; set; }
        public float                                    M_MinHeight                             { get; set; }
        public float                                    M_PreferredWidth                        { get; set; }
        public float                                    M_PreferredHeight                       { get; set; }
        public float                                    M_FlexibleWidth                         { get; set; }
        public float                                    M_FlexibleHeight                        { get; set; }
        public int                                      M_LayoutPriority                        { get; set; }

        public static LayoutElement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LayoutElement() { Pointer= p0 };

            value.M_IgnoreLayout                            = GetBool(new IntPtr(p + 0x020)); // 0x20 M_IgnoreLayout              ( ModelPrimitiveType bool bool bool Bool )
            value.M_MinWidth                                = GetSingle(new IntPtr(p + 0x024)); // 0x24 M_MinWidth                  ( ModelPrimitiveType float float float Single )
            value.M_MinHeight                               = GetSingle(new IntPtr(p + 0x028)); // 0x28 M_MinHeight                 ( ModelPrimitiveType float float float Single )
            value.M_PreferredWidth                          = GetSingle(new IntPtr(p + 0x02C)); // 0x2C M_PreferredWidth            ( ModelPrimitiveType float float float Single )
            value.M_PreferredHeight                         = GetSingle(new IntPtr(p + 0x030)); // 0x30 M_PreferredHeight           ( ModelPrimitiveType float float float Single )
            value.M_FlexibleWidth                           = GetSingle(new IntPtr(p + 0x034)); // 0x34 M_FlexibleWidth             ( ModelPrimitiveType float float float Single )
            value.M_FlexibleHeight                          = GetSingle(new IntPtr(p + 0x038)); // 0x38 M_FlexibleHeight            ( ModelPrimitiveType float float float Single )
            value.M_LayoutPriority                          = GetInt32(new IntPtr(p + 0x03C)); // 0x3C M_LayoutPriority            ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
