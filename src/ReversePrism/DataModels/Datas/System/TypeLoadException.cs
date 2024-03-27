using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 ClassName                                000186671910 ModelPrimitiveType string string string String
    // 098 AssemblyName                             000186671910 ModelPrimitiveType string string string String
    // 0A0 MessageArg                               000186671910 ModelPrimitiveType string string string String
    // 0A8 ResourceId                               0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class TypeLoadException
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
            var value   = new TypeLoadException();

            value.ClassName                                 = GetString(new IntPtr(p + 0x090)); // 0270D6993118 0x90 ClassName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.AssemblyName                              = GetString(new IntPtr(p + 0x098)); // 0270D6993138 0x98 AssemblyName                ( 000186671910 ModelPrimitiveType string string string String )
            value.MessageArg                                = GetString(new IntPtr(p + 0x0A0)); // 0270D6993158 0xA0 MessageArg                  ( 000186671910 ModelPrimitiveType string string string String )
            value.ResourceId                                = GetInt32(new IntPtr(p + 0x0A8)); // 0270D6993178 0xA8 ResourceId                  ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
