using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BinaryHeaderEnum                         000186758300 ModelEnumType BinaryHeaderEnum BinaryHeaderEnum BinaryHeaderEnum Int32
    // 014 ObjectId                                 0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 Name                                     000186671BA0 ModelPrimitiveType string string string String
    // 020 NumMembers                               0001865F2F90 ModelPrimitiveType int int int Int32
    // 028 MemberNames                              000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 BinaryTypeEnumA                          000185B71C30 ModelEnumListType BinaryTypeEnum[] BinaryTypeEnum[] List<BinaryTypeEnum> Pointer
    // 038 typeInformationA                         <object>[] IL2CPP_TYPE_SZARRAY
    // 040 MemberAssemIds                           000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 048 AssemId                                  0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class BinaryObjectWithMapTyped
    {
        public BinaryHeaderEnum                         BinaryHeaderEnum                        { get; set; }
        public int                                      ObjectId                                { get; set; }
        public string                                   Name                                    { get; set; }
        public int                                      NumMembers                              { get; set; }
        public List<string>?                            MemberNames                             { get; set; }
        public List<BinaryTypeEnum>?                    BinaryTypeEnumA                         { get; set; }
        public List<int>?                               MemberAssemIds                          { get; set; }
        public int                                      AssemId                                 { get; set; }

        public static BinaryObjectWithMapTyped? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BinaryObjectWithMapTyped();

            value.BinaryHeaderEnum                          = (BinaryHeaderEnum)GetInt32(new IntPtr(p + 0x010)); // 0270D6C326D8 0x10 BinaryHeaderEnum            ( 000186758300 ModelEnumType BinaryHeaderEnum BinaryHeaderEnum BinaryHeaderEnum Int32 )
            value.ObjectId                                  = GetInt32(new IntPtr(p + 0x014)); // 0270D6C326F8 0x14 ObjectId                    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0270D6C32718 0x18 Name                        ( 000186671BA0 ModelPrimitiveType string string string String )
            value.NumMembers                                = GetInt32(new IntPtr(p + 0x020)); // 0270D6C32738 0x20 NumMembers                  ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.MemberNames                               = GetStringList(new IntPtr(p + 0x028)); // 0270D6C32758 0x28 MemberNames                 ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.BinaryTypeEnumA                           = GetEnumList<BinaryTypeEnum>(new IntPtr(p + 0x030)); // 0270D6C32778 0x30 BinaryTypeEnumA             ( 000185B71C30 ModelEnumListType BinaryTypeEnum[] BinaryTypeEnum[] List<BinaryTypeEnum> Pointer )
            value.MemberAssemIds                            = GetInt32List(new IntPtr(p + 0x040)); // 0270D6C327B8 0x40 MemberAssemIds              ( 000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.AssemId                                   = GetInt32(new IntPtr(p + 0x048)); // 0270D6C327D8 0x48 AssemId                     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
