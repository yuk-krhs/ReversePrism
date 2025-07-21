using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reader                                   ModelClassType XmlDictionaryReader XmlDictionaryReader XmlDictionaryReader Pointer
    // 018 NameTable                                ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 020 MaxCharCount                             ModelPrimitiveType int int int Int32
    // 024 CharCount                                ModelPrimitiveType int int int Int32
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

            value.Reader                                    = GetObject<XmlDictionaryReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlDictionaryReader.FromPointer); // 0x10 Reader                      ( ModelClassType XmlDictionaryReader XmlDictionaryReader XmlDictionaryReader Pointer )
            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlNameTable.FromPointer); // 0x18 NameTable                   ( ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.MaxCharCount                              = GetInt32(new IntPtr(p + 0x020)); // 0x20 MaxCharCount                ( ModelPrimitiveType int int int Int32 )
            value.CharCount                                 = GetInt32(new IntPtr(p + 0x024)); // 0x24 CharCount                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
