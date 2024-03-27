using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventName                                0001866722E0 ModelPrimitiveType string string string String
    // 018 StartFrame                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 Arg1                                     0001866722E0 ModelPrimitiveType string string string String
    // 028 Arg2                                     0001866722E0 ModelPrimitiveType string string string String
    public partial class AnimEvent
    {
        public string                                   EventName                               { get; set; }
        public int                                      StartFrame                              { get; set; }
        public string                                   Arg1                                    { get; set; }
        public string                                   Arg2                                    { get; set; }

        public static AnimEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnimEvent();

            value.EventName                                 = GetString(new IntPtr(p + 0x010)); // 0270D4B18FB0 0x10 EventName                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.StartFrame                                = GetInt32(new IntPtr(p + 0x018)); // 0270D4B18FD0 0x18 StartFrame                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Arg1                                      = GetString(new IntPtr(p + 0x020)); // 0270D4B18FF0 0x20 Arg1                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Arg2                                      = GetString(new IntPtr(p + 0x028)); // 0270D4B19010 0x28 Arg2                        ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
