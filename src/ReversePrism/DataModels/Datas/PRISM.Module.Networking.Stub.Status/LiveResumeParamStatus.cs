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
    // 018 MstSongId                                ModelPrimitiveType int int int Int32
    // 000 DifficultyLevelFieldNumber               int IL2CPP_TYPE_I4
    // 01C DifficultyLevel                          ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 000 StartTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 020 StartType                                ModelEnumType LiveStartType LiveStartType LiveStartType Int32
    // 000 UnitNumberFieldNumber                    int IL2CPP_TYPE_I4
    // 024 UnitNumber                               ModelPrimitiveType int int int Int32
    // 000 TotalPowerFieldNumber                    int IL2CPP_TYPE_I4
    // 028 TotalPower                               ModelPrimitiveType int int int Int32
    // 000 SongLevelFieldNumber                     int IL2CPP_TYPE_I4
    // 02C SongLevel                                ModelPrimitiveType int int int Int32
    // 000 OriginalMemberCountFieldNumber           int IL2CPP_TYPE_I4
    // 030 OriginalMemberCount                      ModelPrimitiveType int int int Int32
    public partial class LiveResumeParamStatus : DataModel
    {
        public int                                      MstSongId                               { get; set; }
        public SongDifficultyLevel                      DifficultyLevel                         { get; set; }
        public LiveStartType                            StartType                               { get; set; }
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

            value.MstSongId                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstSongId                   ( ModelPrimitiveType int int int Int32 )
            value.DifficultyLevel                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x01C)); // 0x1C DifficultyLevel             ( ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.StartType                                 = (LiveStartType)GetInt32(new IntPtr(p + 0x020)); // 0x20 StartType                   ( ModelEnumType LiveStartType LiveStartType LiveStartType Int32 )
            value.UnitNumber                                = GetInt32(new IntPtr(p + 0x024)); // 0x24 UnitNumber                  ( ModelPrimitiveType int int int Int32 )
            value.TotalPower                                = GetInt32(new IntPtr(p + 0x028)); // 0x28 TotalPower                  ( ModelPrimitiveType int int int Int32 )
            value.SongLevel                                 = GetInt32(new IntPtr(p + 0x02C)); // 0x2C SongLevel                   ( ModelPrimitiveType int int int Int32 )
            value.OriginalMemberCount                       = GetInt32(new IntPtr(p + 0x030)); // 0x30 OriginalMemberCount         ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
