using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ObjectReader                             ModelClassType ObjectReader ObjectReader ObjectReader Pointer
    // 018 Input                                    ModelClassType Stream Stream Stream Pointer
    // 020 TopId                                    ModelPrimitiveType long long long Int64
    // 028 HeaderId                                 ModelPrimitiveType long long long Int64
    // 030 ObjectMapIdTable                         ModelClassType SizedArray SizedArray SizedArray Pointer
    // 038 AssemIdToAssemblyTable                   ModelClassType SizedArray SizedArray SizedArray Pointer
    // 040 Stack                                    ModelClassType SerStack SerStack SerStack Pointer
    // 048 ExpectedType                             ModelEnumType BinaryTypeEnum BinaryTypeEnum BinaryTypeEnum Int32
    // 050 expectedTypeInformation                  <object> IL2CPP_TYPE_OBJECT
    // 058 PRS                                      ModelClassType ParseRecord ParseRecord ParseRecord Pointer
    // 060 SystemAssemblyInfo                       ModelClassType BinaryAssemblyInfo BinaryAssemblyInfo BinaryAssemblyInfo Pointer
    // 068 DataReader                               ModelClassType BinaryReader BinaryReader BinaryReader Pointer
    // 000 encoding                                 Encoding IL2CPP_TYPE_CLASS
    // 070 OpPool                                   ModelClassType SerStack SerStack SerStack Pointer
    // 078 BinaryObject                             ModelClassType BinaryObject BinaryObject BinaryObject Pointer
    // 080 Bowm                                     ModelClassType BinaryObjectWithMap BinaryObjectWithMap BinaryObjectWithMap Pointer
    // 088 Bowmt                                    ModelClassType BinaryObjectWithMapTyped BinaryObjectWithMapTyped BinaryObjectWithMapTyped Pointer
    // 090 ObjectString                             ModelClassType BinaryObjectString BinaryObjectString BinaryObjectString Pointer
    // 098 CrossAppDomainString                     ModelClassType BinaryCrossAppDomainString BinaryCrossAppDomainString BinaryCrossAppDomainString Pointer
    // 0A0 MemberPrimitiveTyped                     ModelClassType MemberPrimitiveTyped MemberPrimitiveTyped MemberPrimitiveTyped Pointer
    // 0A8 ByteBuffer                               ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 0B0 MemberPrimitiveUnTyped                   ModelClassType MemberPrimitiveUnTyped MemberPrimitiveUnTyped MemberPrimitiveUnTyped Pointer
    // 0B8 MemberReference                          ModelClassType MemberReference MemberReference MemberReference Pointer
    // 0C0 ObjectNull                               ModelClassType ObjectNull ObjectNull ObjectNull Pointer
    // 008 messageEnd                               MessageEnd IL2CPP_TYPE_CLASS
    public partial class __BinaryParser : DataModel
    {
        public ObjectReader?                            ObjectReader                            { get; set; }
        public Stream?                                  Input                                   { get; set; }
        public long                                     TopId                                   { get; set; }
        public long                                     HeaderId                                { get; set; }
        public SizedArray?                              ObjectMapIdTable                        { get; set; }
        public SizedArray?                              AssemIdToAssemblyTable                  { get; set; }
        public SerStack?                                Stack                                   { get; set; }
        public BinaryTypeEnum                           ExpectedType                            { get; set; }
        public ParseRecord?                             PRS                                     { get; set; }
        public BinaryAssemblyInfo?                      SystemAssemblyInfo                      { get; set; }
        public BinaryReader?                            DataReader                              { get; set; }
        public SerStack?                                OpPool                                  { get; set; }
        public BinaryObject?                            BinaryObject                            { get; set; }
        public BinaryObjectWithMap?                     Bowm                                    { get; set; }
        public BinaryObjectWithMapTyped?                Bowmt                                   { get; set; }
        public BinaryObjectString?                      ObjectString                            { get; set; }
        public BinaryCrossAppDomainString?              CrossAppDomainString                    { get; set; }
        public MemberPrimitiveTyped?                    MemberPrimitiveTyped                    { get; set; }
        public List<sbyte>?                             ByteBuffer                              { get; set; }
        public MemberPrimitiveUnTyped?                  MemberPrimitiveUnTyped                  { get; set; }
        public MemberReference?                         MemberReference                         { get; set; }
        public ObjectNull?                              ObjectNull                              { get; set; }

        public static __BinaryParser? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new __BinaryParser() { Pointer= p0 };

            value.ObjectReader                              = GetObject<ObjectReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.ObjectReader.FromPointer); // 0x10 ObjectReader                ( ModelClassType ObjectReader ObjectReader ObjectReader Pointer )
            value.Input                                     = GetObject<Stream>(new IntPtr(p + 0x018), ReversePrism.DataModels.Stream.FromPointer); // 0x18 Input                       ( ModelClassType Stream Stream Stream Pointer )
            value.TopId                                     = GetInt64(new IntPtr(p + 0x020)); // 0x20 TopId                       ( ModelPrimitiveType long long long Int64 )
            value.HeaderId                                  = GetInt64(new IntPtr(p + 0x028)); // 0x28 HeaderId                    ( ModelPrimitiveType long long long Int64 )
            value.ObjectMapIdTable                          = GetObject<SizedArray>(new IntPtr(p + 0x030), ReversePrism.DataModels.SizedArray.FromPointer); // 0x30 ObjectMapIdTable            ( ModelClassType SizedArray SizedArray SizedArray Pointer )
            value.AssemIdToAssemblyTable                    = GetObject<SizedArray>(new IntPtr(p + 0x038), ReversePrism.DataModels.SizedArray.FromPointer); // 0x38 AssemIdToAssemblyTable      ( ModelClassType SizedArray SizedArray SizedArray Pointer )
            value.Stack                                     = GetObject<SerStack>(new IntPtr(p + 0x040), ReversePrism.DataModels.SerStack.FromPointer); // 0x40 Stack                       ( ModelClassType SerStack SerStack SerStack Pointer )
            value.ExpectedType                              = (BinaryTypeEnum)GetInt32(new IntPtr(p + 0x048)); // 0x48 ExpectedType                ( ModelEnumType BinaryTypeEnum BinaryTypeEnum BinaryTypeEnum Int32 )
            value.PRS                                       = GetObject<ParseRecord>(new IntPtr(p + 0x058), ReversePrism.DataModels.ParseRecord.FromPointer); // 0x58 PRS                         ( ModelClassType ParseRecord ParseRecord ParseRecord Pointer )
            value.SystemAssemblyInfo                        = GetObject<BinaryAssemblyInfo>(new IntPtr(p + 0x060), ReversePrism.DataModels.BinaryAssemblyInfo.FromPointer); // 0x60 SystemAssemblyInfo          ( ModelClassType BinaryAssemblyInfo BinaryAssemblyInfo BinaryAssemblyInfo Pointer )
            value.DataReader                                = GetObject<BinaryReader>(new IntPtr(p + 0x068), ReversePrism.DataModels.BinaryReader.FromPointer); // 0x68 DataReader                  ( ModelClassType BinaryReader BinaryReader BinaryReader Pointer )
            value.OpPool                                    = GetObject<SerStack>(new IntPtr(p + 0x070), ReversePrism.DataModels.SerStack.FromPointer); // 0x70 OpPool                      ( ModelClassType SerStack SerStack SerStack Pointer )
            value.BinaryObject                              = GetObject<BinaryObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.BinaryObject.FromPointer); // 0x78 BinaryObject                ( ModelClassType BinaryObject BinaryObject BinaryObject Pointer )
            value.Bowm                                      = GetObject<BinaryObjectWithMap>(new IntPtr(p + 0x080), ReversePrism.DataModels.BinaryObjectWithMap.FromPointer); // 0x80 Bowm                        ( ModelClassType BinaryObjectWithMap BinaryObjectWithMap BinaryObjectWithMap Pointer )
            value.Bowmt                                     = GetObject<BinaryObjectWithMapTyped>(new IntPtr(p + 0x088), ReversePrism.DataModels.BinaryObjectWithMapTyped.FromPointer); // 0x88 Bowmt                       ( ModelClassType BinaryObjectWithMapTyped BinaryObjectWithMapTyped BinaryObjectWithMapTyped Pointer )
            value.ObjectString                              = GetObject<BinaryObjectString>(new IntPtr(p + 0x090), ReversePrism.DataModels.BinaryObjectString.FromPointer); // 0x90 ObjectString                ( ModelClassType BinaryObjectString BinaryObjectString BinaryObjectString Pointer )
            value.CrossAppDomainString                      = GetObject<BinaryCrossAppDomainString>(new IntPtr(p + 0x098), ReversePrism.DataModels.BinaryCrossAppDomainString.FromPointer); // 0x98 CrossAppDomainString        ( ModelClassType BinaryCrossAppDomainString BinaryCrossAppDomainString BinaryCrossAppDomainString Pointer )
            value.MemberPrimitiveTyped                      = GetObject<MemberPrimitiveTyped>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.MemberPrimitiveTyped.FromPointer); // 0xA0 MemberPrimitiveTyped        ( ModelClassType MemberPrimitiveTyped MemberPrimitiveTyped MemberPrimitiveTyped Pointer )
            value.ByteBuffer                                = GetSByteList(new IntPtr(p + 0x0A8)); // 0xA8 ByteBuffer                  ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.MemberPrimitiveUnTyped                    = GetObject<MemberPrimitiveUnTyped>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.MemberPrimitiveUnTyped.FromPointer); // 0xB0 MemberPrimitiveUnTyped      ( ModelClassType MemberPrimitiveUnTyped MemberPrimitiveUnTyped MemberPrimitiveUnTyped Pointer )
            value.MemberReference                           = GetObject<MemberReference>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.MemberReference.FromPointer); // 0xB8 MemberReference             ( ModelClassType MemberReference MemberReference MemberReference Pointer )
            value.ObjectNull                                = GetObject<ObjectNull>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ObjectNull.FromPointer); // 0xC0 ObjectNull                  ( ModelClassType ObjectNull ObjectNull ObjectNull Pointer )

            return value;
        }
    }
}
