using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<UserProfileLiveStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 DifficultyFieldNumber                    int IL2CPP_TYPE_I4
    // 018 Difficulty                               000186529820 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 000 TotalFieldNumber                         int IL2CPP_TYPE_I4
    // 01C Total                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 TotalOpenedFieldNumber                   int IL2CPP_TYPE_I4
    // 020 TotalOpened                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class UserProfileLiveStatus : DataModel
    {
        public SongDifficultyLevel                      Difficulty                              { get; set; }
        public int                                      Total                                   { get; set; }
        public int                                      TotalOpened                             { get; set; }

        public static UserProfileLiveStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UserProfileLiveStatus() { Pointer= p0 };

            value.Difficulty                                = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x018)); // 0246626933D8 0x18 Difficulty                  ( 000186529820 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.Total                                     = GetInt32(new IntPtr(p + 0x01C)); // 024662693418 0x1C Total                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TotalOpened                               = GetInt32(new IntPtr(p + 0x020)); // 024662693458 0x20 TotalOpened                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
