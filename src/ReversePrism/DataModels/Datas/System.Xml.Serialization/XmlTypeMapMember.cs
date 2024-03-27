using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C GlobalIndex                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 SpecifiedGlobalIndex                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 TypeData                                 0001866D2C90 ModelClassType TypeData TypeData TypeData Pointer
    // 030 Member                                   0001865F1B00 ModelClassType MemberInfo MemberInfo MemberInfo Pointer
    // 038 SpecifiedMember                          0001865F1B00 ModelClassType MemberInfo MemberInfo MemberInfo Pointer
    // 040 ShouldSerialize                          000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 048 _defaultValue                            <object> IL2CPP_TYPE_OBJECT
    // 050 Flags                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class XmlTypeMapMember
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
            var value   = new XmlTypeMapMember();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D74BFC88 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 0270D74BFCA8 0x18 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GlobalIndex                               = GetInt32(new IntPtr(p + 0x01C)); // 0270D74BFCC8 0x1C GlobalIndex                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SpecifiedGlobalIndex                      = GetInt32(new IntPtr(p + 0x020)); // 0270D74BFCE8 0x20 SpecifiedGlobalIndex        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TypeData                                  = GetObject<TypeData>(new IntPtr(p + 0x028), ReversePrism.DataModels.TypeData.FromPointer); // 0270D74BFD08 0x28 TypeData                    ( 0001866D2C90 ModelClassType TypeData TypeData TypeData Pointer )
            value.Member                                    = GetObject<MemberInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.MemberInfo.FromPointer); // 0270D74BFD28 0x30 Member                      ( 0001865F1B00 ModelClassType MemberInfo MemberInfo MemberInfo Pointer )
            value.SpecifiedMember                           = GetObject<MemberInfo>(new IntPtr(p + 0x038), ReversePrism.DataModels.MemberInfo.FromPointer); // 0270D74BFD48 0x38 SpecifiedMember             ( 0001865F1B00 ModelClassType MemberInfo MemberInfo MemberInfo Pointer )
            value.ShouldSerialize                           = GetObject<MethodInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D74BFD68 0x40 ShouldSerialize             ( 000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.Flags                                     = GetInt32(new IntPtr(p + 0x050)); // 0270D74BFDA8 0x50 Flags                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
