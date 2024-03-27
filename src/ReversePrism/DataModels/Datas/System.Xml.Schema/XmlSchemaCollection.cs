using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Collection                               0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 018 NameTable                                0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 020 SchemaNames                              0001866EA5B0 ModelClassType SchemaNames SchemaNames SchemaNames Pointer
    // 028 WLock                                    00018661FAD0 ModelClassType ReaderWriterLock ReaderWriterLock ReaderWriterLock Pointer
    // 030 Timeout                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 IsThreadSafe                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 ValidationEventHandler                   000186765AD0 ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer
    // 040 XmlResolver                              0001865ABBE0 ModelClassType XmlResolver XmlResolver XmlResolver Pointer
    public partial class XmlSchemaCollection
    {
        public Hashtable?                               Collection                              { get; set; }
        public XmlNameTable?                            NameTable                               { get; set; }
        public SchemaNames?                             SchemaNames                             { get; set; }
        public ReaderWriterLock?                        WLock                                   { get; set; }
        public int                                      Timeout                                 { get; set; }
        public bool                                     IsThreadSafe                            { get; set; }
        public ValidationEventHandler?                  ValidationEventHandler                  { get; set; }
        public XmlResolver?                             XmlResolver                             { get; set; }

        public static XmlSchemaCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaCollection();

            value.Collection                                = GetObject<Hashtable>(new IntPtr(p + 0x010), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D7404540 0x10 Collection                  ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlNameTable.FromPointer); // 0270D7404560 0x18 NameTable                   ( 0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.SchemaNames                               = GetObject<SchemaNames>(new IntPtr(p + 0x020), ReversePrism.DataModels.SchemaNames.FromPointer); // 0270D7404580 0x20 SchemaNames                 ( 0001866EA5B0 ModelClassType SchemaNames SchemaNames SchemaNames Pointer )
            value.WLock                                     = GetObject<ReaderWriterLock>(new IntPtr(p + 0x028), ReversePrism.DataModels.ReaderWriterLock.FromPointer); // 0270D74045A0 0x28 WLock                       ( 00018661FAD0 ModelClassType ReaderWriterLock ReaderWriterLock ReaderWriterLock Pointer )
            value.Timeout                                   = GetInt32(new IntPtr(p + 0x030)); // 0270D74045C0 0x30 Timeout                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsThreadSafe                              = GetBool(new IntPtr(p + 0x034)); // 0270D74045E0 0x34 IsThreadSafe                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ValidationEventHandler                    = GetObject<ValidationEventHandler>(new IntPtr(p + 0x038), ReversePrism.DataModels.ValidationEventHandler.FromPointer); // 0270D7404600 0x38 ValidationEventHandler      ( 000186765AD0 ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer )
            value.XmlResolver                               = GetObject<XmlResolver>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlResolver.FromPointer); // 0270D7404620 0x40 XmlResolver                 ( 0001865ABBE0 ModelClassType XmlResolver XmlResolver XmlResolver Pointer )

            return value;
        }
    }
}
