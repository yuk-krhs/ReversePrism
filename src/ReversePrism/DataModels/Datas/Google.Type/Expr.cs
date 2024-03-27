using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Expr> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ExpressionFieldNumber                    int IL2CPP_TYPE_I4
    // 018 Expression                               000186671910 ModelPrimitiveType string string string String
    // 000 TitleFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Title                                    000186671910 ModelPrimitiveType string string string String
    // 000 DescriptionFieldNumber                   int IL2CPP_TYPE_I4
    // 028 Description                              000186671910 ModelPrimitiveType string string string String
    // 000 LocationFieldNumber                      int IL2CPP_TYPE_I4
    // 030 Location                                 000186671910 ModelPrimitiveType string string string String
    public partial class Expr
    {
        public string                                   Expression                              { get; set; }
        public string                                   Title                                   { get; set; }
        public string                                   Description                             { get; set; }
        public string                                   Location                                { get; set; }

        public static Expr? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Expr();

            value.Expression                                = GetString(new IntPtr(p + 0x018)); // 0270DA690AC0 0x18 Expression                  ( 000186671910 ModelPrimitiveType string string string String )
            value.Title                                     = GetString(new IntPtr(p + 0x020)); // 0270DA690B00 0x20 Title                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x028)); // 0270DA690B40 0x28 Description                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Location                                  = GetString(new IntPtr(p + 0x030)); // 0270DA690B80 0x30 Location                    ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
