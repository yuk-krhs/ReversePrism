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
    // 018 CurrencyCode                             000186671910 ModelPrimitiveType string string string String
    // 000 UnitsFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Units                                    0001865F7700 ModelPrimitiveType long long long Int64
    // 000 NanosFieldNumber                         int IL2CPP_TYPE_I4
    // 028 Nanos                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class Money
    {
        public string                                   CurrencyCode                            { get; set; }
        public long                                     Units                                   { get; set; }
        public int                                      Nanos                                   { get; set; }

        public static Money? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Money();

            value.CurrencyCode                              = GetString(new IntPtr(p + 0x018)); // 0270DA6A89E8 0x18 CurrencyCode                ( 000186671910 ModelPrimitiveType string string string String )
            value.Units                                     = GetInt64(new IntPtr(p + 0x020)); // 0270DA6A8A28 0x20 Units                       ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Nanos                                     = GetInt32(new IntPtr(p + 0x028)); // 0270DA6A8A68 0x28 Nanos                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
