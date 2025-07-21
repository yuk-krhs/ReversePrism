using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ElementDecl                              ModelClassType SchemaElementDecl SchemaElementDecl SchemaElementDecl Pointer
    // 018 ContentAttr                              ModelPrimitiveType int int int Int32
    // 01C OrderAttr                                ModelPrimitiveType int int int Int32
    // 020 MasterGroupRequired                      ModelPrimitiveType bool bool bool Bool
    // 021 ExistTerminal                            ModelPrimitiveType bool bool bool Bool
    // 022 AllowDataType                            ModelPrimitiveType bool bool bool Bool
    // 023 HasDataType                              ModelPrimitiveType bool bool bool Bool
    // 024 HasType                                  ModelPrimitiveType bool bool bool Bool
    // 025 EnumerationRequired                      ModelPrimitiveType bool bool bool Bool
    // 028 MinVal                                   ModelPrimitiveType uint uint uint UInt32
    // 02C MaxVal                                   ModelPrimitiveType uint uint uint UInt32
    // 030 MaxLength                                ModelPrimitiveType uint uint uint UInt32
    // 034 MinLength                                ModelPrimitiveType uint uint uint UInt32
    // 038 AttDefList                               ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class ElementContent : DataModel
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
            var value   = new ElementContent() { Pointer= p0 };

            value.ElementDecl                               = GetObject<SchemaElementDecl>(new IntPtr(p + 0x010), ReversePrism.DataModels.SchemaElementDecl.FromPointer); // 0x10 ElementDecl                 ( ModelClassType SchemaElementDecl SchemaElementDecl SchemaElementDecl Pointer )
            value.ContentAttr                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 ContentAttr                 ( ModelPrimitiveType int int int Int32 )
            value.OrderAttr                                 = GetInt32(new IntPtr(p + 0x01C)); // 0x1C OrderAttr                   ( ModelPrimitiveType int int int Int32 )
            value.MasterGroupRequired                       = GetBool(new IntPtr(p + 0x020)); // 0x20 MasterGroupRequired         ( ModelPrimitiveType bool bool bool Bool )
            value.ExistTerminal                             = GetBool(new IntPtr(p + 0x021)); // 0x21 ExistTerminal               ( ModelPrimitiveType bool bool bool Bool )
            value.AllowDataType                             = GetBool(new IntPtr(p + 0x022)); // 0x22 AllowDataType               ( ModelPrimitiveType bool bool bool Bool )
            value.HasDataType                               = GetBool(new IntPtr(p + 0x023)); // 0x23 HasDataType                 ( ModelPrimitiveType bool bool bool Bool )
            value.HasType                                   = GetBool(new IntPtr(p + 0x024)); // 0x24 HasType                     ( ModelPrimitiveType bool bool bool Bool )
            value.EnumerationRequired                       = GetBool(new IntPtr(p + 0x025)); // 0x25 EnumerationRequired         ( ModelPrimitiveType bool bool bool Bool )
            value.MinVal                                    = GetUInt32(new IntPtr(p + 0x028)); // 0x28 MinVal                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.MaxVal                                    = GetUInt32(new IntPtr(p + 0x02C)); // 0x2C MaxVal                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.MaxLength                                 = GetUInt32(new IntPtr(p + 0x030)); // 0x30 MaxLength                   ( ModelPrimitiveType uint uint uint UInt32 )
            value.MinLength                                 = GetUInt32(new IntPtr(p + 0x034)); // 0x34 MinLength                   ( ModelPrimitiveType uint uint uint UInt32 )
            value.AttDefList                                = GetObject<Hashtable>(new IntPtr(p + 0x038), ReversePrism.DataModels.Hashtable.FromPointer); // 0x38 AttDefList                  ( ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
