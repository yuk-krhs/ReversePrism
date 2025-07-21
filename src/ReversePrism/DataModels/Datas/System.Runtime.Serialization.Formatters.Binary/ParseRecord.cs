using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parseRecordIdCount                       int IL2CPP_TYPE_I4
    // 010 PRparseTypeEnum                          ModelEnumType InternalParseTypeE InternalParseTypeE InternalParseTypeE Int32
    // 014 PRobjectTypeEnum                         ModelEnumType InternalObjectTypeE InternalObjectTypeE InternalObjectTypeE Int32
    // 018 PRarrayTypeEnum                          ModelEnumType InternalArrayTypeE InternalArrayTypeE InternalArrayTypeE Int32
    // 01C PRmemberTypeEnum                         ModelEnumType InternalMemberTypeE InternalMemberTypeE InternalMemberTypeE Int32
    // 020 PRmemberValueEnum                        ModelEnumType InternalMemberValueE InternalMemberValueE InternalMemberValueE Int32
    // 024 PRobjectPositionEnum                     ModelEnumType InternalObjectPositionE InternalObjectPositionE InternalObjectPositionE Int32
    // 028 PRname                                   ModelPrimitiveType string string string String
    // 030 PRvalue                                  ModelPrimitiveType string string string String
    // 038 PRvarValue                               <object> IL2CPP_TYPE_OBJECT
    // 040 PRkeyDt                                  ModelPrimitiveType string string string String
    // 048 PRdtType                                 ModelClassType Type Type Type Pointer
    // 050 PRdtTypeCode                             ModelEnumType InternalPrimitiveTypeE InternalPrimitiveTypeE InternalPrimitiveTypeE Int32
    // 054 PRisEnum                                 ModelPrimitiveType bool bool bool Bool
    // 058 PRobjectId                               ModelPrimitiveType long long long Int64
    // 060 PRidRef                                  ModelPrimitiveType long long long Int64
    // 068 PRarrayElementTypeString                 ModelPrimitiveType string string string String
    // 070 PRarrayElementType                       ModelClassType Type Type Type Pointer
    // 078 PRisArrayVariant                         ModelPrimitiveType bool bool bool Bool
    // 07C PRarrayElementTypeCode                   ModelEnumType InternalPrimitiveTypeE InternalPrimitiveTypeE InternalPrimitiveTypeE Int32
    // 080 PRrank                                   ModelPrimitiveType int int int Int32
    // 088 PRlengthA                                ModelPrimitiveListType int[] int[] List<int> Pointer
    // 090 PRpositionA                              ModelPrimitiveListType int[] int[] List<int> Pointer
    // 098 PRlowerBoundA                            ModelPrimitiveListType int[] int[] List<int> Pointer
    // 0A0 PRupperBoundA                            ModelPrimitiveListType int[] int[] List<int> Pointer
    // 0A8 PRindexMap                               ModelPrimitiveListType int[] int[] List<int> Pointer
    // 0B0 PRmemberIndex                            ModelPrimitiveType int int int Int32
    // 0B4 PRlinearlength                           ModelPrimitiveType int int int Int32
    // 0B8 PRrectangularMap                         ModelPrimitiveListType int[] int[] List<int> Pointer
    // 0C0 PRisLowerBound                           ModelPrimitiveType bool bool bool Bool
    // 0C8 PRtopId                                  ModelPrimitiveType long long long Int64
    // 0D0 PRheaderId                               ModelPrimitiveType long long long Int64
    // 0D8 PRobjectInfo                             ModelClassType ReadObjectInfo ReadObjectInfo ReadObjectInfo Pointer
    // 0E0 PRisValueTypeFixup                       ModelPrimitiveType bool bool bool Bool
    // 0E8 PRnewObj                                 <object> IL2CPP_TYPE_OBJECT
    // 0F0 PRobjectA                                <object>[] IL2CPP_TYPE_SZARRAY
    // 0F8 PRprimitiveArray                         ModelClassType PrimitiveArray PrimitiveArray PrimitiveArray Pointer
    // 100 PRisRegistered                           ModelPrimitiveType bool bool bool Bool
    // 108 PRmemberData                             <object>[] IL2CPP_TYPE_SZARRAY
    // 110 PRsi                                     ModelClassType SerializationInfo SerializationInfo SerializationInfo Pointer
    // 118 PRnullCount                              ModelPrimitiveType int int int Int32
    public partial class ParseRecord : DataModel
    {
        public InternalParseTypeE                       PRparseTypeEnum                         { get; set; }
        public InternalObjectTypeE                      PRobjectTypeEnum                        { get; set; }
        public InternalArrayTypeE                       PRarrayTypeEnum                         { get; set; }
        public InternalMemberTypeE                      PRmemberTypeEnum                        { get; set; }
        public InternalMemberValueE                     PRmemberValueEnum                       { get; set; }
        public InternalObjectPositionE                  PRobjectPositionEnum                    { get; set; }
        public string                                   PRname                                  { get; set; }
        public string                                   PRvalue                                 { get; set; }
        public string                                   PRkeyDt                                 { get; set; }
        public Type?                                    PRdtType                                { get; set; }
        public InternalPrimitiveTypeE                   PRdtTypeCode                            { get; set; }
        public bool                                     PRisEnum                                { get; set; }
        public long                                     PRobjectId                              { get; set; }
        public long                                     PRidRef                                 { get; set; }
        public string                                   PRarrayElementTypeString                { get; set; }
        public Type?                                    PRarrayElementType                      { get; set; }
        public bool                                     PRisArrayVariant                        { get; set; }
        public InternalPrimitiveTypeE                   PRarrayElementTypeCode                  { get; set; }
        public int                                      PRrank                                  { get; set; }
        public List<int>?                               PRlengthA                               { get; set; }
        public List<int>?                               PRpositionA                             { get; set; }
        public List<int>?                               PRlowerBoundA                           { get; set; }
        public List<int>?                               PRupperBoundA                           { get; set; }
        public List<int>?                               PRindexMap                              { get; set; }
        public int                                      PRmemberIndex                           { get; set; }
        public int                                      PRlinearlength                          { get; set; }
        public List<int>?                               PRrectangularMap                        { get; set; }
        public bool                                     PRisLowerBound                          { get; set; }
        public long                                     PRtopId                                 { get; set; }
        public long                                     PRheaderId                              { get; set; }
        public ReadObjectInfo?                          PRobjectInfo                            { get; set; }
        public bool                                     PRisValueTypeFixup                      { get; set; }
        public PrimitiveArray?                          PRprimitiveArray                        { get; set; }
        public bool                                     PRisRegistered                          { get; set; }
        public SerializationInfo?                       PRsi                                    { get; set; }
        public int                                      PRnullCount                             { get; set; }

        public static ParseRecord? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParseRecord() { Pointer= p0 };

            value.PRparseTypeEnum                           = (InternalParseTypeE)GetInt32(new IntPtr(p + 0x010)); // 0x10 PRparseTypeEnum             ( ModelEnumType InternalParseTypeE InternalParseTypeE InternalParseTypeE Int32 )
            value.PRobjectTypeEnum                          = (InternalObjectTypeE)GetInt32(new IntPtr(p + 0x014)); // 0x14 PRobjectTypeEnum            ( ModelEnumType InternalObjectTypeE InternalObjectTypeE InternalObjectTypeE Int32 )
            value.PRarrayTypeEnum                           = (InternalArrayTypeE)GetInt32(new IntPtr(p + 0x018)); // 0x18 PRarrayTypeEnum             ( ModelEnumType InternalArrayTypeE InternalArrayTypeE InternalArrayTypeE Int32 )
            value.PRmemberTypeEnum                          = (InternalMemberTypeE)GetInt32(new IntPtr(p + 0x01C)); // 0x1C PRmemberTypeEnum            ( ModelEnumType InternalMemberTypeE InternalMemberTypeE InternalMemberTypeE Int32 )
            value.PRmemberValueEnum                         = (InternalMemberValueE)GetInt32(new IntPtr(p + 0x020)); // 0x20 PRmemberValueEnum           ( ModelEnumType InternalMemberValueE InternalMemberValueE InternalMemberValueE Int32 )
            value.PRobjectPositionEnum                      = (InternalObjectPositionE)GetInt32(new IntPtr(p + 0x024)); // 0x24 PRobjectPositionEnum        ( ModelEnumType InternalObjectPositionE InternalObjectPositionE InternalObjectPositionE Int32 )
            value.PRname                                    = GetString(new IntPtr(p + 0x028)); // 0x28 PRname                      ( ModelPrimitiveType string string string String )
            value.PRvalue                                   = GetString(new IntPtr(p + 0x030)); // 0x30 PRvalue                     ( ModelPrimitiveType string string string String )
            value.PRkeyDt                                   = GetString(new IntPtr(p + 0x040)); // 0x40 PRkeyDt                     ( ModelPrimitiveType string string string String )
            value.PRdtType                                  = GetObject<Type>(new IntPtr(p + 0x048), ReversePrism.DataModels.Type.FromPointer); // 0x48 PRdtType                    ( ModelClassType Type Type Type Pointer )
            value.PRdtTypeCode                              = (InternalPrimitiveTypeE)GetInt32(new IntPtr(p + 0x050)); // 0x50 PRdtTypeCode                ( ModelEnumType InternalPrimitiveTypeE InternalPrimitiveTypeE InternalPrimitiveTypeE Int32 )
            value.PRisEnum                                  = GetBool(new IntPtr(p + 0x054)); // 0x54 PRisEnum                    ( ModelPrimitiveType bool bool bool Bool )
            value.PRobjectId                                = GetInt64(new IntPtr(p + 0x058)); // 0x58 PRobjectId                  ( ModelPrimitiveType long long long Int64 )
            value.PRidRef                                   = GetInt64(new IntPtr(p + 0x060)); // 0x60 PRidRef                     ( ModelPrimitiveType long long long Int64 )
            value.PRarrayElementTypeString                  = GetString(new IntPtr(p + 0x068)); // 0x68 PRarrayElementTypeString    ( ModelPrimitiveType string string string String )
            value.PRarrayElementType                        = GetObject<Type>(new IntPtr(p + 0x070), ReversePrism.DataModels.Type.FromPointer); // 0x70 PRarrayElementType          ( ModelClassType Type Type Type Pointer )
            value.PRisArrayVariant                          = GetBool(new IntPtr(p + 0x078)); // 0x78 PRisArrayVariant            ( ModelPrimitiveType bool bool bool Bool )
            value.PRarrayElementTypeCode                    = (InternalPrimitiveTypeE)GetInt32(new IntPtr(p + 0x07C)); // 0x7C PRarrayElementTypeCode      ( ModelEnumType InternalPrimitiveTypeE InternalPrimitiveTypeE InternalPrimitiveTypeE Int32 )
            value.PRrank                                    = GetInt32(new IntPtr(p + 0x080)); // 0x80 PRrank                      ( ModelPrimitiveType int int int Int32 )
            value.PRlengthA                                 = GetInt32List(new IntPtr(p + 0x088)); // 0x88 PRlengthA                   ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.PRpositionA                               = GetInt32List(new IntPtr(p + 0x090)); // 0x90 PRpositionA                 ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.PRlowerBoundA                             = GetInt32List(new IntPtr(p + 0x098)); // 0x98 PRlowerBoundA               ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.PRupperBoundA                             = GetInt32List(new IntPtr(p + 0x0A0)); // 0xA0 PRupperBoundA               ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.PRindexMap                                = GetInt32List(new IntPtr(p + 0x0A8)); // 0xA8 PRindexMap                  ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.PRmemberIndex                             = GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 PRmemberIndex               ( ModelPrimitiveType int int int Int32 )
            value.PRlinearlength                            = GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 PRlinearlength              ( ModelPrimitiveType int int int Int32 )
            value.PRrectangularMap                          = GetInt32List(new IntPtr(p + 0x0B8)); // 0xB8 PRrectangularMap            ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.PRisLowerBound                            = GetBool(new IntPtr(p + 0x0C0)); // 0xC0 PRisLowerBound              ( ModelPrimitiveType bool bool bool Bool )
            value.PRtopId                                   = GetInt64(new IntPtr(p + 0x0C8)); // 0xC8 PRtopId                     ( ModelPrimitiveType long long long Int64 )
            value.PRheaderId                                = GetInt64(new IntPtr(p + 0x0D0)); // 0xD0 PRheaderId                  ( ModelPrimitiveType long long long Int64 )
            value.PRobjectInfo                              = GetObject<ReadObjectInfo>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.ReadObjectInfo.FromPointer); // 0xD8 PRobjectInfo                ( ModelClassType ReadObjectInfo ReadObjectInfo ReadObjectInfo Pointer )
            value.PRisValueTypeFixup                        = GetBool(new IntPtr(p + 0x0E0)); // 0xE0 PRisValueTypeFixup          ( ModelPrimitiveType bool bool bool Bool )
            value.PRprimitiveArray                          = GetObject<PrimitiveArray>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.PrimitiveArray.FromPointer); // 0xF8 PRprimitiveArray            ( ModelClassType PrimitiveArray PrimitiveArray PrimitiveArray Pointer )
            value.PRisRegistered                            = GetBool(new IntPtr(p + 0x100)); // 0x100 PRisRegistered              ( ModelPrimitiveType bool bool bool Bool )
            value.PRsi                                      = GetObject<SerializationInfo>(new IntPtr(p + 0x110), ReversePrism.DataModels.SerializationInfo.FromPointer); // 0x110 PRsi                        ( ModelClassType SerializationInfo SerializationInfo SerializationInfo Pointer )
            value.PRnullCount                               = GetInt32(new IntPtr(p + 0x118)); // 0x118 PRnullCount                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
