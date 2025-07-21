using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Ns                                       ModelPrimitiveType string string string String
    // 020 IsNameSetExplicitly                      ModelPrimitiveType bool bool bool Bool
    // 021 IsNamespaceSetExplicitly                 ModelPrimitiveType bool bool bool Bool
    // 022 IsReference                              ModelPrimitiveType bool bool bool Bool
    // 023 IsReferenceSetExplicitly                 ModelPrimitiveType bool bool bool Bool
    public partial class DataContractAttribute : DataModel
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
            var value   = new DataContractAttribute() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Ns                                        = GetString(new IntPtr(p + 0x018)); // 0x18 Ns                          ( ModelPrimitiveType string string string String )
            value.IsNameSetExplicitly                       = GetBool(new IntPtr(p + 0x020)); // 0x20 IsNameSetExplicitly         ( ModelPrimitiveType bool bool bool Bool )
            value.IsNamespaceSetExplicitly                  = GetBool(new IntPtr(p + 0x021)); // 0x21 IsNamespaceSetExplicitly    ( ModelPrimitiveType bool bool bool Bool )
            value.IsReference                               = GetBool(new IntPtr(p + 0x022)); // 0x22 IsReference                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsReferenceSetExplicitly                  = GetBool(new IntPtr(p + 0x023)); // 0x23 IsReferenceSetExplicitly    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
