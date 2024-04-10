using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EndDate                                  000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<EventIconStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstEventIconIdFieldNumber                int IL2CPP_TYPE_I4
    // 028 MstEventIconId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ImageResourceIdFieldNumber               int IL2CPP_TYPE_I4
    // 030 ImageResourceId                          000186671910 ModelPrimitiveType string string string String
    // 000 TextFieldNumber                          int IL2CPP_TYPE_I4
    // 038 Text                                     000186671910 ModelPrimitiveType string string string String
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 040 _EndDate                                 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class EventIconStatus : DataModel
    {
        public DateTime                                 EndDate                                 { get; set; }
        public int                                      MstEventIconId                          { get; set; }
        public string                                   ImageResourceId                         { get; set; }
        public string                                   Text                                    { get; set; }
        public Timestamp?                               _EndDate                                { get; set; }

        public static EventIconStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventIconStatus() { Pointer= p0 };

            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x010)); // 024660EE26C0 0x10 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstEventIconId                            = GetInt32(new IntPtr(p + 0x028)); // 024660EE2740 0x28 MstEventIconId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ImageResourceId                           = GetString(new IntPtr(p + 0x030)); // 024660EE2780 0x30 ImageResourceId             ( 000186671910 ModelPrimitiveType string string string String )
            value.Text                                      = GetString(new IntPtr(p + 0x038)); // 024660EE27C0 0x38 Text                        ( 000186671910 ModelPrimitiveType string string string String )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x040), ReversePrism.DataModels.Timestamp.FromPointer); // 024660EE2800 0x40 _EndDate                    ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.EndDate                       = ToDateTime(value._EndDate);

            return value;
        }
    }
}
