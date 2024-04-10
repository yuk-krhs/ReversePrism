using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 ResponseElement                          000186671910 ModelPrimitiveType string string string String
    // 030 ResponseNamespace                        000186671910 ModelPrimitiveType string string string String
    // 038 ReturnElement                            000186671910 ModelPrimitiveType string string string String
    // 040 SoapAction                               000186671910 ModelPrimitiveType string string string String
    // 048 UseAttribute                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 Namespace                                000186671910 ModelPrimitiveType string string string String
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

            value.ResponseElement                           = GetString(new IntPtr(p + 0x028)); // 024666C5EF70 0x28 ResponseElement             ( 000186671910 ModelPrimitiveType string string string String )
            value.ResponseNamespace                         = GetString(new IntPtr(p + 0x030)); // 024666C5EF90 0x30 ResponseNamespace           ( 000186671910 ModelPrimitiveType string string string String )
            value.ReturnElement                             = GetString(new IntPtr(p + 0x038)); // 024666C5EFB0 0x38 ReturnElement               ( 000186671910 ModelPrimitiveType string string string String )
            value.SoapAction                                = GetString(new IntPtr(p + 0x040)); // 024666C5EFD0 0x40 SoapAction                  ( 000186671910 ModelPrimitiveType string string string String )
            value.UseAttribute                              = GetBool(new IntPtr(p + 0x048)); // 024666C5EFF0 0x48 UseAttribute                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Namespace                                 = GetString(new IntPtr(p + 0x050)); // 024666C5F010 0x50 Namespace                   ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
