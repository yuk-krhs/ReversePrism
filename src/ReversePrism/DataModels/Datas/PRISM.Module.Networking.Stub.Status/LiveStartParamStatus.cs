using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LiveStartParamStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSongIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstSongId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstSongTypeIdFieldNumber                 int IL2CPP_TYPE_I4
    // 01C MstSongTypeId                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 DifficultyLevelFieldNumber               int IL2CPP_TYPE_I4
    // 020 DifficultyLevel                          000186529820 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 000 StartTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 024 StartType                                000186582F90 ModelEnumType LiveStartType LiveStartType LiveStartType Int32
    // 000 LiveBoostFieldNumber                     int IL2CPP_TYPE_I4
    // 028 LiveBoost                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 UnitNumberFieldNumber                    int IL2CPP_TYPE_I4
    // 02C UnitNumber                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LiveStartParamStatus
    {
        public int                                      MstSongId                               { get; set; }
        public int                                      MstSongTypeId                           { get; set; }
        public SongDifficultyLevel                      DifficultyLevel                         { get; set; }
        public LiveStartType                            StartType                               { get; set; }
        public int                                      LiveBoost                               { get; set; }
        public int                                      UnitNumber                              { get; set; }

        public static LiveStartParamStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveStartParamStatus();

            value.MstSongId                                 = GetInt32(new IntPtr(p + 0x018)); // 0270D135BD48 0x18 MstSongId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstSongTypeId                             = GetInt32(new IntPtr(p + 0x01C)); // 0270D135BD88 0x1C MstSongTypeId               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DifficultyLevel                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x020)); // 0270D135BDC8 0x20 DifficultyLevel             ( 000186529820 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.StartType                                 = (LiveStartType)GetInt32(new IntPtr(p + 0x024)); // 0270D135BE08 0x24 StartType                   ( 000186582F90 ModelEnumType LiveStartType LiveStartType LiveStartType Int32 )
            value.LiveBoost                                 = GetInt32(new IntPtr(p + 0x028)); // 0270D135BE48 0x28 LiveBoost                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnitNumber                                = GetInt32(new IntPtr(p + 0x02C)); // 0270D135BE88 0x2C UnitNumber                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
