using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Path                                     ModelPrimitiveType string string string String
    // 018 Length                                   ModelPrimitiveType int int int Int32
    // 01C LeftIndexInPath                          ModelPrimitiveType int int int Int32
    // 020 RightIndexInPath                         ModelPrimitiveType int int int Int32
    // 028 Current                                  ModelEnumType ParsedPathComponent ParsedPathComponent ParsedPathComponent Int32
    public partial class PathParser : DataModel
    {
        public string                                   Path                                    { get; set; }
        public int                                      Length                                  { get; set; }
        public int                                      LeftIndexInPath                         { get; set; }
        public int                                      RightIndexInPath                        { get; set; }
        public ParsedPathComponent                      Current                                 { get; set; }

        public static PathParser? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PathParser() { Pointer= p0 };

            value.Path                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Path                        ( ModelPrimitiveType string string string String )
            value.Length                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 Length                      ( ModelPrimitiveType int int int Int32 )
            value.LeftIndexInPath                           = GetInt32(new IntPtr(p + 0x01C)); // 0x1C LeftIndexInPath             ( ModelPrimitiveType int int int Int32 )
            value.RightIndexInPath                          = GetInt32(new IntPtr(p + 0x020)); // 0x20 RightIndexInPath            ( ModelPrimitiveType int int int Int32 )
            value.Current                                   = (ParsedPathComponent)GetInt32(new IntPtr(p + 0x028)); // 0x28 Current                     ( ModelEnumType ParsedPathComponent ParsedPathComponent ParsedPathComponent Int32 )

            return value;
        }
    }
}
