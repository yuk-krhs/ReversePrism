using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ClassName                                0001866722E0 ModelPrimitiveType string string string String
    // 018 NameSpace                                0001866722E0 ModelPrimitiveType string string string String
    // 020 Assembly                                 0001866722E0 ModelPrimitiveType string string string String
    // 028 ClassHasChanged                          000186595960 ModelPrimitiveType bool bool bool Bool
    // 029 NameSpaceHasChanged                      000186595960 ModelPrimitiveType bool bool bool Bool
    // 02A AssemblyHasChanged                       000186595960 ModelPrimitiveType bool bool bool Bool
    // 02B AutoUdpateAPI                            000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class MovedFromAttributeData
    {
        public string                                   ClassName                               { get; set; }
        public string                                   NameSpace                               { get; set; }
        public string                                   Assembly                                { get; set; }
        public bool                                     ClassHasChanged                         { get; set; }
        public bool                                     NameSpaceHasChanged                     { get; set; }
        public bool                                     AssemblyHasChanged                      { get; set; }
        public bool                                     AutoUdpateAPI                           { get; set; }

        public static MovedFromAttributeData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MovedFromAttributeData();

            value.ClassName                                 = GetString(new IntPtr(p + 0x010)); // 027004FA95F8 0x10 ClassName                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.NameSpace                                 = GetString(new IntPtr(p + 0x018)); // 027004FA9618 0x18 NameSpace                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Assembly                                  = GetString(new IntPtr(p + 0x020)); // 027004FA9638 0x20 Assembly                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ClassHasChanged                           = GetBool(new IntPtr(p + 0x028)); // 027004FA9658 0x28 ClassHasChanged             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.NameSpaceHasChanged                       = GetBool(new IntPtr(p + 0x029)); // 027004FA9678 0x29 NameSpaceHasChanged         ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.AssemblyHasChanged                        = GetBool(new IntPtr(p + 0x02A)); // 027004FA9698 0x2A AssemblyHasChanged          ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.AutoUdpateAPI                             = GetBool(new IntPtr(p + 0x02B)); // 027004FA96B8 0x2B AutoUdpateAPI               ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
