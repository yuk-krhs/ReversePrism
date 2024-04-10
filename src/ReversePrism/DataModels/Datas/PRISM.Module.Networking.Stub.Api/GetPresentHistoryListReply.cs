using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetPresentHistoryListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PresentHistoryFieldNumber                int IL2CPP_TYPE_I4
    // 008 _repeated_presentHistory_codec           FieldCodec`1<PresentHistoryStatus> IL2CPP_TYPE_GENERICINST
    // 018 PresentHistory                           000185CE9A48 ModelClassListType RepeatedField`1<PresentHistoryStatus> RepeatedField`1<PresentHistoryStatus> List<PresentHistoryStatus> Pointer
    // 000 CursorFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Cursor                                   000186671910 ModelPrimitiveType string string string String
    public partial class GetPresentHistoryListReply : DataModel
    {
        public List<PresentHistoryStatus>?              PresentHistory                          { get; set; }
        public string                                   Cursor                                  { get; set; }

        public static GetPresentHistoryListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetPresentHistoryListReply() { Pointer= p0 };

            value.PresentHistory                            = GetObjectList<PresentHistoryStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.PresentHistoryStatus.FromPointer); // 0246623F5418 0x18 PresentHistory              ( 000185CE9A48 ModelClassListType RepeatedField`1<PresentHistoryStatus> RepeatedField`1<PresentHistoryStatus> List<PresentHistoryStatus> Pointer )
            value.Cursor                                    = GetString(new IntPtr(p + 0x020)); // 0246623F5458 0x20 Cursor                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
