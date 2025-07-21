using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Prefix                                   ModelPrimitiveType string string string String
    // 018 LocalName                                ModelPrimitiveType string string string String
    // 020 Ns                                       ModelPrimitiveType string string string String
    // 028 Name                                     ModelPrimitiveType string string string String
    // 030 HashCode                                 ModelPrimitiveType int int int Int32
    // 038 OwnerDoc                                 ModelClassType XmlDocument XmlDocument XmlDocument Pointer
    // 040 Next                                     ModelClassType XmlName XmlName XmlName Pointer
    public partial class XmlName : DataModel
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
            var value   = new XmlName() { Pointer= p0 };

            value.Prefix                                    = GetString(new IntPtr(p + 0x010)); // 0x10 Prefix                      ( ModelPrimitiveType string string string String )
            value.LocalName                                 = GetString(new IntPtr(p + 0x018)); // 0x18 LocalName                   ( ModelPrimitiveType string string string String )
            value.Ns                                        = GetString(new IntPtr(p + 0x020)); // 0x20 Ns                          ( ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0x28 Name                        ( ModelPrimitiveType string string string String )
            value.HashCode                                  = GetInt32(new IntPtr(p + 0x030)); // 0x30 HashCode                    ( ModelPrimitiveType int int int Int32 )
            value.OwnerDoc                                  = GetObject<XmlDocument>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlDocument.FromPointer); // 0x38 OwnerDoc                    ( ModelClassType XmlDocument XmlDocument XmlDocument Pointer )
            value.Next                                      = GetObject<XmlName>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlName.FromPointer); // 0x40 Next                        ( ModelClassType XmlName XmlName XmlName Pointer )

            return value;
        }
    }
}
