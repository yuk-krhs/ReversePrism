using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Path                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 Query                                    0001866722E0 ModelPrimitiveType string string string String
    // 020 Fragment                                 0001866722E0 ModelPrimitiveType string string string String
    // 028 AbsoluteUri                              0001866722E0 ModelPrimitiveType string string string String
    // 030 Hash                                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 038 RemoteUrl                                0001866722E0 ModelPrimitiveType string string string String
    public partial class MoreInfo : DataModel
    {
        public string                                   Path                                    { get; set; }
        public string                                   Query                                   { get; set; }
        public string                                   Fragment                                { get; set; }
        public string                                   AbsoluteUri                             { get; set; }
        public int                                      Hash                                    { get; set; }
        public string                                   RemoteUrl                               { get; set; }

        public static MoreInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MoreInfo() { Pointer= p0 };

            value.Path                                      = GetString(new IntPtr(p + 0x010)); // 0245A4C5E538 0x10 Path                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Query                                     = GetString(new IntPtr(p + 0x018)); // 0245A4C5E558 0x18 Query                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Fragment                                  = GetString(new IntPtr(p + 0x020)); // 0245A4C5E578 0x20 Fragment                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AbsoluteUri                               = GetString(new IntPtr(p + 0x028)); // 0245A4C5E598 0x28 AbsoluteUri                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Hash                                      = GetInt32(new IntPtr(p + 0x030)); // 0245A4C5E5B8 0x30 Hash                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.RemoteUrl                                 = GetString(new IntPtr(p + 0x038)); // 0245A4C5E5D8 0x38 RemoteUrl                   ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
