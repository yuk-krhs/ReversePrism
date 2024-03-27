using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 HasWrapperElement                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 Mapping                                  000185CB3AC8 ModelClassListType XmlMemberMapping[] XmlMemberMapping[] List<XmlMemberMapping> Pointer
    public partial class XmlMembersMapping
    {
        public bool                                     HasWrapperElement                       { get; set; }
        public List<XmlMemberMapping>?                  Mapping                                 { get; set; }

        public static XmlMembersMapping? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlMembersMapping();

            value.HasWrapperElement                         = GetBool(new IntPtr(p + 0x048)); // 0270D74B9350 0x48 HasWrapperElement           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Mapping                                   = GetObjectList<XmlMemberMapping>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlMemberMapping.FromPointer); // 0270D74B9370 0x50 Mapping                     ( 000185CB3AC8 ModelClassListType XmlMemberMapping[] XmlMemberMapping[] List<XmlMemberMapping> Pointer )

            return value;
        }
    }
}
