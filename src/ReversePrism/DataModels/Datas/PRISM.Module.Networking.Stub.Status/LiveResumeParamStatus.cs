using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LiveResumeParamStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSongIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstSongId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstSongTypeIdFieldNumber                 int IL2CPP_TYPE_I4
    // 01C MstSongTypeId                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 DifficultyLevelFieldNumber               int IL2CPP_TYPE_I4
    // 020 DifficultyLevel                          000186529820 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 000 StartTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 024 StartType                                000186582F90 ModelEnumType LiveStartType LiveStartType LiveStartType Int32
    // 000 LiveBonusFieldNumber                     int IL2CPP_TYPE_I4
    // 028 LiveBonus                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 UnitNumberFieldNumber                    int IL2CPP_TYPE_I4
    // 02C UnitNumber                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 TotalPowerFieldNumber                    int IL2CPP_TYPE_I4
    // 030 TotalPower                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SongLevelFieldNumber                     int IL2CPP_TYPE_I4
    // 034 SongLevel                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 OriginalMemberCountFieldNumber           int IL2CPP_TYPE_I4
    // 038 OriginalMemberCount                      0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LiveResumeParamStatus : DataModel
    {
        public int                                      MstSongId                               { get; set; }
        public int                                      MstSongTypeId                           { get; set; }
        public SongDifficultyLevel                      DifficultyLevel                         { get; set; }
        public LiveStartType                            StartType                               { get; set; }
        public int                                      LiveBonus                               { get; set; }
        public int                                      UnitNumber                              { get; set; }
        public int                                      TotalPower                              { get; set; }
        public int                                      SongLevel                               { get; set; }
        public int                                      OriginalMemberCount                     { get; set; }

        public static LiveResumeParamStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResumeParamStatus() { Pointer= p0 };

            value.MstSongId                                 = GetInt32(new IntPtr(p + 0x018)); // 0246612E0C90 0x18 MstSongId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstSongTypeId                             = GetInt32(new IntPtr(p + 0x01C)); // 0246612E0CD0 0x1C MstSongTypeId               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DifficultyLevel                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x020)); // 0246612E0D10 0x20 DifficultyLevel             ( 000186529820 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.StartType                                 = (LiveStartType)GetInt32(new IntPtr(p + 0x024)); // 0246612E0D50 0x24 StartType                   ( 000186582F90 ModelEnumType LiveStartType LiveStartType LiveStartType Int32 )
            value.LiveBonus                                 = GetInt32(new IntPtr(p + 0x028)); // 0246612E0D90 0x28 LiveBonus                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnitNumber                                = GetInt32(new IntPtr(p + 0x02C)); // 0246612E0DD0 0x2C UnitNumber                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TotalPower                                = GetInt32(new IntPtr(p + 0x030)); // 0246612E0E10 0x30 TotalPower                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SongLevel                                 = GetInt32(new IntPtr(p + 0x034)); // 0246612E0E50 0x34 SongLevel                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OriginalMemberCount                       = GetInt32(new IntPtr(p + 0x038)); // 0246612E0E90 0x38 OriginalMemberCount         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
