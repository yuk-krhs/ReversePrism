using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SchemaName                               ModelPrimitiveType string string string String
    // 018 SchemaUri                                ModelPrimitiveType string string string String
    // 020 SchemaRoot                               ModelClassType XmlElement XmlElement XmlElement Pointer
    // 028 Ds                                       ModelClassType DataSet DataSet DataSet Pointer
    // 000 s_colonArray                             char[] IL2CPP_TYPE_SZARRAY
    // 008 s_mapNameTypeXdr                         NameType[] IL2CPP_TYPE_SZARRAY
    // 010 S_enumerationNameType                    ModelClassType NameType NameType NameType Pointer
    public partial class XDRSchema : DataModel
    {
        public string                                   SchemaName                              { get; set; }
        public string                                   SchemaUri                               { get; set; }
        public XmlElement?                              SchemaRoot                              { get; set; }
        public DataSet?                                 Ds                                      { get; set; }
        public NameType?                                S_enumerationNameType                   { get; set; }

        public static XDRSchema? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XDRSchema() { Pointer= p0 };

            value.SchemaName                                = GetString(new IntPtr(p + 0x010)); // 0x10 SchemaName                  ( ModelPrimitiveType string string string String )
            value.SchemaUri                                 = GetString(new IntPtr(p + 0x018)); // 0x18 SchemaUri                   ( ModelPrimitiveType string string string String )
            value.SchemaRoot                                = GetObject<XmlElement>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlElement.FromPointer); // 0x20 SchemaRoot                  ( ModelClassType XmlElement XmlElement XmlElement Pointer )
            value.Ds                                        = GetObject<DataSet>(new IntPtr(p + 0x028), ReversePrism.DataModels.DataSet.FromPointer); // 0x28 Ds                          ( ModelClassType DataSet DataSet DataSet Pointer )
            value.S_enumerationNameType                     = GetObject<NameType>(new IntPtr(p + 0x010), ReversePrism.DataModels.NameType.FromPointer); // 0x10 S_enumerationNameType       ( ModelClassType NameType NameType NameType Pointer )

            return value;
        }
    }
}
