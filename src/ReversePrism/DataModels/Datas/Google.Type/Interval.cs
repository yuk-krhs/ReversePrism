using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Interval> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StartTimeFieldNumber                     int IL2CPP_TYPE_I4
    // 018 _StartTime                               000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EndTimeFieldNumber                       int IL2CPP_TYPE_I4
    // 020 _EndTime                                 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class Interval : DataModel
    {
        public Timestamp?                               _StartTime                              { get; set; }
        public Timestamp?                               _EndTime                                { get; set; }

        public static Interval? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Interval() { Pointer= p0 };

            value._StartTime                                = GetObject<Timestamp>(new IntPtr(p + 0x018), ReversePrism.DataModels.Timestamp.FromPointer); // 02466A6FF4F0 0x18 _StartTime                  ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._EndTime                                  = GetObject<Timestamp>(new IntPtr(p + 0x020), ReversePrism.DataModels.Timestamp.FromPointer); // 02466A6FF530 0x20 _EndTime                    ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )

            return value;
        }
    }
}
