using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 ResponseElement                          ModelPrimitiveType string string string String
    // 030 ResponseNamespace                        ModelPrimitiveType string string string String
    // 038 ReturnElement                            ModelPrimitiveType string string string String
    // 040 SoapAction                               ModelPrimitiveType string string string String
    // 048 UseAttribute                             ModelPrimitiveType bool bool bool Bool
    // 050 Namespace                                ModelPrimitiveType string string string String
    public partial class SoapMethodAttribute : DataModel
    {
        public string                                   ResponseElement                         { get; set; }
        public string                                   ResponseNamespace                       { get; set; }
        public string                                   ReturnElement                           { get; set; }
        public string                                   SoapAction                              { get; set; }
        public bool                                     UseAttribute                            { get; set; }
        public string                                   Namespace                               { get; set; }

        public static SoapMethodAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SoapMethodAttribute() { Pointer= p0 };

            value.ResponseElement                           = GetString(new IntPtr(p + 0x028)); // 0x28 ResponseElement             ( ModelPrimitiveType string string string String )
            value.ResponseNamespace                         = GetString(new IntPtr(p + 0x030)); // 0x30 ResponseNamespace           ( ModelPrimitiveType string string string String )
            value.ReturnElement                             = GetString(new IntPtr(p + 0x038)); // 0x38 ReturnElement               ( ModelPrimitiveType string string string String )
            value.SoapAction                                = GetString(new IntPtr(p + 0x040)); // 0x40 SoapAction                  ( ModelPrimitiveType string string string String )
            value.UseAttribute                              = GetBool(new IntPtr(p + 0x048)); // 0x48 UseAttribute                ( ModelPrimitiveType bool bool bool Bool )
            value.Namespace                                 = GetString(new IntPtr(p + 0x050)); // 0x50 Namespace                   ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
