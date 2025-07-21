using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Prefix                                   ModelPrimitiveType string string string String
    // 020 DefaultNs                                ModelPrimitiveType string string string String
    // 028 DefaultNsState                           ModelEnumType NamespaceState NamespaceState NamespaceState Int32
    // 02C XmlSpace                                 ModelEnumType XmlSpace XmlSpace XmlSpace Int32
    // 030 XmlLang                                  ModelPrimitiveType string string string String
    // 038 PrevNsTop                                ModelPrimitiveType int int int Int32
    // 03C PrefixCount                              ModelPrimitiveType int int int Int32
    // 040 Mixed                                    ModelPrimitiveType bool bool bool Bool
    public partial class TagInfo : DataModel
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
            var value   = new TagInfo() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Prefix                                    = GetString(new IntPtr(p + 0x018)); // 0x18 Prefix                      ( ModelPrimitiveType string string string String )
            value.DefaultNs                                 = GetString(new IntPtr(p + 0x020)); // 0x20 DefaultNs                   ( ModelPrimitiveType string string string String )
            value.DefaultNsState                            = (NamespaceState)GetInt32(new IntPtr(p + 0x028)); // 0x28 DefaultNsState              ( ModelEnumType NamespaceState NamespaceState NamespaceState Int32 )
            value.XmlSpace                                  = (XmlSpace)GetInt32(new IntPtr(p + 0x02C)); // 0x2C XmlSpace                    ( ModelEnumType XmlSpace XmlSpace XmlSpace Int32 )
            value.XmlLang                                   = GetString(new IntPtr(p + 0x030)); // 0x30 XmlLang                     ( ModelPrimitiveType string string string String )
            value.PrevNsTop                                 = GetInt32(new IntPtr(p + 0x038)); // 0x38 PrevNsTop                   ( ModelPrimitiveType int int int Int32 )
            value.PrefixCount                               = GetInt32(new IntPtr(p + 0x03C)); // 0x3C PrefixCount                 ( ModelPrimitiveType int int int Int32 )
            value.Mixed                                     = GetBool(new IntPtr(p + 0x040)); // 0x40 Mixed                       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
