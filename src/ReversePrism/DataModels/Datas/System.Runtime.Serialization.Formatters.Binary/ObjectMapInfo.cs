using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ObjectId                                 ModelPrimitiveType int int int Int32
    // 014 NumMembers                               ModelPrimitiveType int int int Int32
    // 018 MemberNames                              ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 MemberTypes                              ModelClassListType Type[] Type[] List<Type> Pointer
    public partial class ObjectMapInfo : DataModel
    {
        public int                                      ObjectId                                { get; set; }
        public int                                      NumMembers                              { get; set; }
        public List<string>?                            MemberNames                             { get; set; }
        public List<Type>?                              MemberTypes                             { get; set; }

        public static ObjectMapInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjectMapInfo() { Pointer= p0 };

            value.ObjectId                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 ObjectId                    ( ModelPrimitiveType int int int Int32 )
            value.NumMembers                                = GetInt32(new IntPtr(p + 0x014)); // 0x14 NumMembers                  ( ModelPrimitiveType int int int Int32 )
            value.MemberNames                               = GetStringList(new IntPtr(p + 0x018)); // 0x18 MemberNames                 ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.MemberTypes                               = GetObjectList<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0x20 MemberTypes                 ( ModelClassListType Type[] Type[] List<Type> Pointer )

            return value;
        }
    }
}
