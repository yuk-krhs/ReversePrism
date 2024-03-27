using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetLiveHighScoreRankingReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSongIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstSongId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 DifficultyLevelFieldNumber               int IL2CPP_TYPE_I4
    // 01C DifficultyLevel                          000186529820 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 000 PageFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Page                                     00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 SelfRankFieldNumber                      int IL2CPP_TYPE_I4
    // 028 SelfRank                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SelfHighScoreFieldNumber                 int IL2CPP_TYPE_I4
    // 02C SelfHighScore                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 UserListFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _repeated_userList_codec                 FieldCodec`1<LiveHighScoreRankingUserStatus> IL2CPP_TYPE_GENERICINST
    // 030 UserList                                 000185CE32B8 ModelClassListType RepeatedField`1<LiveHighScoreRankingUserStatus> RepeatedField`1<LiveHighScoreRankingUserStatus> List<LiveHighScoreRankingUserStatus> Pointer
    public partial class GetLiveHighScoreRankingReply
    {
        public int                                      MstSongId                               { get; set; }
        public SongDifficultyLevel                      DifficultyLevel                         { get; set; }
        public LimitedValueStatus?                      Page                                    { get; set; }
        public int                                      SelfRank                                { get; set; }
        public int                                      SelfHighScore                           { get; set; }
        public List<LiveHighScoreRankingUserStatus>?    UserList                                { get; set; }

        public static GetLiveHighScoreRankingReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetLiveHighScoreRankingReply();

            value.MstSongId                                 = GetInt32(new IntPtr(p + 0x018)); // 0270D21D1CD0 0x18 MstSongId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DifficultyLevel                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x01C)); // 0270D21D1D10 0x1C DifficultyLevel             ( 000186529820 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.Page                                      = GetObject<LimitedValueStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0270D21D1D50 0x20 Page                        ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.SelfRank                                  = GetInt32(new IntPtr(p + 0x028)); // 0270D21D1D90 0x28 SelfRank                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelfHighScore                             = GetInt32(new IntPtr(p + 0x02C)); // 0270D21D1DD0 0x2C SelfHighScore               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UserList                                  = GetObjectList<LiveHighScoreRankingUserStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveHighScoreRankingUserStatus.FromPointer); // 0270D21D1E30 0x30 UserList                    ( 000185CE32B8 ModelClassListType RepeatedField`1<LiveHighScoreRankingUserStatus> RepeatedField`1<LiveHighScoreRankingUserStatus> List<LiveHighScoreRankingUserStatus> Pointer )

            return value;
        }
    }
}
