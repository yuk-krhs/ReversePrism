using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ChannelPort                              int IL2CPP_TYPE_I4
    // 040 EndBlock                                 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 048 CurrentRoomName                          ModelPrimitiveType string string string String
    // 050 Channel                                  ModelClassType Channel Channel Channel Pointer
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

            value.EndBlock                                  = GetSByteList(new IntPtr(p + 0x040)); // 0x40 EndBlock                    ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.CurrentRoomName                           = GetString(new IntPtr(p + 0x048)); // 0x48 CurrentRoomName             ( ModelPrimitiveType string string string String )
            value.Channel                                   = GetObject<Channel>(new IntPtr(p + 0x050), ReversePrism.DataModels.Channel.FromPointer); // 0x50 Channel                     ( ModelClassType Channel Channel Channel Pointer )

            return value;
        }
    }
}
