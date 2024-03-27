using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 Ns                                       000186671910 ModelPrimitiveType string string string String
    // 020 ItemName                                 000186671910 ModelPrimitiveType string string string String
    // 028 KeyName                                  000186671910 ModelPrimitiveType string string string String
    // 030 ValueName                                000186671910 ModelPrimitiveType string string string String
    // 038 IsReference                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 039 IsNameSetExplicitly                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03A IsNamespaceSetExplicitly                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03B IsReferenceSetExplicitly                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03C IsItemNameSetExplicitly                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03D IsKeyNameSetExplicitly                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03E IsValueNameSetExplicitly                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class CollectionDataContractAttribute
    {
        public string                                   Name                                    { get; set; }
        public string                                   Ns                                      { get; set; }
        public string                                   ItemName                                { get; set; }
        public string                                   KeyName                                 { get; set; }
        public string                                   ValueName                               { get; set; }
        public bool                                     IsReference                             { get; set; }
        public bool                                     IsNameSetExplicitly                     { get; set; }
        public bool                                     IsNamespaceSetExplicitly                { get; set; }
        public bool                                     IsReferenceSetExplicitly                { get; set; }
        public bool                                     IsItemNameSetExplicitly                 { get; set; }
        public bool                                     IsKeyNameSetExplicitly                  { get; set; }
        public bool                                     IsValueNameSetExplicitly                { get; set; }

        public static CollectionDataContractAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CollectionDataContractAttribute();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 027004D5E108 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Ns                                        = GetString(new IntPtr(p + 0x018)); // 027004D5E128 0x18 Ns                          ( 000186671910 ModelPrimitiveType string string string String )
            value.ItemName                                  = GetString(new IntPtr(p + 0x020)); // 027004D5E148 0x20 ItemName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.KeyName                                   = GetString(new IntPtr(p + 0x028)); // 027004D5E168 0x28 KeyName                     ( 000186671910 ModelPrimitiveType string string string String )
            value.ValueName                                 = GetString(new IntPtr(p + 0x030)); // 027004D5E188 0x30 ValueName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.IsReference                               = GetBool(new IntPtr(p + 0x038)); // 027004D5E1A8 0x38 IsReference                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsNameSetExplicitly                       = GetBool(new IntPtr(p + 0x039)); // 027004D5E1C8 0x39 IsNameSetExplicitly         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsNamespaceSetExplicitly                  = GetBool(new IntPtr(p + 0x03A)); // 027004D5E1E8 0x3A IsNamespaceSetExplicitly    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsReferenceSetExplicitly                  = GetBool(new IntPtr(p + 0x03B)); // 027004D5E208 0x3B IsReferenceSetExplicitly    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsItemNameSetExplicitly                   = GetBool(new IntPtr(p + 0x03C)); // 027004D5E228 0x3C IsItemNameSetExplicitly     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsKeyNameSetExplicitly                    = GetBool(new IntPtr(p + 0x03D)); // 027004D5E248 0x3D IsKeyNameSetExplicitly      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsValueNameSetExplicitly                  = GetBool(new IntPtr(p + 0x03E)); // 027004D5E268 0x3E IsValueNameSetExplicitly    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
