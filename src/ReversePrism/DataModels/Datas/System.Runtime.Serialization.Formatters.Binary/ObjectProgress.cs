using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 opRecordIdCount                          int IL2CPP_TYPE_I4
    // 010 IsInitial                                ModelPrimitiveType bool bool bool Bool
    // 014 Count                                    ModelPrimitiveType int int int Int32
    // 018 ExpectedType                             ModelEnumType BinaryTypeEnum BinaryTypeEnum BinaryTypeEnum Int32
    // 020 expectedTypeInformation                  <object> IL2CPP_TYPE_OBJECT
    // 028 Name                                     ModelPrimitiveType string string string String
    // 030 ObjectTypeEnum                           ModelEnumType InternalObjectTypeE InternalObjectTypeE InternalObjectTypeE Int32
    // 034 MemberTypeEnum                           ModelEnumType InternalMemberTypeE InternalMemberTypeE InternalMemberTypeE Int32
    // 038 MemberValueEnum                          ModelEnumType InternalMemberValueE InternalMemberValueE InternalMemberValueE Int32
    // 040 DtType                                   ModelClassType Type Type Type Pointer
    // 048 NumItems                                 ModelPrimitiveType int int int Int32
    // 04C BinaryTypeEnum                           ModelEnumType BinaryTypeEnum BinaryTypeEnum BinaryTypeEnum Int32
    // 050 typeInformation                          <object> IL2CPP_TYPE_OBJECT
    // 058 NullCount                                ModelPrimitiveType int int int Int32
    // 05C MemberLength                             ModelPrimitiveType int int int Int32
    // 060 BinaryTypeEnumA                          ModelEnumListType BinaryTypeEnum[] BinaryTypeEnum[] List<BinaryTypeEnum> Pointer
    // 068 typeInformationA                         <object>[] IL2CPP_TYPE_SZARRAY
    // 070 MemberNames                              ModelPrimitiveListType string[] string[] List<string> Pointer
    // 078 MemberTypes                              ModelClassListType Type[] Type[] List<Type> Pointer
    // 080 Pr                                       ModelClassType ParseRecord ParseRecord ParseRecord Pointer
    public partial class ObjectProgress : DataModel
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
            var value   = new ObjectProgress() { Pointer= p0 };

            value.IsInitial                                 = GetBool(new IntPtr(p + 0x010)); // 0x10 IsInitial                   ( ModelPrimitiveType bool bool bool Bool )
            value.Count                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 Count                       ( ModelPrimitiveType int int int Int32 )
            value.ExpectedType                              = (BinaryTypeEnum)GetInt32(new IntPtr(p + 0x018)); // 0x18 ExpectedType                ( ModelEnumType BinaryTypeEnum BinaryTypeEnum BinaryTypeEnum Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0x28 Name                        ( ModelPrimitiveType string string string String )
            value.ObjectTypeEnum                            = (InternalObjectTypeE)GetInt32(new IntPtr(p + 0x030)); // 0x30 ObjectTypeEnum              ( ModelEnumType InternalObjectTypeE InternalObjectTypeE InternalObjectTypeE Int32 )
            value.MemberTypeEnum                            = (InternalMemberTypeE)GetInt32(new IntPtr(p + 0x034)); // 0x34 MemberTypeEnum              ( ModelEnumType InternalMemberTypeE InternalMemberTypeE InternalMemberTypeE Int32 )
            value.MemberValueEnum                           = (InternalMemberValueE)GetInt32(new IntPtr(p + 0x038)); // 0x38 MemberValueEnum             ( ModelEnumType InternalMemberValueE InternalMemberValueE InternalMemberValueE Int32 )
            value.DtType                                    = GetObject<Type>(new IntPtr(p + 0x040), ReversePrism.DataModels.Type.FromPointer); // 0x40 DtType                      ( ModelClassType Type Type Type Pointer )
            value.NumItems                                  = GetInt32(new IntPtr(p + 0x048)); // 0x48 NumItems                    ( ModelPrimitiveType int int int Int32 )
            value.BinaryTypeEnum                            = (BinaryTypeEnum)GetInt32(new IntPtr(p + 0x04C)); // 0x4C BinaryTypeEnum              ( ModelEnumType BinaryTypeEnum BinaryTypeEnum BinaryTypeEnum Int32 )
            value.NullCount                                 = GetInt32(new IntPtr(p + 0x058)); // 0x58 NullCount                   ( ModelPrimitiveType int int int Int32 )
            value.MemberLength                              = GetInt32(new IntPtr(p + 0x05C)); // 0x5C MemberLength                ( ModelPrimitiveType int int int Int32 )
            value.BinaryTypeEnumA                           = GetEnumList<BinaryTypeEnum>(new IntPtr(p + 0x060)); // 0x60 BinaryTypeEnumA             ( ModelEnumListType BinaryTypeEnum[] BinaryTypeEnum[] List<BinaryTypeEnum> Pointer )
            value.MemberNames                               = GetStringList(new IntPtr(p + 0x070)); // 0x70 MemberNames                 ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.MemberTypes                               = GetObjectList<Type>(new IntPtr(p + 0x078), ReversePrism.DataModels.Type.FromPointer); // 0x78 MemberTypes                 ( ModelClassListType Type[] Type[] List<Type> Pointer )
            value.Pr                                        = GetObject<ParseRecord>(new IntPtr(p + 0x080), ReversePrism.DataModels.ParseRecord.FromPointer); // 0x80 Pr                          ( ModelClassType ParseRecord ParseRecord ParseRecord Pointer )

            return value;
        }
    }
}
