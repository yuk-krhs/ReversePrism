using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SetMvOriginalMemberArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSongIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstSongId                                ModelPrimitiveType int int int Int32
    // 000 IdolListFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _repeated_idolList_codec                 FieldCodec`1<MvIdolStatus> IL2CPP_TYPE_GENERICINST
    // 020 IdolList                                 ModelClassListType RepeatedField`1<MvIdolStatus> RepeatedField`1<MvIdolStatus> List<MvIdolStatus> Pointer
    public partial class SetMvOriginalMemberArgs : DataModel
    {
        public int                                      MstSongId                               { get; set; }
        public List<MvIdolStatus>?                      IdolList                                { get; set; }

        public static SetMvOriginalMemberArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetMvOriginalMemberArgs() { Pointer= p0 };

            value.MstSongId                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstSongId                   ( ModelPrimitiveType int int int Int32 )
            value.IdolList                                  = GetObjectList<MvIdolStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.MvIdolStatus.FromPointer); // 0x20 IdolList                    ( ModelClassListType RepeatedField`1<MvIdolStatus> RepeatedField`1<MvIdolStatus> List<MvIdolStatus> Pointer )

            return value;
        }
    }
}
