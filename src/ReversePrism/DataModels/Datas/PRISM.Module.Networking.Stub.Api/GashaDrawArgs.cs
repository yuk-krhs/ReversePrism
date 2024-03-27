using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GashaDrawArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 GashaIdFieldNumber                       int IL2CPP_TYPE_I4
    // 018 GashaId                                  000186671910 ModelPrimitiveType string string string String
    // 000 GashaPriceIdFieldNumber                  int IL2CPP_TYPE_I4
    // 020 GashaPriceId                             000186671910 ModelPrimitiveType string string string String
    // 000 ExecCountFieldNumber                     int IL2CPP_TYPE_I4
    // 028 ExecCount                                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class GashaDrawArgs
    {
        public string                                   GashaId                                 { get; set; }
        public string                                   GashaPriceId                            { get; set; }
        public int                                      ExecCount                               { get; set; }

        public static GashaDrawArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaDrawArgs();

            value.GashaId                                   = GetString(new IntPtr(p + 0x018)); // 0270D1A0C070 0x18 GashaId                     ( 000186671910 ModelPrimitiveType string string string String )
            value.GashaPriceId                              = GetString(new IntPtr(p + 0x020)); // 0270D1A0C0B0 0x20 GashaPriceId                ( 000186671910 ModelPrimitiveType string string string String )
            value.ExecCount                                 = GetInt32(new IntPtr(p + 0x028)); // 0270D1A0C0F0 0x28 ExecCount                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
