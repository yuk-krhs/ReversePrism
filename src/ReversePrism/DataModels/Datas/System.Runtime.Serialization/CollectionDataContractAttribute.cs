using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Ns                                       ModelPrimitiveType string string string String
    // 020 ItemName                                 ModelPrimitiveType string string string String
    // 028 KeyName                                  ModelPrimitiveType string string string String
    // 030 ValueName                                ModelPrimitiveType string string string String
    // 038 IsReference                              ModelPrimitiveType bool bool bool Bool
    // 039 IsNameSetExplicitly                      ModelPrimitiveType bool bool bool Bool
    // 03A IsNamespaceSetExplicitly                 ModelPrimitiveType bool bool bool Bool
    // 03B IsReferenceSetExplicitly                 ModelPrimitiveType bool bool bool Bool
    // 03C IsItemNameSetExplicitly                  ModelPrimitiveType bool bool bool Bool
    // 03D IsKeyNameSetExplicitly                   ModelPrimitiveType bool bool bool Bool
    // 03E IsValueNameSetExplicitly                 ModelPrimitiveType bool bool bool Bool
    public partial class CollectionDataContractAttribute : DataModel
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
            var value   = new CollectionDataContractAttribute() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Ns                                        = GetString(new IntPtr(p + 0x018)); // 0x18 Ns                          ( ModelPrimitiveType string string string String )
            value.ItemName                                  = GetString(new IntPtr(p + 0x020)); // 0x20 ItemName                    ( ModelPrimitiveType string string string String )
            value.KeyName                                   = GetString(new IntPtr(p + 0x028)); // 0x28 KeyName                     ( ModelPrimitiveType string string string String )
            value.ValueName                                 = GetString(new IntPtr(p + 0x030)); // 0x30 ValueName                   ( ModelPrimitiveType string string string String )
            value.IsReference                               = GetBool(new IntPtr(p + 0x038)); // 0x38 IsReference                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsNameSetExplicitly                       = GetBool(new IntPtr(p + 0x039)); // 0x39 IsNameSetExplicitly         ( ModelPrimitiveType bool bool bool Bool )
            value.IsNamespaceSetExplicitly                  = GetBool(new IntPtr(p + 0x03A)); // 0x3A IsNamespaceSetExplicitly    ( ModelPrimitiveType bool bool bool Bool )
            value.IsReferenceSetExplicitly                  = GetBool(new IntPtr(p + 0x03B)); // 0x3B IsReferenceSetExplicitly    ( ModelPrimitiveType bool bool bool Bool )
            value.IsItemNameSetExplicitly                   = GetBool(new IntPtr(p + 0x03C)); // 0x3C IsItemNameSetExplicitly     ( ModelPrimitiveType bool bool bool Bool )
            value.IsKeyNameSetExplicitly                    = GetBool(new IntPtr(p + 0x03D)); // 0x3D IsKeyNameSetExplicitly      ( ModelPrimitiveType bool bool bool Bool )
            value.IsValueNameSetExplicitly                  = GetBool(new IntPtr(p + 0x03E)); // 0x3E IsValueNameSetExplicitly    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
