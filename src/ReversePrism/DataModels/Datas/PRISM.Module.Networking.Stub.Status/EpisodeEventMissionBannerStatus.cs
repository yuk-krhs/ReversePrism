using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BeginDate                                000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 EndDate                                  000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<EpisodeEventMissionBannerStatus> IL2CPP_TYPE_GENERICINST
    // 030 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 038 MstUnitId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstMissionGroupIdFieldNumber             int IL2CPP_TYPE_I4
    // 03C MstMissionGroupId                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 BeginDateFieldNumber                     int IL2CPP_TYPE_I4
    // 040 _BeginDate                               000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 048 _EndDate                                 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 050 MstEventId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstEpisodeEventMissionBannerIdFieldNumber int IL2CPP_TYPE_I4
    // 054 MstEpisodeEventMissionBannerId           0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class EpisodeEventMissionBannerStatus
    {
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public int                                      MstMissionGroupId                       { get; set; }
        public Timestamp?                               _BeginDate                              { get; set; }
        public Timestamp?                               _EndDate                                { get; set; }
        public int                                      MstEventId                              { get; set; }
        public int                                      MstEpisodeEventMissionBannerId          { get; set; }

        public static EpisodeEventMissionBannerStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EpisodeEventMissionBannerStatus();

            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x010)); // 0270D10B72E8 0x10 BeginDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x020)); // 0270D10B7308 0x20 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x038)); // 0270D10B7388 0x38 MstUnitId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstMissionGroupId                         = GetInt32(new IntPtr(p + 0x03C)); // 0270D10B73C8 0x3C MstMissionGroupId           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value._BeginDate                                = GetObject<Timestamp>(new IntPtr(p + 0x040), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D10B7408 0x40 _BeginDate                  ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x048), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D10B7448 0x48 _EndDate                    ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.MstEventId                                = GetInt32(new IntPtr(p + 0x050)); // 0270D10B7488 0x50 MstEventId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstEpisodeEventMissionBannerId            = GetInt32(new IntPtr(p + 0x054)); // 0270D10B74C8 0x54 MstEpisodeEventMissionBannerId ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BeginDate                     = ToDateTime(value._BeginDate);
            value.EndDate                       = ToDateTime(value._EndDate);

            return value;
        }
    }
}
