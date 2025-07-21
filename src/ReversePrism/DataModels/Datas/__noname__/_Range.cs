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
    // 018 Current                                  ModelPrimitiveType int int int Int32
    // 020 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
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

            value.Start                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Start                       ( ModelPrimitiveType int int int Int32 )
            value.End                                       = GetInt32(new IntPtr(p + 0x014)); // 0x14 End                         ( ModelPrimitiveType int int int Int32 )
            value.Current                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 Current                     ( ModelPrimitiveType int int int Int32 )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x020)); // 0x20 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
