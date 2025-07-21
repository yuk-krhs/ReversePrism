using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BeginDate                                ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<SetLiveEventAllSongBreakTimeArgs> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 028 MstEventId                               ModelPrimitiveType int int int Int32
    // 000 BeginDateFieldNumber                     int IL2CPP_TYPE_I4
    // 030 _BeginDate                               ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class SetLiveEventAllSongBreakTimeArgs : DataModel
    {
        public DateTime                                 BeginDate                               { get; set; }
        public int                                      MstEventId                              { get; set; }
        public Timestamp?                               _BeginDate                              { get; set; }

        public static SetLiveEventAllSongBreakTimeArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetLiveEventAllSongBreakTimeArgs() { Pointer= p0 };

            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x010)); // 0x10 BeginDate                   ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstEventId                                = GetInt32(new IntPtr(p + 0x028)); // 0x28 MstEventId                  ( ModelPrimitiveType int int int Int32 )
            value._BeginDate                                = GetObject<Timestamp>(new IntPtr(p + 0x030), ReversePrism.DataModels.Timestamp.FromPointer); // 0x30 _BeginDate                  ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.BeginDate                     = ToDateTime(value._BeginDate);

            return value;
        }
    }
}
