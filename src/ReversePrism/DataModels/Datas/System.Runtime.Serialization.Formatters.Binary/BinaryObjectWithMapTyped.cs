using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BinaryHeaderEnum                         ModelEnumType BinaryHeaderEnum BinaryHeaderEnum BinaryHeaderEnum Int32
    // 014 ObjectId                                 ModelPrimitiveType int int int Int32
    // 018 Name                                     ModelPrimitiveType string string string String
    // 020 NumMembers                               ModelPrimitiveType int int int Int32
    // 028 MemberNames                              ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 BinaryTypeEnumA                          ModelEnumListType BinaryTypeEnum[] BinaryTypeEnum[] List<BinaryTypeEnum> Pointer
    // 038 typeInformationA                         <object>[] IL2CPP_TYPE_SZARRAY
    // 040 MemberAssemIds                           ModelPrimitiveListType int[] int[] List<int> Pointer
    // 048 AssemId                                  ModelPrimitiveType int int int Int32
    public partial class BinaryObjectWithMapTyped : DataModel
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
            var value   = new BinaryObjectWithMapTyped() { Pointer= p0 };

            value.BinaryHeaderEnum                          = (BinaryHeaderEnum)GetInt32(new IntPtr(p + 0x010)); // 0x10 BinaryHeaderEnum            ( ModelEnumType BinaryHeaderEnum BinaryHeaderEnum BinaryHeaderEnum Int32 )
            value.ObjectId                                  = GetInt32(new IntPtr(p + 0x014)); // 0x14 ObjectId                    ( ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )
            value.NumMembers                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 NumMembers                  ( ModelPrimitiveType int int int Int32 )
            value.MemberNames                               = GetStringList(new IntPtr(p + 0x028)); // 0x28 MemberNames                 ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.BinaryTypeEnumA                           = GetEnumList<BinaryTypeEnum>(new IntPtr(p + 0x030)); // 0x30 BinaryTypeEnumA             ( ModelEnumListType BinaryTypeEnum[] BinaryTypeEnum[] List<BinaryTypeEnum> Pointer )
            value.MemberAssemIds                            = GetInt32List(new IntPtr(p + 0x040)); // 0x40 MemberAssemIds              ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.AssemId                                   = GetInt32(new IntPtr(p + 0x048)); // 0x48 AssemId                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
