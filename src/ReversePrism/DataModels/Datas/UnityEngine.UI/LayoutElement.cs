using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_IgnoreLayout                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 024 M_MinWidth                               0001866656B0 ModelPrimitiveType float float float Single
    // 028 M_MinHeight                              0001866656B0 ModelPrimitiveType float float float Single
    // 02C M_PreferredWidth                         0001866656B0 ModelPrimitiveType float float float Single
    // 030 M_PreferredHeight                        0001866656B0 ModelPrimitiveType float float float Single
    // 034 M_FlexibleWidth                          0001866656B0 ModelPrimitiveType float float float Single
    // 038 M_FlexibleHeight                         0001866656B0 ModelPrimitiveType float float float Single
    // 03C M_LayoutPriority                         0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LayoutElement
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
            var value   = new LayoutElement();

            value.M_IgnoreLayout                            = GetBool(new IntPtr(p + 0x020)); // 027003F91788 0x20 M_IgnoreLayout              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_MinWidth                                = GetSingle(new IntPtr(p + 0x024)); // 027003F917A8 0x24 M_MinWidth                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_MinHeight                               = GetSingle(new IntPtr(p + 0x028)); // 027003F917C8 0x28 M_MinHeight                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_PreferredWidth                          = GetSingle(new IntPtr(p + 0x02C)); // 027003F917E8 0x2C M_PreferredWidth            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_PreferredHeight                         = GetSingle(new IntPtr(p + 0x030)); // 027003F91808 0x30 M_PreferredHeight           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_FlexibleWidth                           = GetSingle(new IntPtr(p + 0x034)); // 027003F91828 0x34 M_FlexibleWidth             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_FlexibleHeight                          = GetSingle(new IntPtr(p + 0x038)); // 027003F91848 0x38 M_FlexibleHeight            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_LayoutPriority                          = GetInt32(new IntPtr(p + 0x03C)); // 027003F91868 0x3C M_LayoutPriority            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
