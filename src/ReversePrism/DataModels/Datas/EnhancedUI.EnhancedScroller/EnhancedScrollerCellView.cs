using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellIdentifier                           ModelPrimitiveType string string string String
    // 028 CellIndex                                ModelPrimitiveType int int int Int32
    // 02C DataIndex                                ModelPrimitiveType int int int Int32
    // 030 Active                                   ModelPrimitiveType bool bool bool Bool
    public partial class EnhancedScrollerCellView : DataModel
    {
        public string                                   CellIdentifier                          { get; set; }
        public int                                      CellIndex                               { get; set; }
        public int                                      DataIndex                               { get; set; }
        public bool                                     Active                                  { get; set; }

        public static EnhancedScrollerCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnhancedScrollerCellView() { Pointer= p0 };

            value.CellIdentifier                            = GetString(new IntPtr(p + 0x020)); // 0x20 CellIdentifier              ( ModelPrimitiveType string string string String )
            value.CellIndex                                 = GetInt32(new IntPtr(p + 0x028)); // 0x28 CellIndex                   ( ModelPrimitiveType int int int Int32 )
            value.DataIndex                                 = GetInt32(new IntPtr(p + 0x02C)); // 0x2C DataIndex                   ( ModelPrimitiveType int int int Int32 )
            value.Active                                    = GetBool(new IntPtr(p + 0x030)); // 0x30 Active                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
