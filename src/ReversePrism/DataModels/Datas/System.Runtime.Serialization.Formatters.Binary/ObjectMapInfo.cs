using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ObjectId                                 0001865F2F90 ModelPrimitiveType int int int Int32
    // 014 NumMembers                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 MemberNames                              000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 MemberTypes                              000185B82C10 ModelClassListType Type[] Type[] List<Type> Pointer
    public partial class ObjectMapInfo
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
            var value   = new ObjectMapInfo();

            value.ObjectId                                  = GetInt32(new IntPtr(p + 0x010)); // 0270D6C54198 0x10 ObjectId                    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.NumMembers                                = GetInt32(new IntPtr(p + 0x014)); // 0270D6C541B8 0x14 NumMembers                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MemberNames                               = GetStringList(new IntPtr(p + 0x018)); // 0270D6C541D8 0x18 MemberNames                 ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.MemberTypes                               = GetObjectList<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0270D6C541F8 0x20 MemberTypes                 ( 000185B82C10 ModelClassListType Type[] Type[] List<Type> Pointer )

            return value;
        }
    }
}
