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
    // 000 _parser                                  MessageParser`1<SeasonMissionBannerStatus> IL2CPP_TYPE_GENERICINST
    // 030 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSeasonMissionIdFieldNumber            int IL2CPP_TYPE_I4
    // 038 MstSeasonMissionId                       ModelPrimitiveType int int int Int32
    // 000 StateFieldNumber                         int IL2CPP_TYPE_I4
    // 03C State                                    ModelEnumType SeasonMissionBannerState SeasonMissionBannerState SeasonMissionBannerState Int32
    // 000 BeginDateFieldNumber                     int IL2CPP_TYPE_I4
    // 040 _BeginDate                               ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 048 _EndDate                                 ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class SeasonMissionBannerStatus : DataModel
    {
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public int                                      MstSeasonMissionId                      { get; set; }
        public SeasonMissionBannerState                 State                                   { get; set; }
        public Timestamp?                               _BeginDate                              { get; set; }
        public Timestamp?                               _EndDate                                { get; set; }

        public static SeasonMissionBannerStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionBannerStatus() { Pointer= p0 };

            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x010)); // 0x10 BeginDate                   ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x020)); // 0x20 EndDate                     ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstSeasonMissionId                        = GetInt32(new IntPtr(p + 0x038)); // 0x38 MstSeasonMissionId          ( ModelPrimitiveType int int int Int32 )
            value.State                                     = (SeasonMissionBannerState)GetInt32(new IntPtr(p + 0x03C)); // 0x3C State                       ( ModelEnumType SeasonMissionBannerState SeasonMissionBannerState SeasonMissionBannerState Int32 )
            value._BeginDate                                = GetObject<Timestamp>(new IntPtr(p + 0x040), ReversePrism.DataModels.Timestamp.FromPointer); // 0x40 _BeginDate                  ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x048), ReversePrism.DataModels.Timestamp.FromPointer); // 0x48 _EndDate                    ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.BeginDate                     = ToDateTime(value._BeginDate);
            value.EndDate                       = ToDateTime(value._EndDate);

            return value;
        }
    }
}
