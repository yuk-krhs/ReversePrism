using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ClassName                                ModelPrimitiveType string string string String
    // 018 NameSpace                                ModelPrimitiveType string string string String
    // 020 Assembly                                 ModelPrimitiveType string string string String
    // 028 ClassHasChanged                          ModelPrimitiveType bool bool bool Bool
    // 029 NameSpaceHasChanged                      ModelPrimitiveType bool bool bool Bool
    // 02A AssemblyHasChanged                       ModelPrimitiveType bool bool bool Bool
    // 02B AutoUdpateAPI                            ModelPrimitiveType bool bool bool Bool
    public partial class MovedFromAttributeData : DataModel
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
            var value   = new MovedFromAttributeData() { Pointer= p0 };

            value.ClassName                                 = GetString(new IntPtr(p + 0x010)); // 0x10 ClassName                   ( ModelPrimitiveType string string string String )
            value.NameSpace                                 = GetString(new IntPtr(p + 0x018)); // 0x18 NameSpace                   ( ModelPrimitiveType string string string String )
            value.Assembly                                  = GetString(new IntPtr(p + 0x020)); // 0x20 Assembly                    ( ModelPrimitiveType string string string String )
            value.ClassHasChanged                           = GetBool(new IntPtr(p + 0x028)); // 0x28 ClassHasChanged             ( ModelPrimitiveType bool bool bool Bool )
            value.NameSpaceHasChanged                       = GetBool(new IntPtr(p + 0x029)); // 0x29 NameSpaceHasChanged         ( ModelPrimitiveType bool bool bool Bool )
            value.AssemblyHasChanged                        = GetBool(new IntPtr(p + 0x02A)); // 0x2A AssemblyHasChanged          ( ModelPrimitiveType bool bool bool Bool )
            value.AutoUdpateAPI                             = GetBool(new IntPtr(p + 0x02B)); // 0x2B AutoUdpateAPI               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
