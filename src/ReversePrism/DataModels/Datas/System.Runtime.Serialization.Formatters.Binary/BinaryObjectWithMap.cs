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
    // 030 AssemId                                  ModelPrimitiveType int int int Int32
    public partial class BinaryObjectWithMap : DataModel
    {
        public BinaryHeaderEnum                         BinaryHeaderEnum                        { get; set; }
        public int                                      ObjectId                                { get; set; }
        public string                                   Name                                    { get; set; }
        public int                                      NumMembers                              { get; set; }
        public List<string>?                            MemberNames                             { get; set; }
        public int                                      AssemId                                 { get; set; }

        public static BinaryObjectWithMap? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BinaryObjectWithMap() { Pointer= p0 };

            value.BinaryHeaderEnum                          = (BinaryHeaderEnum)GetInt32(new IntPtr(p + 0x010)); // 0x10 BinaryHeaderEnum            ( ModelEnumType BinaryHeaderEnum BinaryHeaderEnum BinaryHeaderEnum Int32 )
            value.ObjectId                                  = GetInt32(new IntPtr(p + 0x014)); // 0x14 ObjectId                    ( ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )
            value.NumMembers                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 NumMembers                  ( ModelPrimitiveType int int int Int32 )
            value.MemberNames                               = GetStringList(new IntPtr(p + 0x028)); // 0x28 MemberNames                 ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.AssemId                                   = GetInt32(new IntPtr(p + 0x030)); // 0x30 AssemId                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
