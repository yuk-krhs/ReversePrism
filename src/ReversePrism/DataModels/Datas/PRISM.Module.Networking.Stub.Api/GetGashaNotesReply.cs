using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetGashaNotesReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 BodyFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Body                                     ModelPrimitiveType string string string String
    // 000 NotesListFieldNumber                     int IL2CPP_TYPE_I4
    // 008 _repeated_notesList_codec                FieldCodec`1<GashaNotesStatus> IL2CPP_TYPE_GENERICINST
    // 020 NotesList                                ModelClassListType RepeatedField`1<GashaNotesStatus> RepeatedField`1<GashaNotesStatus> List<GashaNotesStatus> Pointer
    public partial class GetGashaNotesReply : DataModel
    {
        public string                                   Body                                    { get; set; }
        public List<GashaNotesStatus>?                  NotesList                               { get; set; }

        public static GetGashaNotesReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetGashaNotesReply() { Pointer= p0 };

            value.Body                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Body                        ( ModelPrimitiveType string string string String )
            value.NotesList                                 = GetObjectList<GashaNotesStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaNotesStatus.FromPointer); // 0x20 NotesList                   ( ModelClassListType RepeatedField`1<GashaNotesStatus> RepeatedField`1<GashaNotesStatus> List<GashaNotesStatus> Pointer )

            return value;
        }
    }
}
