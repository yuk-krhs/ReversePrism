using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SetMvOriginalMemberReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UpdateIdolListFieldNumber                int IL2CPP_TYPE_I4
    // 008 _repeated_updateIdolList_codec           FieldCodec`1<MvIdolStatus> IL2CPP_TYPE_GENERICINST
    // 018 UpdateIdolList                           000185CE77F8 ModelClassListType RepeatedField`1<MvIdolStatus> RepeatedField`1<MvIdolStatus> List<MvIdolStatus> Pointer
    // 000 SongFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Song                                     00018652B0A0 ModelClassType SongStatus SongStatus SongStatus Pointer
    public partial class SetMvOriginalMemberReply : DataModel
    {
        public List<MvIdolStatus>?                      UpdateIdolList                          { get; set; }
        public SongStatus?                              Song                                    { get; set; }

        public static SetMvOriginalMemberReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetMvOriginalMemberReply() { Pointer= p0 };

            value.UpdateIdolList                            = GetObjectList<MvIdolStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.MvIdolStatus.FromPointer); // 0246621A0288 0x18 UpdateIdolList              ( 000185CE77F8 ModelClassListType RepeatedField`1<MvIdolStatus> RepeatedField`1<MvIdolStatus> List<MvIdolStatus> Pointer )
            value.Song                                      = GetObject<SongStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.SongStatus.FromPointer); // 0246621A02C8 0x20 Song                        ( 00018652B0A0 ModelClassType SongStatus SongStatus SongStatus Pointer )

            return value;
        }
    }
}
