using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<RecordTimeReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RecordTimeFieldNumber                    int IL2CPP_TYPE_I4
    // 018 RecordTime                               ModelClassType RecordTimeStatus RecordTimeStatus RecordTimeStatus Pointer
    public partial class RecordTimeReply : DataModel
    {
        public RecordTimeStatus?                        RecordTime                              { get; set; }

        public static RecordTimeReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RecordTimeReply() { Pointer= p0 };

            value.RecordTime                                = GetObject<RecordTimeStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.RecordTimeStatus.FromPointer); // 0x18 RecordTime                  ( ModelClassType RecordTimeStatus RecordTimeStatus RecordTimeStatus Pointer )

            return value;
        }
    }
}
