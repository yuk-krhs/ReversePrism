using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 MinOccurs                                0001865C0970 ModelEnumType Decimal Decimal Decimal Int32
    // 060 MaxOccurs                                0001865C0970 ModelEnumType Decimal Decimal Decimal Int32
    // 070 Flags                                    00018673D7D0 ModelEnumType Occurs Occurs Occurs Int32
    // 000 Empty                                    XmlSchemaParticle IL2CPP_TYPE_CLASS
    public partial class XmlSchemaParticle : DataModel
    {
        public Decimal                                  MinOccurs                               { get; set; }
        public Decimal                                  MaxOccurs                               { get; set; }
        public Occurs                                   Flags                                   { get; set; }

        public static XmlSchemaParticle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaParticle() { Pointer= p0 };

            value.MinOccurs                                 = (Decimal)GetInt32(new IntPtr(p + 0x050)); // 0246673DF0D8 0x50 MinOccurs                   ( 0001865C0970 ModelEnumType Decimal Decimal Decimal Int32 )
            value.MaxOccurs                                 = (Decimal)GetInt32(new IntPtr(p + 0x060)); // 0246673DF0F8 0x60 MaxOccurs                   ( 0001865C0970 ModelEnumType Decimal Decimal Decimal Int32 )
            value.Flags                                     = (Occurs)GetInt32(new IntPtr(p + 0x070)); // 0246673DF118 0x70 Flags                       ( 00018673D7D0 ModelEnumType Occurs Occurs Occurs Int32 )

            return value;
        }
    }
}
