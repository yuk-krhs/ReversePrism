using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TopNode                                  ModelClassType DoubleLinkAxis DoubleLinkAxis DoubleLinkAxis Pointer
    // 018 RootNode                                 ModelClassType DoubleLinkAxis DoubleLinkAxis DoubleLinkAxis Pointer
    // 020 IsAttribute                              ModelPrimitiveType bool bool bool Bool
    // 021 IsDss                                    ModelPrimitiveType bool bool bool Bool
    // 022 IsSelfAxis                               ModelPrimitiveType bool bool bool Bool
    public partial class ForwardAxis : DataModel
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
            var value   = new ForwardAxis() { Pointer= p0 };

            value.TopNode                                   = GetObject<DoubleLinkAxis>(new IntPtr(p + 0x010), ReversePrism.DataModels.DoubleLinkAxis.FromPointer); // 0x10 TopNode                     ( ModelClassType DoubleLinkAxis DoubleLinkAxis DoubleLinkAxis Pointer )
            value.RootNode                                  = GetObject<DoubleLinkAxis>(new IntPtr(p + 0x018), ReversePrism.DataModels.DoubleLinkAxis.FromPointer); // 0x18 RootNode                    ( ModelClassType DoubleLinkAxis DoubleLinkAxis DoubleLinkAxis Pointer )
            value.IsAttribute                               = GetBool(new IntPtr(p + 0x020)); // 0x20 IsAttribute                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsDss                                     = GetBool(new IntPtr(p + 0x021)); // 0x21 IsDss                       ( ModelPrimitiveType bool bool bool Bool )
            value.IsSelfAxis                                = GetBool(new IntPtr(p + 0x022)); // 0x22 IsSelfAxis                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
