using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 HasWrapperElement                        ModelPrimitiveType bool bool bool Bool
    // 050 Mapping                                  ModelClassListType XmlMemberMapping[] XmlMemberMapping[] List<XmlMemberMapping> Pointer
    public partial class XmlMembersMapping : DataModel
    {
        public bool                                     HasWrapperElement                       { get; set; }
        public List<XmlMemberMapping>?                  Mapping                                 { get; set; }

        public static XmlMembersMapping? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlMembersMapping() { Pointer= p0 };

            value.HasWrapperElement                         = GetBool(new IntPtr(p + 0x048)); // 0x48 HasWrapperElement           ( ModelPrimitiveType bool bool bool Bool )
            value.Mapping                                   = GetObjectList<XmlMemberMapping>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlMemberMapping.FromPointer); // 0x50 Mapping                     ( ModelClassListType XmlMemberMapping[] XmlMemberMapping[] List<XmlMemberMapping> Pointer )

            return value;
        }
    }
}
