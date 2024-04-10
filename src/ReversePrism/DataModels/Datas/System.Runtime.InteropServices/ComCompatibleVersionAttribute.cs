using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Major                                    0001865F2F90 ModelPrimitiveType int int int Int32
    // 014 Minor                                    0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 Build                                    0001865F2F90 ModelPrimitiveType int int int Int32
    // 01C Revision                                 0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class ComCompatibleVersionAttribute : DataModel
    {
        public int                                      Major                                   { get; set; }
        public int                                      Minor                                   { get; set; }
        public int                                      Build                                   { get; set; }
        public int                                      Revision                                { get; set; }

        public static ComCompatibleVersionAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ComCompatibleVersionAttribute() { Pointer= p0 };

            value.Major                                     = GetInt32(new IntPtr(p + 0x010)); // 024666CF36F8 0x10 Major                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Minor                                     = GetInt32(new IntPtr(p + 0x014)); // 024666CF3718 0x14 Minor                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Build                                     = GetInt32(new IntPtr(p + 0x018)); // 024666CF3738 0x18 Build                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Revision                                  = GetInt32(new IntPtr(p + 0x01C)); // 024666CF3758 0x1C Revision                    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
