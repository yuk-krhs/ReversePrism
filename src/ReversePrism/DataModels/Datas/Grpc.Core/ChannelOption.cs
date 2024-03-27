using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     00018675CA30 ModelEnumType OptionType OptionType OptionType Int32
    // 018 Name                                     000186672F10 ModelPrimitiveType string string string String
    // 020 IntValue                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 028 StringValue                              000186672F10 ModelPrimitiveType string string string String
    public partial class ChannelOption
    {
        public OptionType                               Type                                    { get; set; }
        public string                                   Name                                    { get; set; }
        public int                                      IntValue                                { get; set; }
        public string                                   StringValue                             { get; set; }

        public static ChannelOption? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChannelOption();

            value.Type                                      = (OptionType)GetInt32(new IntPtr(p + 0x010)); // 0270D0EA2BE0 0x10 Type                        ( 00018675CA30 ModelEnumType OptionType OptionType OptionType Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0270D0EA2C00 0x18 Name                        ( 000186672F10 ModelPrimitiveType string string string String )
            value.IntValue                                  = GetInt32(new IntPtr(p + 0x020)); // 0270D0EA2C20 0x20 IntValue                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.StringValue                               = GetString(new IntPtr(p + 0x028)); // 0270D0EA2C40 0x28 StringValue                 ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
