using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Service                                  00018660A190 ModelClassType IPvpService IPvpService IPvpService Pointer
    // 018 EventId                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 020 TopReply                                 00018654A730 ModelClassType IGetPvpTopReply IGetPvpTopReply IGetPvpTopReply Pointer
    // 028 OpponentListReply                        0001865DC5E0 ModelClassType IPreparePvpOpponentListReply IPreparePvpOpponentListReply IPreparePvpOpponentListReply Pointer
    public partial class PvpTopModel : DataModel
    {
        public IPvpService?                             Service                                 { get; set; }
        public int                                      EventId                                 { get; set; }
        public IGetPvpTopReply?                         TopReply                                { get; set; }
        public IPreparePvpOpponentListReply?            OpponentListReply                       { get; set; }

        public static PvpTopModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpTopModel() { Pointer= p0 };

            value.Service                                   = GetObject<IPvpService>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPvpService.FromPointer); // 02466668BF08 0x10 Service                     ( 00018660A190 ModelClassType IPvpService IPvpService IPvpService Pointer )
            value.EventId                                   = GetInt32(new IntPtr(p + 0x018)); // 02466668BF28 0x18 EventId                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.TopReply                                  = GetObject<IGetPvpTopReply>(new IntPtr(p + 0x020), ReversePrism.DataModels.IGetPvpTopReply.FromPointer); // 02466668BF48 0x20 TopReply                    ( 00018654A730 ModelClassType IGetPvpTopReply IGetPvpTopReply IGetPvpTopReply Pointer )
            value.OpponentListReply                         = GetObject<IPreparePvpOpponentListReply>(new IntPtr(p + 0x028), ReversePrism.DataModels.IPreparePvpOpponentListReply.FromPointer); // 02466668BF68 0x28 OpponentListReply           ( 0001865DC5E0 ModelClassType IPreparePvpOpponentListReply IPreparePvpOpponentListReply IPreparePvpOpponentListReply Pointer )

            return value;
        }
    }
}
