using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Path                                     000186671910 ModelPrimitiveType string string string String
    // 018 Length                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C LeftIndexInPath                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 RightIndexInPath                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 Current                                  0001866F96B0 ModelEnumType ParsedPathComponent ParsedPathComponent ParsedPathComponent Int32
    public partial class PathParser
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
            var value   = new PathParser();

            value.Path                                      = GetString(new IntPtr(p + 0x010)); // 0270D76F1DA0 0x10 Path                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Length                                    = GetInt32(new IntPtr(p + 0x018)); // 0270D76F1DC0 0x18 Length                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LeftIndexInPath                           = GetInt32(new IntPtr(p + 0x01C)); // 0270D76F1DE0 0x1C LeftIndexInPath             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RightIndexInPath                          = GetInt32(new IntPtr(p + 0x020)); // 0270D76F1E00 0x20 RightIndexInPath            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Current                                   = (ParsedPathComponent)GetInt32(new IntPtr(p + 0x028)); // 0270D76F1E20 0x28 Current                     ( 0001866F96B0 ModelEnumType ParsedPathComponent ParsedPathComponent ParsedPathComponent Int32 )

            return value;
        }
    }
}
