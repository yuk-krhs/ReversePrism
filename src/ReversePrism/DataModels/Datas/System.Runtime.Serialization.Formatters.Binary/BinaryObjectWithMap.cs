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
    // 030 AssemId                                  0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class BinaryObjectWithMap
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
            var value   = new BinaryObjectWithMap();

            value.BinaryHeaderEnum                          = (BinaryHeaderEnum)GetInt32(new IntPtr(p + 0x010)); // 0270D6C32398 0x10 BinaryHeaderEnum            ( 000186758300 ModelEnumType BinaryHeaderEnum BinaryHeaderEnum BinaryHeaderEnum Int32 )
            value.ObjectId                                  = GetInt32(new IntPtr(p + 0x014)); // 0270D6C323B8 0x14 ObjectId                    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0270D6C323D8 0x18 Name                        ( 000186671BA0 ModelPrimitiveType string string string String )
            value.NumMembers                                = GetInt32(new IntPtr(p + 0x020)); // 0270D6C323F8 0x20 NumMembers                  ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.MemberNames                               = GetStringList(new IntPtr(p + 0x028)); // 0270D6C32418 0x28 MemberNames                 ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.AssemId                                   = GetInt32(new IntPtr(p + 0x030)); // 0270D6C32438 0x30 AssemId                     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
