using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DataType                                 000186671910 ModelPrimitiveType string string string String
    // 018 ElementName                              000186671910 ModelPrimitiveType string string string String
    // 020 IsNullable                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 Ns                                       000186671910 ModelPrimitiveType string string string String
    public partial class XmlRootAttribute : DataModel
    {
        public string                                   DataType                                { get; set; }
        public string                                   ElementName                             { get; set; }
        public bool                                     IsNullable                              { get; set; }
        public string                                   Ns                                      { get; set; }

        public static XmlRootAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlRootAttribute() { Pointer= p0 };

            value.DataType                                  = GetString(new IntPtr(p + 0x010)); // 024667513D30 0x10 DataType                    ( 000186671910 ModelPrimitiveType string string string String )
            value.ElementName                               = GetString(new IntPtr(p + 0x018)); // 024667513D50 0x18 ElementName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.IsNullable                                = GetBool(new IntPtr(p + 0x020)); // 024667513D70 0x20 IsNullable                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Ns                                        = GetString(new IntPtr(p + 0x028)); // 024667513D90 0x28 Ns                          ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
