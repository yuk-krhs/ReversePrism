using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Resp                                     000186673BB0 ModelClassType ResponseDescription ResponseDescription ResponseDescription Pointer
    // 018 ValidThrough                             0001865F2F90 ModelPrimitiveType int int int Int32
    // 020 Buffer                                   000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 Connection                               0001865E16C0 ModelClassType CommandStream CommandStream CommandStream Pointer
    public partial class ReceiveState
    {
        public ResponseDescription?                     Resp                                    { get; set; }
        public int                                      ValidThrough                            { get; set; }
        public List<sbyte>?                             Buffer                                  { get; set; }
        public CommandStream?                           Connection                              { get; set; }

        public static ReceiveState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReceiveState();

            value.Resp                                      = GetObject<ResponseDescription>(new IntPtr(p + 0x010), ReversePrism.DataModels.ResponseDescription.FromPointer); // 0270D7A0F160 0x10 Resp                        ( 000186673BB0 ModelClassType ResponseDescription ResponseDescription ResponseDescription Pointer )
            value.ValidThrough                              = GetInt32(new IntPtr(p + 0x018)); // 0270D7A0F180 0x18 ValidThrough                ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x020)); // 0270D7A0F1A0 0x20 Buffer                      ( 000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Connection                                = GetObject<CommandStream>(new IntPtr(p + 0x028), ReversePrism.DataModels.CommandStream.FromPointer); // 0270D7A0F1C0 0x28 Connection                  ( 0001865E16C0 ModelClassType CommandStream CommandStream CommandStream Pointer )

            return value;
        }
    }
}
