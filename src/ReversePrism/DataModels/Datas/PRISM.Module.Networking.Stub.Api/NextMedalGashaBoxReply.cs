using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<NextMedalGashaBoxReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MedalGashaStatusFieldNumber              int IL2CPP_TYPE_I4
    // 018 MedalGashaStatus                         0001865EEDD0 ModelClassType MedalGashaStatus MedalGashaStatus MedalGashaStatus Pointer
    // 000 BoxListFieldNumber                       int IL2CPP_TYPE_I4
    // 008 _repeated_boxList_codec                  FieldCodec`1<MedalGashaBoxStatus> IL2CPP_TYPE_GENERICINST
    // 020 BoxList                                  000185CE5988 ModelClassListType RepeatedField`1<MedalGashaBoxStatus> RepeatedField`1<MedalGashaBoxStatus> List<MedalGashaBoxStatus> Pointer
    public partial class NextMedalGashaBoxReply
    {
        public MedalGashaStatus?                        MedalGashaStatus                        { get; set; }
        public List<MedalGashaBoxStatus>?               BoxList                                 { get; set; }

        public static NextMedalGashaBoxReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NextMedalGashaBoxReply();

            value.MedalGashaStatus                          = GetObject<MedalGashaStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.MedalGashaStatus.FromPointer); // 0270D228B8F8 0x18 MedalGashaStatus            ( 0001865EEDD0 ModelClassType MedalGashaStatus MedalGashaStatus MedalGashaStatus Pointer )
            value.BoxList                                   = GetObjectList<MedalGashaBoxStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.MedalGashaBoxStatus.FromPointer); // 0270D228B958 0x20 BoxList                     ( 000185CE5988 ModelClassListType RepeatedField`1<MedalGashaBoxStatus> RepeatedField`1<MedalGashaBoxStatus> List<MedalGashaBoxStatus> Pointer )

            return value;
        }
    }
}
