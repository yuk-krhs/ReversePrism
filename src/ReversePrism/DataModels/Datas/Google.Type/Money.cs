using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Money> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CurrencyCodeFieldNumber                  int IL2CPP_TYPE_I4
    // 018 CurrencyCode                             ModelPrimitiveType string string string String
    // 000 UnitsFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Units                                    ModelPrimitiveType long long long Int64
    // 000 NanosFieldNumber                         int IL2CPP_TYPE_I4
    // 028 Nanos                                    ModelPrimitiveType int int int Int32
    public partial class Money : DataModel
    {
        public string                                   CurrencyCode                            { get; set; }
        public long                                     Units                                   { get; set; }
        public int                                      Nanos                                   { get; set; }

        public static Money? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Money() { Pointer= p0 };

            value.CurrencyCode                              = GetString(new IntPtr(p + 0x018)); // 0x18 CurrencyCode                ( ModelPrimitiveType string string string String )
            value.Units                                     = GetInt64(new IntPtr(p + 0x020)); // 0x20 Units                       ( ModelPrimitiveType long long long Int64 )
            value.Nanos                                     = GetInt32(new IntPtr(p + 0x028)); // 0x28 Nanos                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
