using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Start                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 014 End                                      0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Current                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    public partial class _Range : DataModel
    {
        public int                                      Start                                   { get; set; }
        public int                                      End                                     { get; set; }
        public int                                      Current                                 { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }

        public static _Range? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _Range() { Pointer= p0 };

            value.Start                                     = GetInt32(new IntPtr(p + 0x010)); // 024668552EA0 0x10 Start                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.End                                       = GetInt32(new IntPtr(p + 0x014)); // 024668552EC0 0x14 End                         ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Current                                   = GetInt32(new IntPtr(p + 0x018)); // 024668552EE0 0x18 Current                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x020)); // 024668552F00 0x20 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
