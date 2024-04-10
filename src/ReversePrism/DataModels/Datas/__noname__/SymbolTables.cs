using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Symtable                                 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 018 SymCount                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 Qnametable                               000185CC7F48 ModelEnumListType QName[] QName[] List<QName> Pointer
    // 028 QnameCount                               0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class SymbolTables : DataModel
    {
        public List<string>?                            Symtable                                { get; set; }
        public int                                      SymCount                                { get; set; }
        public List<QName>?                             Qnametable                              { get; set; }
        public int                                      QnameCount                              { get; set; }

        public static SymbolTables? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SymbolTables() { Pointer= p0 };

            value.Symtable                                  = GetStringList(new IntPtr(p + 0x010)); // 02466739DD70 0x10 Symtable                    ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SymCount                                  = GetInt32(new IntPtr(p + 0x018)); // 02466739DD90 0x18 SymCount                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Qnametable                                = GetEnumList<QName>(new IntPtr(p + 0x020)); // 02466739DDB0 0x20 Qnametable                  ( 000185CC7F48 ModelEnumListType QName[] QName[] List<QName> Pointer )
            value.QnameCount                                = GetInt32(new IntPtr(p + 0x028)); // 02466739DDD0 0x28 QnameCount                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
