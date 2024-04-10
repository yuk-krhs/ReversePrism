using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DataSet                                  000186680790 ModelClassType DataSet DataSet DataSet Pointer
    // 018 DataTable                                0001865B7E00 ModelClassType DataTable DataTable DataTable Pointer
    // 020 PreserveChanges                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 024 MissingSchemaAction                      00018661F130 ModelEnumType MissingSchemaAction MissingSchemaAction MissingSchemaAction Int32
    // 028 IsStandAlonetable                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 029 IgnoreNSforTableLookup                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class Merger : DataModel
    {
        public DataSet?                                 DataSet                                 { get; set; }
        public DataTable?                               DataTable                               { get; set; }
        public bool                                     PreserveChanges                         { get; set; }
        public MissingSchemaAction                      MissingSchemaAction                     { get; set; }
        public bool                                     IsStandAlonetable                       { get; set; }
        public bool                                     IgnoreNSforTableLookup                  { get; set; }

        public static Merger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Merger() { Pointer= p0 };

            value.DataSet                                   = GetObject<DataSet>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataSet.FromPointer); // 0246689A9730 0x10 DataSet                     ( 000186680790 ModelClassType DataSet DataSet DataSet Pointer )
            value.DataTable                                 = GetObject<DataTable>(new IntPtr(p + 0x018), ReversePrism.DataModels.DataTable.FromPointer); // 0246689A9750 0x18 DataTable                   ( 0001865B7E00 ModelClassType DataTable DataTable DataTable Pointer )
            value.PreserveChanges                           = GetBool(new IntPtr(p + 0x020)); // 0246689A9770 0x20 PreserveChanges             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MissingSchemaAction                       = (MissingSchemaAction)GetInt32(new IntPtr(p + 0x024)); // 0246689A9790 0x24 MissingSchemaAction         ( 00018661F130 ModelEnumType MissingSchemaAction MissingSchemaAction MissingSchemaAction Int32 )
            value.IsStandAlonetable                         = GetBool(new IntPtr(p + 0x028)); // 0246689A97B0 0x28 IsStandAlonetable           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IgnoreNSforTableLookup                    = GetBool(new IntPtr(p + 0x029)); // 0246689A97D0 0x29 IgnoreNSforTableLookup      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
