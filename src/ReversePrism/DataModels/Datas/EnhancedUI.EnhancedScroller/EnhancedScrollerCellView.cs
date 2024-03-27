using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellIdentifier                           0001866722E0 ModelPrimitiveType string string string String
    // 028 CellIndex                                0001865F59B0 ModelPrimitiveType int int int Int32
    // 02C DataIndex                                0001865F59B0 ModelPrimitiveType int int int Int32
    // 030 Active                                   000186597BE0 ModelPrimitiveType bool bool bool Bool
    public partial class EnhancedScrollerCellView
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
            var value   = new EnhancedScrollerCellView();

            value.CellIdentifier                            = GetString(new IntPtr(p + 0x020)); // 02700263C028 0x20 CellIdentifier              ( 0001866722E0 ModelPrimitiveType string string string String )
            value.CellIndex                                 = GetInt32(new IntPtr(p + 0x028)); // 02700263C048 0x28 CellIndex                   ( 0001865F59B0 ModelPrimitiveType int int int Int32 )
            value.DataIndex                                 = GetInt32(new IntPtr(p + 0x02C)); // 02700263C068 0x2C DataIndex                   ( 0001865F59B0 ModelPrimitiveType int int int Int32 )
            value.Active                                    = GetBool(new IntPtr(p + 0x030)); // 02700263C088 0x30 Active                      ( 000186597BE0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
