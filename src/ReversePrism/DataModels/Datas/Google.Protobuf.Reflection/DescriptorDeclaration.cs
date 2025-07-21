using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Descriptor                               ModelClassType IDescriptor IDescriptor IDescriptor Pointer
    // 018 StartLine                                ModelPrimitiveType int int int Int32
    // 01C StartColumn                              ModelPrimitiveType int int int Int32
    // 020 EndLine                                  ModelPrimitiveType int int int Int32
    // 024 EndColumn                                ModelPrimitiveType int int int Int32
    // 028 LeadingComments                          ModelPrimitiveType string string string String
    // 030 TrailingComments                         ModelPrimitiveType string string string String
    // 038 LeadingDetachedComments                  ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer
    public partial class DescriptorDeclaration : DataModel
    {
        public IDescriptor?                             Descriptor                              { get; set; }
        public int                                      StartLine                               { get; set; }
        public int                                      StartColumn                             { get; set; }
        public int                                      EndLine                                 { get; set; }
        public int                                      EndColumn                               { get; set; }
        public string                                   LeadingComments                         { get; set; }
        public string                                   TrailingComments                        { get; set; }
        public List<string>?                            LeadingDetachedComments                 { get; set; }

        public static DescriptorDeclaration? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DescriptorDeclaration() { Pointer= p0 };

            value.Descriptor                                = GetObject<IDescriptor>(new IntPtr(p + 0x010), ReversePrism.DataModels.IDescriptor.FromPointer); // 0x10 Descriptor                  ( ModelClassType IDescriptor IDescriptor IDescriptor Pointer )
            value.StartLine                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 StartLine                   ( ModelPrimitiveType int int int Int32 )
            value.StartColumn                               = GetInt32(new IntPtr(p + 0x01C)); // 0x1C StartColumn                 ( ModelPrimitiveType int int int Int32 )
            value.EndLine                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 EndLine                     ( ModelPrimitiveType int int int Int32 )
            value.EndColumn                                 = GetInt32(new IntPtr(p + 0x024)); // 0x24 EndColumn                   ( ModelPrimitiveType int int int Int32 )
            value.LeadingComments                           = GetString(new IntPtr(p + 0x028)); // 0x28 LeadingComments             ( ModelPrimitiveType string string string String )
            value.TrailingComments                          = GetString(new IntPtr(p + 0x030)); // 0x30 TrailingComments            ( ModelPrimitiveType string string string String )
            value.LeadingDetachedComments                   = GetStringList(new IntPtr(p + 0x038)); // 0x38 LeadingDetachedComments     ( ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer )

            return value;
        }
    }
}
