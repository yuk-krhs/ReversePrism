using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Index                                    ModelPrimitiveType int int int Int32
    // 01C GlobalIndex                              ModelPrimitiveType int int int Int32
    // 020 SpecifiedGlobalIndex                     ModelPrimitiveType int int int Int32
    // 028 TypeData                                 ModelClassType TypeData TypeData TypeData Pointer
    // 030 Member                                   ModelClassType MemberInfo MemberInfo MemberInfo Pointer
    // 038 SpecifiedMember                          ModelClassType MemberInfo MemberInfo MemberInfo Pointer
    // 040 ShouldSerialize                          ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 048 _defaultValue                            <object> IL2CPP_TYPE_OBJECT
    // 050 Flags                                    ModelPrimitiveType int int int Int32
    public partial class XmlTypeMapMember : DataModel
    {
        public string                                   Name                                    { get; set; }
        public int                                      Index                                   { get; set; }
        public int                                      GlobalIndex                             { get; set; }
        public int                                      SpecifiedGlobalIndex                    { get; set; }
        public TypeData?                                TypeData                                { get; set; }
        public MemberInfo?                              Member                                  { get; set; }
        public MemberInfo?                              SpecifiedMember                         { get; set; }
        public MethodInfo?                              ShouldSerialize                         { get; set; }
        public int                                      Flags                                   { get; set; }

        public static XmlTypeMapMember? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlTypeMapMember() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Index                       ( ModelPrimitiveType int int int Int32 )
            value.GlobalIndex                               = GetInt32(new IntPtr(p + 0x01C)); // 0x1C GlobalIndex                 ( ModelPrimitiveType int int int Int32 )
            value.SpecifiedGlobalIndex                      = GetInt32(new IntPtr(p + 0x020)); // 0x20 SpecifiedGlobalIndex        ( ModelPrimitiveType int int int Int32 )
            value.TypeData                                  = GetObject<TypeData>(new IntPtr(p + 0x028), ReversePrism.DataModels.TypeData.FromPointer); // 0x28 TypeData                    ( ModelClassType TypeData TypeData TypeData Pointer )
            value.Member                                    = GetObject<MemberInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.MemberInfo.FromPointer); // 0x30 Member                      ( ModelClassType MemberInfo MemberInfo MemberInfo Pointer )
            value.SpecifiedMember                           = GetObject<MemberInfo>(new IntPtr(p + 0x038), ReversePrism.DataModels.MemberInfo.FromPointer); // 0x38 SpecifiedMember             ( ModelClassType MemberInfo MemberInfo MemberInfo Pointer )
            value.ShouldSerialize                           = GetObject<MethodInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x40 ShouldSerialize             ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.Flags                                     = GetInt32(new IntPtr(p + 0x050)); // 0x50 Flags                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
