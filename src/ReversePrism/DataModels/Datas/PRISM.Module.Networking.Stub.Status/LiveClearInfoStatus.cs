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
    // 018 DifficultyLevel                          ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 000 IsClearedFieldNumber                     int IL2CPP_TYPE_I4
    // 01C IsCleared                                ModelPrimitiveType bool bool bool Bool
    // 000 IsFullComboFieldNumber                   int IL2CPP_TYPE_I4
    // 01D IsFullCombo                              ModelPrimitiveType bool bool bool Bool
    // 000 IsAllGreatFieldNumber                    int IL2CPP_TYPE_I4
    // 01E IsAllGreat                               ModelPrimitiveType bool bool bool Bool
    // 000 IsAllPerfectFieldNumber                  int IL2CPP_TYPE_I4
    // 01F IsAllPerfect                             ModelPrimitiveType bool bool bool Bool
    // 000 ClearInfoFieldNumber                     int IL2CPP_TYPE_I4
    // 020 ClearInfo                                ModelEnumType LiveClearInfo LiveClearInfo LiveClearInfo Int32
    public partial class LiveClearInfoStatus : DataModel
    {
        public SongDifficultyLevel                      DifficultyLevel                         { get; set; }
        public bool                                     IsCleared                               { get; set; }
        public bool                                     IsFullCombo                             { get; set; }
        public bool                                     IsAllGreat                              { get; set; }
        public bool                                     IsAllPerfect                            { get; set; }
        public LiveClearInfo                            ClearInfo                               { get; set; }

        public static LiveClearInfoStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveClearInfoStatus() { Pointer= p0 };

            value.DifficultyLevel                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x018)); // 0x18 DifficultyLevel             ( ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.IsCleared                                 = GetBool(new IntPtr(p + 0x01C)); // 0x1C IsCleared                   ( ModelPrimitiveType bool bool bool Bool )
            value.IsFullCombo                               = GetBool(new IntPtr(p + 0x01D)); // 0x1D IsFullCombo                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsAllGreat                                = GetBool(new IntPtr(p + 0x01E)); // 0x1E IsAllGreat                  ( ModelPrimitiveType bool bool bool Bool )
            value.IsAllPerfect                              = GetBool(new IntPtr(p + 0x01F)); // 0x1F IsAllPerfect                ( ModelPrimitiveType bool bool bool Bool )
            value.ClearInfo                                 = (LiveClearInfo)GetInt32(new IntPtr(p + 0x020)); // 0x20 ClearInfo                   ( ModelEnumType LiveClearInfo LiveClearInfo LiveClearInfo Int32 )

            return value;
        }
    }
}
