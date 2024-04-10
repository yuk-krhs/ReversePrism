using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 XmlType                                  0001866BFF90 ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer
    // 018 objVal                                   <object> IL2CPP_TYPE_OBJECT
    // 020 ClrType                                  000186694BC0 ModelEnumType TypeCode TypeCode TypeCode Int32
    // 028 UnionVal                                 000186728780 ModelEnumType Union Union Union Int32
    // 030 NsPrefix                                 0001867282E0 ModelClassType NamespacePrefixForQName NamespacePrefixForQName NamespacePrefixForQName Pointer
    public partial class XmlAtomicValue : DataModel
    {
        public XmlSchemaType?                           XmlType                                 { get; set; }
        public TypeCode                                 ClrType                                 { get; set; }
        public Union                                    UnionVal                                { get; set; }
        public NamespacePrefixForQName?                 NsPrefix                                { get; set; }

        public static XmlAtomicValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlAtomicValue() { Pointer= p0 };

            value.XmlType                                   = GetObject<XmlSchemaType>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSchemaType.FromPointer); // 0246675FEC20 0x10 XmlType                     ( 0001866BFF90 ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer )
            value.ClrType                                   = (TypeCode)GetInt32(new IntPtr(p + 0x020)); // 0246675FEC60 0x20 ClrType                     ( 000186694BC0 ModelEnumType TypeCode TypeCode TypeCode Int32 )
            value.UnionVal                                  = (Union)GetInt32(new IntPtr(p + 0x028)); // 0246675FEC80 0x28 UnionVal                    ( 000186728780 ModelEnumType Union Union Union Int32 )
            value.NsPrefix                                  = GetObject<NamespacePrefixForQName>(new IntPtr(p + 0x030), ReversePrism.DataModels.NamespacePrefixForQName.FromPointer); // 0246675FECA0 0x30 NsPrefix                    ( 0001867282E0 ModelClassType NamespacePrefixForQName NamespacePrefixForQName NamespacePrefixForQName Pointer )

            return value;
        }
    }
}
