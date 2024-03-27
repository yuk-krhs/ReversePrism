using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TopNode                                  0001866ED690 ModelClassType DoubleLinkAxis DoubleLinkAxis DoubleLinkAxis Pointer
    // 018 RootNode                                 0001866ED690 ModelClassType DoubleLinkAxis DoubleLinkAxis DoubleLinkAxis Pointer
    // 020 IsAttribute                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 021 IsDss                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 022 IsSelfAxis                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ForwardAxis
    {
        public DoubleLinkAxis?                          TopNode                                 { get; set; }
        public DoubleLinkAxis?                          RootNode                                { get; set; }
        public bool                                     IsAttribute                             { get; set; }
        public bool                                     IsDss                                   { get; set; }
        public bool                                     IsSelfAxis                              { get; set; }

        public static ForwardAxis? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ForwardAxis();

            value.TopNode                                   = GetObject<DoubleLinkAxis>(new IntPtr(p + 0x010), ReversePrism.DataModels.DoubleLinkAxis.FromPointer); // 0270D74D4FB0 0x10 TopNode                     ( 0001866ED690 ModelClassType DoubleLinkAxis DoubleLinkAxis DoubleLinkAxis Pointer )
            value.RootNode                                  = GetObject<DoubleLinkAxis>(new IntPtr(p + 0x018), ReversePrism.DataModels.DoubleLinkAxis.FromPointer); // 0270D74D4FD0 0x18 RootNode                    ( 0001866ED690 ModelClassType DoubleLinkAxis DoubleLinkAxis DoubleLinkAxis Pointer )
            value.IsAttribute                               = GetBool(new IntPtr(p + 0x020)); // 0270D74D4FF0 0x20 IsAttribute                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsDss                                     = GetBool(new IntPtr(p + 0x021)); // 0270D74D5010 0x21 IsDss                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsSelfAxis                                = GetBool(new IntPtr(p + 0x022)); // 0270D74D5030 0x22 IsSelfAxis                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
