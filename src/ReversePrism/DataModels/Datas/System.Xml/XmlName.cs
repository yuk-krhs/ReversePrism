using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Prefix                                   000186671910 ModelPrimitiveType string string string String
    // 018 LocalName                                000186671910 ModelPrimitiveType string string string String
    // 020 Ns                                       000186671910 ModelPrimitiveType string string string String
    // 028 Name                                     000186671910 ModelPrimitiveType string string string String
    // 030 HashCode                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 OwnerDoc                                 000186595C60 ModelClassType XmlDocument XmlDocument XmlDocument Pointer
    // 040 Next                                     0001865A0190 ModelClassType XmlName XmlName XmlName Pointer
    public partial class XmlName
    {
        public string                                   Prefix                                  { get; set; }
        public string                                   LocalName                               { get; set; }
        public string                                   Ns                                      { get; set; }
        public string                                   Name                                    { get; set; }
        public int                                      HashCode                                { get; set; }
        public XmlDocument?                             OwnerDoc                                { get; set; }
        public XmlName?                                 Next                                    { get; set; }

        public static XmlName? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlName();

            value.Prefix                                    = GetString(new IntPtr(p + 0x010)); // 0270D744A9C0 0x10 Prefix                      ( 000186671910 ModelPrimitiveType string string string String )
            value.LocalName                                 = GetString(new IntPtr(p + 0x018)); // 0270D744A9E0 0x18 LocalName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Ns                                        = GetString(new IntPtr(p + 0x020)); // 0270D744AA00 0x20 Ns                          ( 000186671910 ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0270D744AA20 0x28 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.HashCode                                  = GetInt32(new IntPtr(p + 0x030)); // 0270D744AA40 0x30 HashCode                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OwnerDoc                                  = GetObject<XmlDocument>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlDocument.FromPointer); // 0270D744AA60 0x38 OwnerDoc                    ( 000186595C60 ModelClassType XmlDocument XmlDocument XmlDocument Pointer )
            value.Next                                      = GetObject<XmlName>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlName.FromPointer); // 0270D744AA80 0x40 Next                        ( 0001865A0190 ModelClassType XmlName XmlName XmlName Pointer )

            return value;
        }
    }
}
