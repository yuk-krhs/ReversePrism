using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ranges                                   ModelEnumListType TableRange[] TableRange[] List<TableRange> Pointer
    // 018 TotalCount                               ModelPrimitiveType int int int Int32
    // 01C DefaultIndex                             ModelPrimitiveType int int int Int32
    // 020 DefaultCP                                ModelPrimitiveType int int int Int32
    public partial class CodePointIndexer : DataModel
    {
        public List<TableRange>?                        Ranges                                  { get; set; }
        public int                                      TotalCount                              { get; set; }
        public int                                      DefaultIndex                            { get; set; }
        public int                                      DefaultCP                               { get; set; }

        public static CodePointIndexer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CodePointIndexer() { Pointer= p0 };

            value.Ranges                                    = GetEnumList<TableRange>(new IntPtr(p + 0x010)); // 0x10 Ranges                      ( ModelEnumListType TableRange[] TableRange[] List<TableRange> Pointer )
            value.TotalCount                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 TotalCount                  ( ModelPrimitiveType int int int Int32 )
            value.DefaultIndex                              = GetInt32(new IntPtr(p + 0x01C)); // 0x1C DefaultIndex                ( ModelPrimitiveType int int int Int32 )
            value.DefaultCP                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 DefaultCP                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
