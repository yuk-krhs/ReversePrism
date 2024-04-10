using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ChannelPort                              int IL2CPP_TYPE_I4
    // 040 EndBlock                                 000185B7A070 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 048 CurrentRoomName                          000186671E00 ModelPrimitiveType string string string String
    // 050 Channel                                  00018658F470 ModelClassType Channel Channel Channel Pointer
    public partial class PrismStreamingGrpc : DataModel
    {
        public List<sbyte>?                             EndBlock                                { get; set; }
        public string                                   CurrentRoomName                         { get; set; }
        public Channel?                                 Channel                                 { get; set; }

        public static PrismStreamingGrpc? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrismStreamingGrpc() { Pointer= p0 };

            value.EndBlock                                  = GetSByteList(new IntPtr(p + 0x040)); // 024664F8EDE0 0x40 EndBlock                    ( 000185B7A070 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.CurrentRoomName                           = GetString(new IntPtr(p + 0x048)); // 024664F8EE00 0x48 CurrentRoomName             ( 000186671E00 ModelPrimitiveType string string string String )
            value.Channel                                   = GetObject<Channel>(new IntPtr(p + 0x050), ReversePrism.DataModels.Channel.FromPointer); // 024664F8EE20 0x50 Channel                     ( 00018658F470 ModelClassType Channel Channel Channel Pointer )

            return value;
        }
    }
}
