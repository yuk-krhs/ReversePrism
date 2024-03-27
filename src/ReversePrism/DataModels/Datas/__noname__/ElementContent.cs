using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ElementDecl                              0001866E8630 ModelClassType SchemaElementDecl SchemaElementDecl SchemaElementDecl Pointer
    // 018 ContentAttr                              0001865F2F90 ModelPrimitiveType int int int Int32
    // 01C OrderAttr                                0001865F2F90 ModelPrimitiveType int int int Int32
    // 020 MasterGroupRequired                      000186595210 ModelPrimitiveType bool bool bool Bool
    // 021 ExistTerminal                            000186595210 ModelPrimitiveType bool bool bool Bool
    // 022 AllowDataType                            000186595210 ModelPrimitiveType bool bool bool Bool
    // 023 HasDataType                              000186595210 ModelPrimitiveType bool bool bool Bool
    // 024 HasType                                  000186595210 ModelPrimitiveType bool bool bool Bool
    // 025 EnumerationRequired                      000186595210 ModelPrimitiveType bool bool bool Bool
    // 028 MinVal                                   000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 02C MaxVal                                   000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 030 MaxLength                                000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 034 MinLength                                000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 038 AttDefList                               0001865DE5A0 ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class ElementContent
    {
        public SchemaElementDecl?                       ElementDecl                             { get; set; }
        public int                                      ContentAttr                             { get; set; }
        public int                                      OrderAttr                               { get; set; }
        public bool                                     MasterGroupRequired                     { get; set; }
        public bool                                     ExistTerminal                           { get; set; }
        public bool                                     AllowDataType                           { get; set; }
        public bool                                     HasDataType                             { get; set; }
        public bool                                     HasType                                 { get; set; }
        public bool                                     EnumerationRequired                     { get; set; }
        public uint                                     MinVal                                  { get; set; }
        public uint                                     MaxVal                                  { get; set; }
        public uint                                     MaxLength                               { get; set; }
        public uint                                     MinLength                               { get; set; }
        public Hashtable?                               AttDefList                              { get; set; }

        public static ElementContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ElementContent();

            value.ElementDecl                               = GetObject<SchemaElementDecl>(new IntPtr(p + 0x010), ReversePrism.DataModels.SchemaElementDecl.FromPointer); // 0270D7585A78 0x10 ElementDecl                 ( 0001866E8630 ModelClassType SchemaElementDecl SchemaElementDecl SchemaElementDecl Pointer )
            value.ContentAttr                               = GetInt32(new IntPtr(p + 0x018)); // 0270D7585A98 0x18 ContentAttr                 ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.OrderAttr                                 = GetInt32(new IntPtr(p + 0x01C)); // 0270D7585AB8 0x1C OrderAttr                   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.MasterGroupRequired                       = GetBool(new IntPtr(p + 0x020)); // 0270D7585AD8 0x20 MasterGroupRequired         ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.ExistTerminal                             = GetBool(new IntPtr(p + 0x021)); // 0270D7585AF8 0x21 ExistTerminal               ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.AllowDataType                             = GetBool(new IntPtr(p + 0x022)); // 0270D7585B18 0x22 AllowDataType               ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.HasDataType                               = GetBool(new IntPtr(p + 0x023)); // 0270D7585B38 0x23 HasDataType                 ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.HasType                                   = GetBool(new IntPtr(p + 0x024)); // 0270D7585B58 0x24 HasType                     ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.EnumerationRequired                       = GetBool(new IntPtr(p + 0x025)); // 0270D7585B78 0x25 EnumerationRequired         ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.MinVal                                    = GetUInt32(new IntPtr(p + 0x028)); // 0270D7585B98 0x28 MinVal                      ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.MaxVal                                    = GetUInt32(new IntPtr(p + 0x02C)); // 0270D7585BB8 0x2C MaxVal                      ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.MaxLength                                 = GetUInt32(new IntPtr(p + 0x030)); // 0270D7585BD8 0x30 MaxLength                   ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.MinLength                                 = GetUInt32(new IntPtr(p + 0x034)); // 0270D7585BF8 0x34 MinLength                   ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.AttDefList                                = GetObject<Hashtable>(new IntPtr(p + 0x038), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D7585C18 0x38 AttDefList                  ( 0001865DE5A0 ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
