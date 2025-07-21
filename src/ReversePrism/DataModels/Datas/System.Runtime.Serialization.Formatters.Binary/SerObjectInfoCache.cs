using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FullTypeName                             ModelPrimitiveType string string string String
    // 018 AssemblyString                           ModelPrimitiveType string string string String
    // 020 HasTypeForwardedFrom                     ModelPrimitiveType bool bool bool Bool
    // 028 MemberInfos                              ModelClassListType MemberInfo[] MemberInfo[] List<MemberInfo> Pointer
    // 030 MemberNames                              ModelPrimitiveListType string[] string[] List<string> Pointer
    // 038 MemberTypes                              ModelClassListType Type[] Type[] List<Type> Pointer
    public partial class SerObjectInfoCache : DataModel
    {
        public string                                   FullTypeName                            { get; set; }
        public string                                   AssemblyString                          { get; set; }
        public bool                                     HasTypeForwardedFrom                    { get; set; }
        public List<MemberInfo>?                        MemberInfos                             { get; set; }
        public List<string>?                            MemberNames                             { get; set; }
        public List<Type>?                              MemberTypes                             { get; set; }

        public static SerObjectInfoCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerObjectInfoCache() { Pointer= p0 };

            value.FullTypeName                              = GetString(new IntPtr(p + 0x010)); // 0x10 FullTypeName                ( ModelPrimitiveType string string string String )
            value.AssemblyString                            = GetString(new IntPtr(p + 0x018)); // 0x18 AssemblyString              ( ModelPrimitiveType string string string String )
            value.HasTypeForwardedFrom                      = GetBool(new IntPtr(p + 0x020)); // 0x20 HasTypeForwardedFrom        ( ModelPrimitiveType bool bool bool Bool )
            value.MemberInfos                               = GetObjectList<MemberInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.MemberInfo.FromPointer); // 0x28 MemberInfos                 ( ModelClassListType MemberInfo[] MemberInfo[] List<MemberInfo> Pointer )
            value.MemberNames                               = GetStringList(new IntPtr(p + 0x030)); // 0x30 MemberNames                 ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.MemberTypes                               = GetObjectList<Type>(new IntPtr(p + 0x038), ReversePrism.DataModels.Type.FromPointer); // 0x38 MemberTypes                 ( ModelClassListType Type[] Type[] List<Type> Pointer )

            return value;
        }
    }
}
