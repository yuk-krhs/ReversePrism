using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parseRecordIdCount                       int IL2CPP_TYPE_I4
    // 010 PRparseTypeEnum                          00018671DFD0 ModelEnumType InternalParseTypeE InternalParseTypeE InternalParseTypeE Int32
    // 014 PRobjectTypeEnum                         00018671D830 ModelEnumType InternalObjectTypeE InternalObjectTypeE InternalObjectTypeE Int32
    // 018 PRarrayTypeEnum                          000186719B60 ModelEnumType InternalArrayTypeE InternalArrayTypeE InternalArrayTypeE Int32
    // 01C PRmemberTypeEnum                         00018671C000 ModelEnumType InternalMemberTypeE InternalMemberTypeE InternalMemberTypeE Int32
    // 020 PRmemberValueEnum                        00018671C760 ModelEnumType InternalMemberValueE InternalMemberValueE InternalMemberValueE Int32
    // 024 PRobjectPositionEnum                     00018671D0E0 ModelEnumType InternalObjectPositionE InternalObjectPositionE InternalObjectPositionE Int32
    // 028 PRname                                   000186671BA0 ModelPrimitiveType string string string String
    // 030 PRvalue                                  000186671BA0 ModelPrimitiveType string string string String
    // 038 PRvarValue                               <object> IL2CPP_TYPE_OBJECT
    // 040 PRkeyDt                                  000186671BA0 ModelPrimitiveType string string string String
    // 048 PRdtType                                 000186692A80 ModelClassType Type Type Type Pointer
    // 050 PRdtTypeCode                             0001865FCE10 ModelEnumType InternalPrimitiveTypeE InternalPrimitiveTypeE InternalPrimitiveTypeE Int32
    // 054 PRisEnum                                 000186595210 ModelPrimitiveType bool bool bool Bool
    // 058 PRobjectId                               0001865F79C0 ModelPrimitiveType long long long Int64
    // 060 PRidRef                                  0001865F79C0 ModelPrimitiveType long long long Int64
    // 068 PRarrayElementTypeString                 000186671BA0 ModelPrimitiveType string string string String
    // 070 PRarrayElementType                       000186692A80 ModelClassType Type Type Type Pointer
    // 078 PRisArrayVariant                         000186595210 ModelPrimitiveType bool bool bool Bool
    // 07C PRarrayElementTypeCode                   0001865FCE10 ModelEnumType InternalPrimitiveTypeE InternalPrimitiveTypeE InternalPrimitiveTypeE Int32
    // 080 PRrank                                   0001865F2F90 ModelPrimitiveType int int int Int32
    // 088 PRlengthA                                000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 090 PRpositionA                              000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 098 PRlowerBoundA                            000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 0A0 PRupperBoundA                            000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 0A8 PRindexMap                               000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 0B0 PRmemberIndex                            0001865F2F90 ModelPrimitiveType int int int Int32
    // 0B4 PRlinearlength                           0001865F2F90 ModelPrimitiveType int int int Int32
    // 0B8 PRrectangularMap                         000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 0C0 PRisLowerBound                           000186595210 ModelPrimitiveType bool bool bool Bool
    // 0C8 PRtopId                                  0001865F79C0 ModelPrimitiveType long long long Int64
    // 0D0 PRheaderId                               0001865F79C0 ModelPrimitiveType long long long Int64
    // 0D8 PRobjectInfo                             0001866181E0 ModelClassType ReadObjectInfo ReadObjectInfo ReadObjectInfo Pointer
    // 0E0 PRisValueTypeFixup                       000186595210 ModelPrimitiveType bool bool bool Bool
    // 0E8 PRnewObj                                 <object> IL2CPP_TYPE_OBJECT
    // 0F0 PRobjectA                                <object>[] IL2CPP_TYPE_SZARRAY
    // 0F8 PRprimitiveArray                         0001865135A0 ModelClassType PrimitiveArray PrimitiveArray PrimitiveArray Pointer
    // 100 PRisRegistered                           000186595210 ModelPrimitiveType bool bool bool Bool
    // 108 PRmemberData                             <object>[] IL2CPP_TYPE_SZARRAY
    // 110 PRsi                                     000186663980 ModelClassType SerializationInfo SerializationInfo SerializationInfo Pointer
    // 118 PRnullCount                              0001865F2F90 ModelPrimitiveType int int int Int32
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

            value.PRparseTypeEnum                           = (InternalParseTypeE)GetInt32(new IntPtr(p + 0x010)); // 024666CA4D70 0x10 PRparseTypeEnum             ( 00018671DFD0 ModelEnumType InternalParseTypeE InternalParseTypeE InternalParseTypeE Int32 )
            value.PRobjectTypeEnum                          = (InternalObjectTypeE)GetInt32(new IntPtr(p + 0x014)); // 024666CA4D90 0x14 PRobjectTypeEnum            ( 00018671D830 ModelEnumType InternalObjectTypeE InternalObjectTypeE InternalObjectTypeE Int32 )
            value.PRarrayTypeEnum                           = (InternalArrayTypeE)GetInt32(new IntPtr(p + 0x018)); // 024666CA4DB0 0x18 PRarrayTypeEnum             ( 000186719B60 ModelEnumType InternalArrayTypeE InternalArrayTypeE InternalArrayTypeE Int32 )
            value.PRmemberTypeEnum                          = (InternalMemberTypeE)GetInt32(new IntPtr(p + 0x01C)); // 024666CA4DD0 0x1C PRmemberTypeEnum            ( 00018671C000 ModelEnumType InternalMemberTypeE InternalMemberTypeE InternalMemberTypeE Int32 )
            value.PRmemberValueEnum                         = (InternalMemberValueE)GetInt32(new IntPtr(p + 0x020)); // 024666CA4DF0 0x20 PRmemberValueEnum           ( 00018671C760 ModelEnumType InternalMemberValueE InternalMemberValueE InternalMemberValueE Int32 )
            value.PRobjectPositionEnum                      = (InternalObjectPositionE)GetInt32(new IntPtr(p + 0x024)); // 024666CA4E10 0x24 PRobjectPositionEnum        ( 00018671D0E0 ModelEnumType InternalObjectPositionE InternalObjectPositionE InternalObjectPositionE Int32 )
            value.PRname                                    = GetString(new IntPtr(p + 0x028)); // 024666CA4E30 0x28 PRname                      ( 000186671BA0 ModelPrimitiveType string string string String )
            value.PRvalue                                   = GetString(new IntPtr(p + 0x030)); // 024666CA4E50 0x30 PRvalue                     ( 000186671BA0 ModelPrimitiveType string string string String )
            value.PRkeyDt                                   = GetString(new IntPtr(p + 0x040)); // 024666CA4E90 0x40 PRkeyDt                     ( 000186671BA0 ModelPrimitiveType string string string String )
            value.PRdtType                                  = GetObject<Type>(new IntPtr(p + 0x048), ReversePrism.DataModels.Type.FromPointer); // 024666CA4EB0 0x48 PRdtType                    ( 000186692A80 ModelClassType Type Type Type Pointer )
            value.PRdtTypeCode                              = (InternalPrimitiveTypeE)GetInt32(new IntPtr(p + 0x050)); // 024666CA4ED0 0x50 PRdtTypeCode                ( 0001865FCE10 ModelEnumType InternalPrimitiveTypeE InternalPrimitiveTypeE InternalPrimitiveTypeE Int32 )
            value.PRisEnum                                  = GetBool(new IntPtr(p + 0x054)); // 024666CA4EF0 0x54 PRisEnum                    ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.PRobjectId                                = GetInt64(new IntPtr(p + 0x058)); // 024666CA4F10 0x58 PRobjectId                  ( 0001865F79C0 ModelPrimitiveType long long long Int64 )
            value.PRidRef                                   = GetInt64(new IntPtr(p + 0x060)); // 024666CA4F30 0x60 PRidRef                     ( 0001865F79C0 ModelPrimitiveType long long long Int64 )
            value.PRarrayElementTypeString                  = GetString(new IntPtr(p + 0x068)); // 024666CA4F50 0x68 PRarrayElementTypeString    ( 000186671BA0 ModelPrimitiveType string string string String )
            value.PRarrayElementType                        = GetObject<Type>(new IntPtr(p + 0x070), ReversePrism.DataModels.Type.FromPointer); // 024666CA4F70 0x70 PRarrayElementType          ( 000186692A80 ModelClassType Type Type Type Pointer )
            value.PRisArrayVariant                          = GetBool(new IntPtr(p + 0x078)); // 024666CA4F90 0x78 PRisArrayVariant            ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.PRarrayElementTypeCode                    = (InternalPrimitiveTypeE)GetInt32(new IntPtr(p + 0x07C)); // 024666CA4FB0 0x7C PRarrayElementTypeCode      ( 0001865FCE10 ModelEnumType InternalPrimitiveTypeE InternalPrimitiveTypeE InternalPrimitiveTypeE Int32 )
            value.PRrank                                    = GetInt32(new IntPtr(p + 0x080)); // 024666CA4FD0 0x80 PRrank                      ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.PRlengthA                                 = GetInt32List(new IntPtr(p + 0x088)); // 024666CA4FF0 0x88 PRlengthA                   ( 000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.PRpositionA                               = GetInt32List(new IntPtr(p + 0x090)); // 024666CA5010 0x90 PRpositionA                 ( 000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.PRlowerBoundA                             = GetInt32List(new IntPtr(p + 0x098)); // 024666CA5030 0x98 PRlowerBoundA               ( 000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.PRupperBoundA                             = GetInt32List(new IntPtr(p + 0x0A0)); // 024666CA5050 0xA0 PRupperBoundA               ( 000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.PRindexMap                                = GetInt32List(new IntPtr(p + 0x0A8)); // 024666CA5070 0xA8 PRindexMap                  ( 000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.PRmemberIndex                             = GetInt32(new IntPtr(p + 0x0B0)); // 024666CA5090 0xB0 PRmemberIndex               ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.PRlinearlength                            = GetInt32(new IntPtr(p + 0x0B4)); // 024666CA50B0 0xB4 PRlinearlength              ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.PRrectangularMap                          = GetInt32List(new IntPtr(p + 0x0B8)); // 024666CA50D0 0xB8 PRrectangularMap            ( 000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.PRisLowerBound                            = GetBool(new IntPtr(p + 0x0C0)); // 024666CA50F0 0xC0 PRisLowerBound              ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.PRtopId                                   = GetInt64(new IntPtr(p + 0x0C8)); // 024666CA5110 0xC8 PRtopId                     ( 0001865F79C0 ModelPrimitiveType long long long Int64 )
            value.PRheaderId                                = GetInt64(new IntPtr(p + 0x0D0)); // 024666CA5130 0xD0 PRheaderId                  ( 0001865F79C0 ModelPrimitiveType long long long Int64 )
            value.PRobjectInfo                              = GetObject<ReadObjectInfo>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.ReadObjectInfo.FromPointer); // 024666CA5150 0xD8 PRobjectInfo                ( 0001866181E0 ModelClassType ReadObjectInfo ReadObjectInfo ReadObjectInfo Pointer )
            value.PRisValueTypeFixup                        = GetBool(new IntPtr(p + 0x0E0)); // 024666CA5170 0xE0 PRisValueTypeFixup          ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.PRprimitiveArray                          = GetObject<PrimitiveArray>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.PrimitiveArray.FromPointer); // 024666CA51D0 0xF8 PRprimitiveArray            ( 0001865135A0 ModelClassType PrimitiveArray PrimitiveArray PrimitiveArray Pointer )
            value.PRisRegistered                            = GetBool(new IntPtr(p + 0x100)); // 024666CA51F0 0x100 PRisRegistered              ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.PRsi                                      = GetObject<SerializationInfo>(new IntPtr(p + 0x110), ReversePrism.DataModels.SerializationInfo.FromPointer); // 024666CA5230 0x110 PRsi                        ( 000186663980 ModelClassType SerializationInfo SerializationInfo SerializationInfo Pointer )
            value.PRnullCount                               = GetInt32(new IntPtr(p + 0x118)); // 024666CA5250 0x118 PRnullCount                 ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
