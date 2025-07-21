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
    // 018 GashaId                                  ModelPrimitiveType string string string String
    // 000 GashaPriceIdFieldNumber                  int IL2CPP_TYPE_I4
    // 020 GashaPriceId                             ModelPrimitiveType string string string String
    // 000 ExecCountFieldNumber                     int IL2CPP_TYPE_I4
    // 028 ExecCount                                ModelPrimitiveType int int int Int32
    public partial class GashaDrawArgs : DataModel
    {
        public string                                   GashaId                                 { get; set; }
        public string                                   GashaPriceId                            { get; set; }
        public int                                      ExecCount                               { get; set; }

        public static GashaDrawArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaDrawArgs() { Pointer= p0 };

            value.GashaId                                   = GetString(new IntPtr(p + 0x018)); // 0x18 GashaId                     ( ModelPrimitiveType string string string String )
            value.GashaPriceId                              = GetString(new IntPtr(p + 0x020)); // 0x20 GashaPriceId                ( ModelPrimitiveType string string string String )
            value.ExecCount                                 = GetInt32(new IntPtr(p + 0x028)); // 0x28 ExecCount                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
