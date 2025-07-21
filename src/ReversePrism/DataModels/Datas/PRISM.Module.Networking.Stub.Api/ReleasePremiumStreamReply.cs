using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ReleasePremiumStreamReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstStreamProgramIdFieldNumber            int IL2CPP_TYPE_I4
    // 018 MstStreamProgramId                       ModelPrimitiveType int int int Int32
    // 000 IsPremiumFieldNumber                     int IL2CPP_TYPE_I4
    // 01C IsPremium                                ModelPrimitiveType bool bool bool Bool
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 020 HavingGroup                              ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    public partial class ReleasePremiumStreamReply : DataModel
    {
        public int                                      MstStreamProgramId                      { get; set; }
        public bool                                     IsPremium                               { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }

        public static ReleasePremiumStreamReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReleasePremiumStreamReply() { Pointer= p0 };

            value.MstStreamProgramId                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstStreamProgramId          ( ModelPrimitiveType int int int Int32 )
            value.IsPremium                                 = GetBool(new IntPtr(p + 0x01C)); // 0x1C IsPremium                   ( ModelPrimitiveType bool bool bool Bool )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0x20 HavingGroup                 ( ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )

            return value;
        }
    }
}
