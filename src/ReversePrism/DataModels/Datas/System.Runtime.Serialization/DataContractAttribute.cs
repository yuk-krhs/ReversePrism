using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 Ns                                       000186671910 ModelPrimitiveType string string string String
    // 020 IsNameSetExplicitly                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 021 IsNamespaceSetExplicitly                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 022 IsReference                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 023 IsReferenceSetExplicitly                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class DataContractAttribute
    {
        public string                                   Name                                    { get; set; }
        public string                                   Ns                                      { get; set; }
        public bool                                     IsNameSetExplicitly                     { get; set; }
        public bool                                     IsNamespaceSetExplicitly                { get; set; }
        public bool                                     IsReference                             { get; set; }
        public bool                                     IsReferenceSetExplicitly                { get; set; }

        public static DataContractAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataContractAttribute();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 027004CBAF58 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Ns                                        = GetString(new IntPtr(p + 0x018)); // 027004CBAF78 0x18 Ns                          ( 000186671910 ModelPrimitiveType string string string String )
            value.IsNameSetExplicitly                       = GetBool(new IntPtr(p + 0x020)); // 027004CBAF98 0x20 IsNameSetExplicitly         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsNamespaceSetExplicitly                  = GetBool(new IntPtr(p + 0x021)); // 027004CBAFB8 0x21 IsNamespaceSetExplicitly    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsReference                               = GetBool(new IntPtr(p + 0x022)); // 027004CBAFD8 0x22 IsReference                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsReferenceSetExplicitly                  = GetBool(new IntPtr(p + 0x023)); // 027004CBAFF8 0x23 IsReferenceSetExplicitly    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
