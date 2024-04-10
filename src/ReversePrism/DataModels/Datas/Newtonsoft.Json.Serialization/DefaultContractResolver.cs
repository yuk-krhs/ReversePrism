using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _instance                                IContractResolver IL2CPP_TYPE_CLASS
    // 008 BlacklistedTypeNames                     string[] IL2CPP_TYPE_SZARRAY
    // 010 BuiltInConverters                        000185B8EEB0 ModelClassListType JsonConverter[] JsonConverter[] List<JsonConverter> Pointer
    // 010 NameTable                                0001866B34C0 ModelClassType DefaultJsonNameTable DefaultJsonNameTable DefaultJsonNameTable Pointer
    // 018 _contractCache                           ThreadSafeStore`2<Type, JsonContract> IL2CPP_TYPE_GENERICINST
    // 020 DefaultMembersSearchFlags                00018675D6E0 ModelEnumType BindingFlags BindingFlags BindingFlags Int32
    // 024 SerializeCompilerGeneratedMembers        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 025 IgnoreSerializableInterface              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 026 IgnoreSerializableAttribute              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 027 IgnoreIsSpecifiedMembers                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 IgnoreShouldSerializeMembers             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 NamingStrategy                           00018667F1A0 ModelClassType NamingStrategy NamingStrategy NamingStrategy Pointer
    public partial class DefaultContractResolver : DataModel
    {
        public List<JsonConverter>?                     BuiltInConverters                       { get; set; }
        public DefaultJsonNameTable?                    NameTable                               { get; set; }
        public BindingFlags                             DefaultMembersSearchFlags               { get; set; }
        public bool                                     SerializeCompilerGeneratedMembers       { get; set; }
        public bool                                     IgnoreSerializableInterface             { get; set; }
        public bool                                     IgnoreSerializableAttribute             { get; set; }
        public bool                                     IgnoreIsSpecifiedMembers                { get; set; }
        public bool                                     IgnoreShouldSerializeMembers            { get; set; }
        public NamingStrategy?                          NamingStrategy                          { get; set; }

        public static DefaultContractResolver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultContractResolver() { Pointer= p0 };

            value.BuiltInConverters                         = GetObjectList<JsonConverter>(new IntPtr(p + 0x010), ReversePrism.DataModels.JsonConverter.FromPointer); // 0245A3B729B8 0x10 BuiltInConverters           ( 000185B8EEB0 ModelClassListType JsonConverter[] JsonConverter[] List<JsonConverter> Pointer )
            value.NameTable                                 = GetObject<DefaultJsonNameTable>(new IntPtr(p + 0x010), ReversePrism.DataModels.DefaultJsonNameTable.FromPointer); // 0245A3B729D8 0x10 NameTable                   ( 0001866B34C0 ModelClassType DefaultJsonNameTable DefaultJsonNameTable DefaultJsonNameTable Pointer )
            value.DefaultMembersSearchFlags                 = (BindingFlags)GetInt32(new IntPtr(p + 0x020)); // 0245A3B72A18 0x20 DefaultMembersSearchFlags   ( 00018675D6E0 ModelEnumType BindingFlags BindingFlags BindingFlags Int32 )
            value.SerializeCompilerGeneratedMembers         = GetBool(new IntPtr(p + 0x024)); // 0245A3B72A38 0x24 SerializeCompilerGeneratedMembers ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IgnoreSerializableInterface               = GetBool(new IntPtr(p + 0x025)); // 0245A3B72A58 0x25 IgnoreSerializableInterface ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IgnoreSerializableAttribute               = GetBool(new IntPtr(p + 0x026)); // 0245A3B72A78 0x26 IgnoreSerializableAttribute ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IgnoreIsSpecifiedMembers                  = GetBool(new IntPtr(p + 0x027)); // 0245A3B72A98 0x27 IgnoreIsSpecifiedMembers    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IgnoreShouldSerializeMembers              = GetBool(new IntPtr(p + 0x028)); // 0245A3B72AB8 0x28 IgnoreShouldSerializeMembers ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NamingStrategy                            = GetObject<NamingStrategy>(new IntPtr(p + 0x030), ReversePrism.DataModels.NamingStrategy.FromPointer); // 0245A3B72AD8 0x30 NamingStrategy              ( 00018667F1A0 ModelClassType NamingStrategy NamingStrategy NamingStrategy Pointer )

            return value;
        }
    }
}
