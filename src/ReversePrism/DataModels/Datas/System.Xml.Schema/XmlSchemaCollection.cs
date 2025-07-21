using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Collection                               ModelClassType Hashtable Hashtable Hashtable Pointer
    // 018 NameTable                                ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 020 SchemaNames                              ModelClassType SchemaNames SchemaNames SchemaNames Pointer
    // 028 WLock                                    ModelClassType ReaderWriterLock ReaderWriterLock ReaderWriterLock Pointer
    // 030 Timeout                                  ModelPrimitiveType int int int Int32
    // 034 IsThreadSafe                             ModelPrimitiveType bool bool bool Bool
    // 038 ValidationEventHandler                   ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer
    // 040 XmlResolver                              ModelClassType XmlResolver XmlResolver XmlResolver Pointer
    public partial class XmlSchemaCollection : DataModel
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
            var value   = new XmlSchemaCollection() { Pointer= p0 };

            value.Collection                                = GetObject<Hashtable>(new IntPtr(p + 0x010), ReversePrism.DataModels.Hashtable.FromPointer); // 0x10 Collection                  ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlNameTable.FromPointer); // 0x18 NameTable                   ( ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.SchemaNames                               = GetObject<SchemaNames>(new IntPtr(p + 0x020), ReversePrism.DataModels.SchemaNames.FromPointer); // 0x20 SchemaNames                 ( ModelClassType SchemaNames SchemaNames SchemaNames Pointer )
            value.WLock                                     = GetObject<ReaderWriterLock>(new IntPtr(p + 0x028), ReversePrism.DataModels.ReaderWriterLock.FromPointer); // 0x28 WLock                       ( ModelClassType ReaderWriterLock ReaderWriterLock ReaderWriterLock Pointer )
            value.Timeout                                   = GetInt32(new IntPtr(p + 0x030)); // 0x30 Timeout                     ( ModelPrimitiveType int int int Int32 )
            value.IsThreadSafe                              = GetBool(new IntPtr(p + 0x034)); // 0x34 IsThreadSafe                ( ModelPrimitiveType bool bool bool Bool )
            value.ValidationEventHandler                    = GetObject<ValidationEventHandler>(new IntPtr(p + 0x038), ReversePrism.DataModels.ValidationEventHandler.FromPointer); // 0x38 ValidationEventHandler      ( ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer )
            value.XmlResolver                               = GetObject<XmlResolver>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlResolver.FromPointer); // 0x40 XmlResolver                 ( ModelClassType XmlResolver XmlResolver XmlResolver Pointer )

            return value;
        }
    }
}
