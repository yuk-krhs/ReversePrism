using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AssemId                                  0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 AssemblyString                           000186671BA0 ModelPrimitiveType string string string String
    public partial class BinaryAssembly : DataModel
    {
        public int                                      AssemId                                 { get; set; }
        public string                                   AssemblyString                          { get; set; }

        public static BinaryAssembly? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BinaryAssembly() { Pointer= p0 };

            value.AssemId                                   = GetInt32(new IntPtr(p + 0x010)); // 024666CA11F0 0x10 AssemId                     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.AssemblyString                            = GetString(new IntPtr(p + 0x018)); // 024666CA1210 0x18 AssemblyString              ( 000186671BA0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
