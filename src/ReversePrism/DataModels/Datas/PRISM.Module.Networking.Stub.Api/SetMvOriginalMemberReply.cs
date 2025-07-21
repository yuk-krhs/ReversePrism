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
    // 000 SongFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Song                                     ModelClassType SongStatus SongStatus SongStatus Pointer
    public partial class SetMvOriginalMemberReply : DataModel
    {
        public SongStatus?                              Song                                    { get; set; }

        public static SetMvOriginalMemberReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetMvOriginalMemberReply() { Pointer= p0 };

            value.Song                                      = GetObject<SongStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.SongStatus.FromPointer); // 0x18 Song                        ( ModelClassType SongStatus SongStatus SongStatus Pointer )

            return value;
        }
    }
}
