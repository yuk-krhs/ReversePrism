using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PvpMatchResultStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IsWinFieldNumber                         int IL2CPP_TYPE_I4
    // 018 IsWin                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 BeforeRankFieldNumber                    int IL2CPP_TYPE_I4
    // 01C BeforeRank                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 AfterRankFieldNumber                     int IL2CPP_TYPE_I4
    // 020 AfterRank                                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class PvpMatchResultStatus : DataModel
    {
        public bool                                     IsWin                                   { get; set; }
        public int                                      BeforeRank                              { get; set; }
        public int                                      AfterRank                               { get; set; }

        public static PvpMatchResultStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpMatchResultStatus() { Pointer= p0 };

            value.IsWin                                     = GetBool(new IntPtr(p + 0x018)); // 02466139A9D8 0x18 IsWin                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BeforeRank                                = GetInt32(new IntPtr(p + 0x01C)); // 02466139AA18 0x1C BeforeRank                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AfterRank                                 = GetInt32(new IntPtr(p + 0x020)); // 02466139AA58 0x20 AfterRank                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
