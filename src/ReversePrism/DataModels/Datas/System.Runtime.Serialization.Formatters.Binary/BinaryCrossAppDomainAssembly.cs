using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AssemId                                  0001865F2F90 ModelPrimitiveType int int int Int32
    // 014 AssemblyIndex                            0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class BinaryCrossAppDomainAssembly : DataModel
    {
        public int                                      AssemId                                 { get; set; }
        public int                                      AssemblyIndex                           { get; set; }

        public static BinaryCrossAppDomainAssembly? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BinaryCrossAppDomainAssembly() { Pointer= p0 };

            value.AssemId                                   = GetInt32(new IntPtr(p + 0x010)); // 024666CA1430 0x10 AssemId                     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.AssemblyIndex                             = GetInt32(new IntPtr(p + 0x014)); // 024666CA1450 0x14 AssemblyIndex               ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
