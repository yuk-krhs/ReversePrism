using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FullTypeName                             000186671BA0 ModelPrimitiveType string string string String
    // 018 AssemblyString                           000186671BA0 ModelPrimitiveType string string string String
    // 020 HasTypeForwardedFrom                     000186595210 ModelPrimitiveType bool bool bool Bool
    // 028 MemberInfos                              000185B93050 ModelClassListType MemberInfo[] MemberInfo[] List<MemberInfo> Pointer
    // 030 MemberNames                              000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 038 MemberTypes                              000185B82D40 ModelClassListType Type[] Type[] List<Type> Pointer
    public partial class SerObjectInfoCache
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
            var value   = new SerObjectInfoCache();

            value.FullTypeName                              = GetString(new IntPtr(p + 0x010)); // 0270D6C543F0 0x10 FullTypeName                ( 000186671BA0 ModelPrimitiveType string string string String )
            value.AssemblyString                            = GetString(new IntPtr(p + 0x018)); // 0270D6C54410 0x18 AssemblyString              ( 000186671BA0 ModelPrimitiveType string string string String )
            value.HasTypeForwardedFrom                      = GetBool(new IntPtr(p + 0x020)); // 0270D6C54430 0x20 HasTypeForwardedFrom        ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.MemberInfos                               = GetObjectList<MemberInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.MemberInfo.FromPointer); // 0270D6C54450 0x28 MemberInfos                 ( 000185B93050 ModelClassListType MemberInfo[] MemberInfo[] List<MemberInfo> Pointer )
            value.MemberNames                               = GetStringList(new IntPtr(p + 0x030)); // 0270D6C54470 0x30 MemberNames                 ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.MemberTypes                               = GetObjectList<Type>(new IntPtr(p + 0x038), ReversePrism.DataModels.Type.FromPointer); // 0270D6C54490 0x38 MemberTypes                 ( 000185B82D40 ModelClassListType Type[] Type[] List<Type> Pointer )

            return value;
        }
    }
}
