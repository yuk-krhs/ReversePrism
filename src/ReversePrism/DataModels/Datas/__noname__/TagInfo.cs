using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671BA0 ModelPrimitiveType string string string String
    // 018 Prefix                                   000186671BA0 ModelPrimitiveType string string string String
    // 020 DefaultNs                                000186671BA0 ModelPrimitiveType string string string String
    // 028 DefaultNsState                           000186746BE0 ModelEnumType NamespaceState NamespaceState NamespaceState Int32
    // 02C XmlSpace                                 0001865CA4B0 ModelEnumType XmlSpace XmlSpace XmlSpace Int32
    // 030 XmlLang                                  000186671BA0 ModelPrimitiveType string string string String
    // 038 PrevNsTop                                0001865F2F90 ModelPrimitiveType int int int Int32
    // 03C PrefixCount                              0001865F2F90 ModelPrimitiveType int int int Int32
    // 040 Mixed                                    000186595210 ModelPrimitiveType bool bool bool Bool
    public partial class TagInfo
    {
        public string                                   Name                                    { get; set; }
        public string                                   Prefix                                  { get; set; }
        public string                                   DefaultNs                               { get; set; }
        public NamespaceState                           DefaultNsState                          { get; set; }
        public XmlSpace                                 XmlSpace                                { get; set; }
        public string                                   XmlLang                                 { get; set; }
        public int                                      PrevNsTop                               { get; set; }
        public int                                      PrefixCount                             { get; set; }
        public bool                                     Mixed                                   { get; set; }

        public static TagInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TagInfo();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D73E5FB0 0x10 Name                        ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Prefix                                    = GetString(new IntPtr(p + 0x018)); // 0270D73E5FD0 0x18 Prefix                      ( 000186671BA0 ModelPrimitiveType string string string String )
            value.DefaultNs                                 = GetString(new IntPtr(p + 0x020)); // 0270D73E5FF0 0x20 DefaultNs                   ( 000186671BA0 ModelPrimitiveType string string string String )
            value.DefaultNsState                            = (NamespaceState)GetInt32(new IntPtr(p + 0x028)); // 0270D73E6010 0x28 DefaultNsState              ( 000186746BE0 ModelEnumType NamespaceState NamespaceState NamespaceState Int32 )
            value.XmlSpace                                  = (XmlSpace)GetInt32(new IntPtr(p + 0x02C)); // 0270D73E6030 0x2C XmlSpace                    ( 0001865CA4B0 ModelEnumType XmlSpace XmlSpace XmlSpace Int32 )
            value.XmlLang                                   = GetString(new IntPtr(p + 0x030)); // 0270D73E6050 0x30 XmlLang                     ( 000186671BA0 ModelPrimitiveType string string string String )
            value.PrevNsTop                                 = GetInt32(new IntPtr(p + 0x038)); // 0270D73E6070 0x38 PrevNsTop                   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.PrefixCount                               = GetInt32(new IntPtr(p + 0x03C)); // 0270D73E6090 0x3C PrefixCount                 ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Mixed                                     = GetBool(new IntPtr(p + 0x040)); // 0270D73E60B0 0x40 Mixed                       ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
