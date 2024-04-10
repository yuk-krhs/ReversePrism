using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetProduceAutoPlayProgressReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 BaseInfoFieldNumber                      int IL2CPP_TYPE_I4
    // 018 BaseInfo                                 0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 ProgressedSeasonListFieldNumber          int IL2CPP_TYPE_I4
    // 008 _repeated_progressedSeasonList_codec     FieldCodec`1<ProduceAutoPlayProgressedSeasonStatus> IL2CPP_TYPE_GENERICINST
    // 020 ProgressedSeasonList                     000185CEA878 ModelClassListType RepeatedField`1<ProduceAutoPlayProgressedSeasonStatus> RepeatedField`1<ProduceAutoPlayProgressedSeasonStatus> List<ProduceAutoPlayProgressedSeasonStatus> Pointer
    public partial class GetProduceAutoPlayProgressReply : DataModel
    {
        public ProduceBaseInfoStatus?                   BaseInfo                                { get; set; }
        public List<ProduceAutoPlayProgressedSeasonStatus>? ProgressedSeasonList                    { get; set; }

        public static GetProduceAutoPlayProgressReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetProduceAutoPlayProgressReply() { Pointer= p0 };

            value.BaseInfo                                  = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 024662541FB8 0x18 BaseInfo                    ( 0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.ProgressedSeasonList                      = GetObjectList<ProduceAutoPlayProgressedSeasonStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceAutoPlayProgressedSeasonStatus.FromPointer); // 024662542018 0x20 ProgressedSeasonList        ( 000185CEA878 ModelClassListType RepeatedField`1<ProduceAutoPlayProgressedSeasonStatus> RepeatedField`1<ProduceAutoPlayProgressedSeasonStatus> List<ProduceAutoPlayProgressedSeasonStatus> Pointer )

            return value;
        }
    }
}
