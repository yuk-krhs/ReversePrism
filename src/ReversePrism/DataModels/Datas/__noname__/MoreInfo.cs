using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Path                                     ModelPrimitiveType string string string String
    // 018 Query                                    ModelPrimitiveType string string string String
    // 020 Fragment                                 ModelPrimitiveType string string string String
    // 028 AbsoluteUri                              ModelPrimitiveType string string string String
    // 030 Hash                                     ModelPrimitiveType int int int Int32
    // 038 RemoteUrl                                ModelPrimitiveType string string string String
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

            value.Path                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Path                        ( ModelPrimitiveType string string string String )
            value.Query                                     = GetString(new IntPtr(p + 0x018)); // 0x18 Query                       ( ModelPrimitiveType string string string String )
            value.Fragment                                  = GetString(new IntPtr(p + 0x020)); // 0x20 Fragment                    ( ModelPrimitiveType string string string String )
            value.AbsoluteUri                               = GetString(new IntPtr(p + 0x028)); // 0x28 AbsoluteUri                 ( ModelPrimitiveType string string string String )
            value.Hash                                      = GetInt32(new IntPtr(p + 0x030)); // 0x30 Hash                        ( ModelPrimitiveType int int int Int32 )
            value.RemoteUrl                                 = GetString(new IntPtr(p + 0x038)); // 0x38 RemoteUrl                   ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
