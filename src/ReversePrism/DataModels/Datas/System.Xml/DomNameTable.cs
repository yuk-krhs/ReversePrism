using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Entries                                  000185CB3BB8 ModelClassListType XmlName[] XmlName[] List<XmlName> Pointer
    // 018 Count                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Mask                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 OwnerDocument                            000186595990 ModelClassType XmlDocument XmlDocument XmlDocument Pointer
    // 028 NameTable                                0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    public partial class DomNameTable : DataModel
    {
        public List<XmlName>?                           Entries                                 { get; set; }
        public int                                      Count                                   { get; set; }
        public int                                      Mask                                    { get; set; }
        public XmlDocument?                             OwnerDocument                           { get; set; }
        public XmlNameTable?                            NameTable                               { get; set; }

        public static DomNameTable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DomNameTable() { Pointer= p0 };

            value.Entries                                   = GetObjectList<XmlName>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlName.FromPointer); // 0246674AA238 0x10 Entries                     ( 000185CB3BB8 ModelClassListType XmlName[] XmlName[] List<XmlName> Pointer )
            value.Count                                     = GetInt32(new IntPtr(p + 0x018)); // 0246674AA258 0x18 Count                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Mask                                      = GetInt32(new IntPtr(p + 0x01C)); // 0246674AA278 0x1C Mask                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OwnerDocument                             = GetObject<XmlDocument>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlDocument.FromPointer); // 0246674AA298 0x20 OwnerDocument               ( 000186595990 ModelClassType XmlDocument XmlDocument XmlDocument Pointer )
            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlNameTable.FromPointer); // 0246674AA2B8 0x28 NameTable                   ( 0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )

            return value;
        }
    }
}
