using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ComboRankStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RankFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Rank                                     0001865DE690 ModelEnumType ComboRank ComboRank ComboRank Int32
    // 000 TargetValueFieldNumber                   int IL2CPP_TYPE_I4
    // 01C TargetValue                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ComboRankStatus : DataModel
    {
        public ComboRank                                Rank                                    { get; set; }
        public int                                      TargetValue                             { get; set; }

        public static ComboRankStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ComboRankStatus() { Pointer= p0 };

            value.Rank                                      = (ComboRank)GetInt32(new IntPtr(p + 0x018)); // 0246612C2458 0x18 Rank                        ( 0001865DE690 ModelEnumType ComboRank ComboRank ComboRank Int32 )
            value.TargetValue                               = GetInt32(new IntPtr(p + 0x01C)); // 0246612C2498 0x1C TargetValue                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
