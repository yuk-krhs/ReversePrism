using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Start                                    ModelPrimitiveType int int int Int32
    // 014 End                                      ModelPrimitiveType int int int Int32
    // 018 Count                                    ModelPrimitiveType int int int Int32
    // 01C IndexStart                               ModelPrimitiveType int int int Int32
    // 020 IndexEnd                                 ModelPrimitiveType int int int Int32
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

            value.Start                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Start                       ( ModelPrimitiveType int int int Int32 )
            value.End                                       = GetInt32(new IntPtr(p + 0x014)); // 0x14 End                         ( ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Count                       ( ModelPrimitiveType int int int Int32 )
            value.IndexStart                                = GetInt32(new IntPtr(p + 0x01C)); // 0x1C IndexStart                  ( ModelPrimitiveType int int int Int32 )
            value.IndexEnd                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 IndexEnd                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
