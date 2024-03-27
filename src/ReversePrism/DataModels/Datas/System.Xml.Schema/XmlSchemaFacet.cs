using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Value                                    000186671910 ModelPrimitiveType string string string String
    // 058 IsFixed                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 05C FacetType                                00018654F390 ModelEnumType FacetType FacetType FacetType Int32
    public partial class XmlSchemaFacet
    {
        public string                                   Value                                   { get; set; }
        public bool                                     IsFixed                                 { get; set; }
        public FacetType                                FacetType                               { get; set; }

        public static XmlSchemaFacet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaFacet();

            value.Value                                     = GetString(new IntPtr(p + 0x050)); // 0270D74B5160 0x50 Value                       ( 000186671910 ModelPrimitiveType string string string String )
            value.IsFixed                                   = GetBool(new IntPtr(p + 0x058)); // 0270D74B5180 0x58 IsFixed                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FacetType                                 = (FacetType)GetInt32(new IntPtr(p + 0x05C)); // 0270D74B51A0 0x5C FacetType                   ( 00018654F390 ModelEnumType FacetType FacetType FacetType Int32 )

            return value;
        }
    }
}
