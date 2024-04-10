using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reader                                   000186593BB0 ModelClassType XmlDictionaryReader XmlDictionaryReader XmlDictionaryReader Pointer
    // 018 NameTable                                0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 020 MaxCharCount                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 CharCount                                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class QuotaNameTable : DataModel
    {
        public XmlDictionaryReader?                     Reader                                  { get; set; }
        public XmlNameTable?                            NameTable                               { get; set; }
        public int                                      MaxCharCount                            { get; set; }
        public int                                      CharCount                               { get; set; }

        public static QuotaNameTable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QuotaNameTable() { Pointer= p0 };

            value.Reader                                    = GetObject<XmlDictionaryReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlDictionaryReader.FromPointer); // 024667C67478 0x10 Reader                      ( 000186593BB0 ModelClassType XmlDictionaryReader XmlDictionaryReader XmlDictionaryReader Pointer )
            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlNameTable.FromPointer); // 024667C67498 0x18 NameTable                   ( 0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.MaxCharCount                              = GetInt32(new IntPtr(p + 0x020)); // 024667C674B8 0x20 MaxCharCount                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CharCount                                 = GetInt32(new IntPtr(p + 0x024)); // 024667C674D8 0x24 CharCount                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
