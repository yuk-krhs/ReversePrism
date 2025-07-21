using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BeginDate                                ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 EndDate                                  ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 030 ResultBeginDate                          ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<GameEventStatus> IL2CPP_TYPE_GENERICINST
    // 040 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 048 MstEventId                               ModelPrimitiveType int int int Int32
    // 000 BeginDateFieldNumber                     int IL2CPP_TYPE_I4
    // 050 _BeginDate                               ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 058 _EndDate                                 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 IsProduceFieldNumber                     int IL2CPP_TYPE_I4
    // 060 IsProduce                                ModelPrimitiveType bool bool bool Bool
    // 000 IsLiveFieldNumber                        int IL2CPP_TYPE_I4
    // 061 IsLive                                   ModelPrimitiveType bool bool bool Bool
    // 000 EventStateFieldNumber                    int IL2CPP_TYPE_I4
    // 064 EventState                               ModelEnumType GameEventState GameEventState GameEventState Int32
    // 000 EventTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 068 EventType                                ModelEnumType GameEventType GameEventType GameEventType Int32
    // 000 ResultBeginDateFieldNumber               int IL2CPP_TYPE_I4
    // 070 _ResultBeginDate                         ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class GameEventStatus : DataModel
    {
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public DateTime                                 ResultBeginDate                         { get; set; }
        public int                                      MstEventId                              { get; set; }
        public Timestamp?                               _BeginDate                              { get; set; }
        public Timestamp?                               _EndDate                                { get; set; }
        public bool                                     IsProduce                               { get; set; }
        public bool                                     IsLive                                  { get; set; }
        public GameEventState                           EventState                              { get; set; }
        public GameEventType                            EventType                               { get; set; }
        public Timestamp?                               _ResultBeginDate                        { get; set; }

        public static GameEventStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GameEventStatus() { Pointer= p0 };

            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x010)); // 0x10 BeginDate                   ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x020)); // 0x20 EndDate                     ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ResultBeginDate                           = GetDateTime(new IntPtr(p + 0x030)); // 0x30 ResultBeginDate             ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstEventId                                = GetInt32(new IntPtr(p + 0x048)); // 0x48 MstEventId                  ( ModelPrimitiveType int int int Int32 )
            value._BeginDate                                = GetObject<Timestamp>(new IntPtr(p + 0x050), ReversePrism.DataModels.Timestamp.FromPointer); // 0x50 _BeginDate                  ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x058), ReversePrism.DataModels.Timestamp.FromPointer); // 0x58 _EndDate                    ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.IsProduce                                 = GetBool(new IntPtr(p + 0x060)); // 0x60 IsProduce                   ( ModelPrimitiveType bool bool bool Bool )
            value.IsLive                                    = GetBool(new IntPtr(p + 0x061)); // 0x61 IsLive                      ( ModelPrimitiveType bool bool bool Bool )
            value.EventState                                = (GameEventState)GetInt32(new IntPtr(p + 0x064)); // 0x64 EventState                  ( ModelEnumType GameEventState GameEventState GameEventState Int32 )
            value.EventType                                 = (GameEventType)GetInt32(new IntPtr(p + 0x068)); // 0x68 EventType                   ( ModelEnumType GameEventType GameEventType GameEventType Int32 )
            value._ResultBeginDate                          = GetObject<Timestamp>(new IntPtr(p + 0x070), ReversePrism.DataModels.Timestamp.FromPointer); // 0x70 _ResultBeginDate            ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.BeginDate                     = ToDateTime(value._BeginDate);
            value.EndDate                       = ToDateTime(value._EndDate);
            value.ResultBeginDate               = ToDateTime(value._ResultBeginDate);

            return value;
        }
    }
}
