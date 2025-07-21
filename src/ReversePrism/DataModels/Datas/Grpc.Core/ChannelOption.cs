using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelEnumType OptionType OptionType OptionType Int32
    // 018 Name                                     ModelPrimitiveType string string string String
    // 020 IntValue                                 ModelPrimitiveType int int int Int32
    // 028 StringValue                              ModelPrimitiveType string string string String
    public partial class ChannelOption : DataModel
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
            var value   = new ChannelOption() { Pointer= p0 };

            value.Type                                      = (OptionType)GetInt32(new IntPtr(p + 0x010)); // 0x10 Type                        ( ModelEnumType OptionType OptionType OptionType Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )
            value.IntValue                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 IntValue                    ( ModelPrimitiveType int int int Int32 )
            value.StringValue                               = GetString(new IntPtr(p + 0x028)); // 0x28 StringValue                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
