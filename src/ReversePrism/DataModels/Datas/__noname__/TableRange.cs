using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Start                                    0001865F4940 ModelPrimitiveType int int int Int32
    // 014 End                                      0001865F4940 ModelPrimitiveType int int int Int32
    // 018 Count                                    0001865F4940 ModelPrimitiveType int int int Int32
    // 01C IndexStart                               0001865F4940 ModelPrimitiveType int int int Int32
    // 020 IndexEnd                                 0001865F4940 ModelPrimitiveType int int int Int32
    public partial class TableRange : DataModel
    {
        public int                                      Start                                   { get; set; }
        public int                                      End                                     { get; set; }
        public int                                      Count                                   { get; set; }
        public int                                      IndexStart                              { get; set; }
        public int                                      IndexEnd                                { get; set; }

        public static TableRange? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TableRange() { Pointer= p0 };

            value.Start                                     = GetInt32(new IntPtr(p + 0x010)); // 0245A3CF1288 0x10 Start                       ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.End                                       = GetInt32(new IntPtr(p + 0x014)); // 0245A3CF12A8 0x14 End                         ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x018)); // 0245A3CF12C8 0x18 Count                       ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.IndexStart                                = GetInt32(new IntPtr(p + 0x01C)); // 0245A3CF12E8 0x1C IndexStart                  ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.IndexEnd                                  = GetInt32(new IntPtr(p + 0x020)); // 0245A3CF1308 0x20 IndexEnd                    ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
