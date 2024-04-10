using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Documentation> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SummaryFieldNumber                       int IL2CPP_TYPE_I4
    // 018 Summary                                  000186671910 ModelPrimitiveType string string string String
    // 000 PagesFieldNumber                         int IL2CPP_TYPE_I4
    // 008 _repeated_pages_codec                    FieldCodec`1<Page> IL2CPP_TYPE_GENERICINST
    // 020 Pages                                    000185CE85C8 ModelClassListType RepeatedField`1<Page> RepeatedField`1<Page> List<Page> Pointer
    // 000 RulesFieldNumber                         int IL2CPP_TYPE_I4
    // 010 _repeated_rules_codec                    FieldCodec`1<DocumentationRule> IL2CPP_TYPE_GENERICINST
    // 028 Rules                                    000185CD39A8 ModelClassListType RepeatedField`1<DocumentationRule> RepeatedField`1<DocumentationRule> List<DocumentationRule> Pointer
    // 000 DocumentationRootUrlFieldNumber          int IL2CPP_TYPE_I4
    // 030 DocumentationRootUrl                     000186671910 ModelPrimitiveType string string string String
    // 000 ServiceRootUrlFieldNumber                int IL2CPP_TYPE_I4
    // 038 ServiceRootUrl                           000186671910 ModelPrimitiveType string string string String
    // 000 OverviewFieldNumber                      int IL2CPP_TYPE_I4
    // 040 Overview                                 000186671910 ModelPrimitiveType string string string String
    public partial class Documentation : DataModel
    {
        public string                                   Summary                                 { get; set; }
        public List<Page>?                              Pages                                   { get; set; }
        public List<DocumentationRule>?                 Rules                                   { get; set; }
        public string                                   DocumentationRootUrl                    { get; set; }
        public string                                   ServiceRootUrl                          { get; set; }
        public string                                   Overview                                { get; set; }

        public static Documentation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Documentation() { Pointer= p0 };

            value.Summary                                   = GetString(new IntPtr(p + 0x018)); // 02466A81BF58 0x18 Summary                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Pages                                     = GetObjectList<Page>(new IntPtr(p + 0x020), ReversePrism.DataModels.Page.FromPointer); // 02466A81BFB8 0x20 Pages                       ( 000185CE85C8 ModelClassListType RepeatedField`1<Page> RepeatedField`1<Page> List<Page> Pointer )
            value.Rules                                     = GetObjectList<DocumentationRule>(new IntPtr(p + 0x028), ReversePrism.DataModels.DocumentationRule.FromPointer); // 02466A81C018 0x28 Rules                       ( 000185CD39A8 ModelClassListType RepeatedField`1<DocumentationRule> RepeatedField`1<DocumentationRule> List<DocumentationRule> Pointer )
            value.DocumentationRootUrl                      = GetString(new IntPtr(p + 0x030)); // 02466A81C058 0x30 DocumentationRootUrl        ( 000186671910 ModelPrimitiveType string string string String )
            value.ServiceRootUrl                            = GetString(new IntPtr(p + 0x038)); // 02466A81C098 0x38 ServiceRootUrl              ( 000186671910 ModelPrimitiveType string string string String )
            value.Overview                                  = GetString(new IntPtr(p + 0x040)); // 02466A81C0D8 0x40 Overview                    ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
