using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LiveClearInfoStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 DifficultyLevelFieldNumber               int IL2CPP_TYPE_I4
    // 018 DifficultyLevel                          000186529820 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 000 IsClearedFieldNumber                     int IL2CPP_TYPE_I4
    // 01C IsCleared                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 IsFullComboFieldNumber                   int IL2CPP_TYPE_I4
    // 01D IsFullCombo                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 IsAllGreatFieldNumber                    int IL2CPP_TYPE_I4
    // 01E IsAllGreat                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 IsAllPerfectFieldNumber                  int IL2CPP_TYPE_I4
    // 01F IsAllPerfect                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class LiveClearInfoStatus
    {
        public SongDifficultyLevel                      DifficultyLevel                         { get; set; }
        public bool                                     IsCleared                               { get; set; }
        public bool                                     IsFullCombo                             { get; set; }
        public bool                                     IsAllGreat                              { get; set; }
        public bool                                     IsAllPerfect                            { get; set; }

        public static LiveClearInfoStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveClearInfoStatus();

            value.DifficultyLevel                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x018)); // 0270D1348F60 0x18 DifficultyLevel             ( 000186529820 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.IsCleared                                 = GetBool(new IntPtr(p + 0x01C)); // 0270D1348FA0 0x1C IsCleared                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsFullCombo                               = GetBool(new IntPtr(p + 0x01D)); // 0270D1348FE0 0x1D IsFullCombo                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsAllGreat                                = GetBool(new IntPtr(p + 0x01E)); // 0270D1349020 0x1E IsAllGreat                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsAllPerfect                              = GetBool(new IntPtr(p + 0x01F)); // 0270D1349060 0x1F IsAllPerfect                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
