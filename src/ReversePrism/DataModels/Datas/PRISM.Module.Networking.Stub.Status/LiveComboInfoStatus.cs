using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LiveComboInfoStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ComboFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Combo                                    ModelPrimitiveType int int int Int32
    // 000 ComboRankFieldNumber                     int IL2CPP_TYPE_I4
    // 01C ComboRank                                ModelEnumType ComboRank ComboRank ComboRank Int32
    // 000 IsNewRecordFieldNumber                   int IL2CPP_TYPE_I4
    // 020 IsNewRecord                              ModelPrimitiveType bool bool bool Bool
    public partial class LiveComboInfoStatus : DataModel
    {
        public int                                      Combo                                   { get; set; }
        public ComboRank                                ComboRank                               { get; set; }
        public bool                                     IsNewRecord                             { get; set; }

        public static LiveComboInfoStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveComboInfoStatus() { Pointer= p0 };

            value.Combo                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Combo                       ( ModelPrimitiveType int int int Int32 )
            value.ComboRank                                 = (ComboRank)GetInt32(new IntPtr(p + 0x01C)); // 0x1C ComboRank                   ( ModelEnumType ComboRank ComboRank ComboRank Int32 )
            value.IsNewRecord                               = GetBool(new IntPtr(p + 0x020)); // 0x20 IsNewRecord                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
