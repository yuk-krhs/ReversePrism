using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 ClassName                                ModelPrimitiveType string string string String
    // 098 AssemblyName                             ModelPrimitiveType string string string String
    // 0A0 MessageArg                               ModelPrimitiveType string string string String
    // 0A8 ResourceId                               ModelPrimitiveType int int int Int32
    public partial class TypeLoadException : DataModel
    {
        public string                                   ClassName                               { get; set; }
        public string                                   AssemblyName                            { get; set; }
        public string                                   MessageArg                              { get; set; }
        public int                                      ResourceId                              { get; set; }

        public static TypeLoadException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeLoadException() { Pointer= p0 };

            value.ClassName                                 = GetString(new IntPtr(p + 0x090)); // 0x90 ClassName                   ( ModelPrimitiveType string string string String )
            value.AssemblyName                              = GetString(new IntPtr(p + 0x098)); // 0x98 AssemblyName                ( ModelPrimitiveType string string string String )
            value.MessageArg                                = GetString(new IntPtr(p + 0x0A0)); // 0xA0 MessageArg                  ( ModelPrimitiveType string string string String )
            value.ResourceId                                = GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 ResourceId                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
