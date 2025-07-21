using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LastDisplayDate                          ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<SeasonMissionTabStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ReceivableCountFieldNumber               int IL2CPP_TYPE_I4
    // 028 ReceivableCount                          ModelPrimitiveType int int int Int32
    // 000 IsNewFieldNumber                         int IL2CPP_TYPE_I4
    // 02C IsNew                                    ModelPrimitiveType bool bool bool Bool
    // 000 LastDisplayDateFieldNumber               int IL2CPP_TYPE_I4
    // 030 _LastDisplayDate                         ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class SeasonMissionTabStatus : DataModel
    {
        public DateTime                                 LastDisplayDate                         { get; set; }
        public int                                      ReceivableCount                         { get; set; }
        public bool                                     IsNew                                   { get; set; }
        public Timestamp?                               _LastDisplayDate                        { get; set; }

        public static SeasonMissionTabStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionTabStatus() { Pointer= p0 };

            value.LastDisplayDate                           = GetDateTime(new IntPtr(p + 0x010)); // 0x10 LastDisplayDate             ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ReceivableCount                           = GetInt32(new IntPtr(p + 0x028)); // 0x28 ReceivableCount             ( ModelPrimitiveType int int int Int32 )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x02C)); // 0x2C IsNew                       ( ModelPrimitiveType bool bool bool Bool )
            value._LastDisplayDate                          = GetObject<Timestamp>(new IntPtr(p + 0x030), ReversePrism.DataModels.Timestamp.FromPointer); // 0x30 _LastDisplayDate            ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.LastDisplayDate               = ToDateTime(value._LastDisplayDate);

            return value;
        }
    }
}
