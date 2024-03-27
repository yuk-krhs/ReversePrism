using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 opRecordIdCount                          int IL2CPP_TYPE_I4
    // 010 IsInitial                                000186595210 ModelPrimitiveType bool bool bool Bool
    // 014 Count                                    0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 ExpectedType                             000186592980 ModelEnumType BinaryTypeEnum BinaryTypeEnum BinaryTypeEnum Int32
    // 020 expectedTypeInformation                  <object> IL2CPP_TYPE_OBJECT
    // 028 Name                                     000186671BA0 ModelPrimitiveType string string string String
    // 030 ObjectTypeEnum                           00018671D830 ModelEnumType InternalObjectTypeE InternalObjectTypeE InternalObjectTypeE Int32
    // 034 MemberTypeEnum                           00018671C000 ModelEnumType InternalMemberTypeE InternalMemberTypeE InternalMemberTypeE Int32
    // 038 MemberValueEnum                          00018671C760 ModelEnumType InternalMemberValueE InternalMemberValueE InternalMemberValueE Int32
    // 040 DtType                                   000186692A80 ModelClassType Type Type Type Pointer
    // 048 NumItems                                 0001865F2F90 ModelPrimitiveType int int int Int32
    // 04C BinaryTypeEnum                           000186592980 ModelEnumType BinaryTypeEnum BinaryTypeEnum BinaryTypeEnum Int32
    // 050 typeInformation                          <object> IL2CPP_TYPE_OBJECT
    // 058 NullCount                                0001865F2F90 ModelPrimitiveType int int int Int32
    // 05C MemberLength                             0001865F2F90 ModelPrimitiveType int int int Int32
    // 060 BinaryTypeEnumA                          000185B71C30 ModelEnumListType BinaryTypeEnum[] BinaryTypeEnum[] List<BinaryTypeEnum> Pointer
    // 068 typeInformationA                         <object>[] IL2CPP_TYPE_SZARRAY
    // 070 MemberNames                              000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 078 MemberTypes                              000185B82D40 ModelClassListType Type[] Type[] List<Type> Pointer
    // 080 Pr                                       000186720840 ModelClassType ParseRecord ParseRecord ParseRecord Pointer
    public partial class ObjectProgress
    {
        public bool                                     IsInitial                               { get; set; }
        public int                                      Count                                   { get; set; }
        public BinaryTypeEnum                           ExpectedType                            { get; set; }
        public string                                   Name                                    { get; set; }
        public InternalObjectTypeE                      ObjectTypeEnum                          { get; set; }
        public InternalMemberTypeE                      MemberTypeEnum                          { get; set; }
        public InternalMemberValueE                     MemberValueEnum                         { get; set; }
        public Type?                                    DtType                                  { get; set; }
        public int                                      NumItems                                { get; set; }
        public BinaryTypeEnum                           BinaryTypeEnum                          { get; set; }
        public int                                      NullCount                               { get; set; }
        public int                                      MemberLength                            { get; set; }
        public List<BinaryTypeEnum>?                    BinaryTypeEnumA                         { get; set; }
        public List<string>?                            MemberNames                             { get; set; }
        public List<Type>?                              MemberTypes                             { get; set; }
        public ParseRecord?                             Pr                                      { get; set; }

        public static ObjectProgress? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjectProgress();

            value.IsInitial                                 = GetBool(new IntPtr(p + 0x010)); // 0270D6C349D0 0x10 IsInitial                   ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.Count                                     = GetInt32(new IntPtr(p + 0x014)); // 0270D6C349F0 0x14 Count                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.ExpectedType                              = (BinaryTypeEnum)GetInt32(new IntPtr(p + 0x018)); // 0270D6C34A10 0x18 ExpectedType                ( 000186592980 ModelEnumType BinaryTypeEnum BinaryTypeEnum BinaryTypeEnum Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0270D6C34A50 0x28 Name                        ( 000186671BA0 ModelPrimitiveType string string string String )
            value.ObjectTypeEnum                            = (InternalObjectTypeE)GetInt32(new IntPtr(p + 0x030)); // 0270D6C34A70 0x30 ObjectTypeEnum              ( 00018671D830 ModelEnumType InternalObjectTypeE InternalObjectTypeE InternalObjectTypeE Int32 )
            value.MemberTypeEnum                            = (InternalMemberTypeE)GetInt32(new IntPtr(p + 0x034)); // 0270D6C34A90 0x34 MemberTypeEnum              ( 00018671C000 ModelEnumType InternalMemberTypeE InternalMemberTypeE InternalMemberTypeE Int32 )
            value.MemberValueEnum                           = (InternalMemberValueE)GetInt32(new IntPtr(p + 0x038)); // 0270D6C34AB0 0x38 MemberValueEnum             ( 00018671C760 ModelEnumType InternalMemberValueE InternalMemberValueE InternalMemberValueE Int32 )
            value.DtType                                    = GetObject<Type>(new IntPtr(p + 0x040), ReversePrism.DataModels.Type.FromPointer); // 0270D6C34AD0 0x40 DtType                      ( 000186692A80 ModelClassType Type Type Type Pointer )
            value.NumItems                                  = GetInt32(new IntPtr(p + 0x048)); // 0270D6C34AF0 0x48 NumItems                    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.BinaryTypeEnum                            = (BinaryTypeEnum)GetInt32(new IntPtr(p + 0x04C)); // 0270D6C34B10 0x4C BinaryTypeEnum              ( 000186592980 ModelEnumType BinaryTypeEnum BinaryTypeEnum BinaryTypeEnum Int32 )
            value.NullCount                                 = GetInt32(new IntPtr(p + 0x058)); // 0270D6C34B50 0x58 NullCount                   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.MemberLength                              = GetInt32(new IntPtr(p + 0x05C)); // 0270D6C34B70 0x5C MemberLength                ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.BinaryTypeEnumA                           = GetEnumList<BinaryTypeEnum>(new IntPtr(p + 0x060)); // 0270D6C34B90 0x60 BinaryTypeEnumA             ( 000185B71C30 ModelEnumListType BinaryTypeEnum[] BinaryTypeEnum[] List<BinaryTypeEnum> Pointer )
            value.MemberNames                               = GetStringList(new IntPtr(p + 0x070)); // 0270D6C34BD0 0x70 MemberNames                 ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.MemberTypes                               = GetObjectList<Type>(new IntPtr(p + 0x078), ReversePrism.DataModels.Type.FromPointer); // 0270D6C34BF0 0x78 MemberTypes                 ( 000185B82D40 ModelClassListType Type[] Type[] List<Type> Pointer )
            value.Pr                                        = GetObject<ParseRecord>(new IntPtr(p + 0x080), ReversePrism.DataModels.ParseRecord.FromPointer); // 0270D6C34C10 0x80 Pr                          ( 000186720840 ModelClassType ParseRecord ParseRecord ParseRecord Pointer )

            return value;
        }
    }
}
