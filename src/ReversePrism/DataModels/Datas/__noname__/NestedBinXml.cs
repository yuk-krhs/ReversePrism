using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SymbolTables                             000186741520 ModelEnumType SymbolTables SymbolTables SymbolTables Int32
    // 030 DocState                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 038 Next                                     000186740050 ModelClassType NestedBinXml NestedBinXml NestedBinXml Pointer
    public partial class NestedBinXml : DataModel
    {
        public SymbolTables                             SymbolTables                            { get; set; }
        public int                                      DocState                                { get; set; }
        public NestedBinXml?                            Next                                    { get; set; }

        public static NestedBinXml? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NestedBinXml() { Pointer= p0 };

            value.SymbolTables                              = (SymbolTables)GetInt32(new IntPtr(p + 0x010)); // 02466739EFC0 0x10 SymbolTables                ( 000186741520 ModelEnumType SymbolTables SymbolTables SymbolTables Int32 )
            value.DocState                                  = GetInt32(new IntPtr(p + 0x030)); // 02466739EFE0 0x30 DocState                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Next                                      = GetObject<NestedBinXml>(new IntPtr(p + 0x038), ReversePrism.DataModels.NestedBinXml.FromPointer); // 02466739F000 0x38 Next                        ( 000186740050 ModelClassType NestedBinXml NestedBinXml NestedBinXml Pointer )

            return value;
        }
    }
}
