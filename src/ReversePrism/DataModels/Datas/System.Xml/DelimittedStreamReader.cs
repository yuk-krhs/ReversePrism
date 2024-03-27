using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CanGetNextStream                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 CurrentStream                            00018659C590 ModelClassType DelimittedReadStream DelimittedReadStream DelimittedReadStream Pointer
    // 020 Delimitter                               000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 MatchBuffer                              000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 Scratch                                  000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 038 Stream                                   00018650CA60 ModelClassType BufferedReadStream BufferedReadStream BufferedReadStream Pointer
    public partial class DelimittedStreamReader
    {
        public bool                                     CanGetNextStream                        { get; set; }
        public DelimittedReadStream?                    CurrentStream                           { get; set; }
        public List<sbyte>?                             Delimitter                              { get; set; }
        public List<sbyte>?                             MatchBuffer                             { get; set; }
        public List<sbyte>?                             Scratch                                 { get; set; }
        public BufferedReadStream?                      Stream                                  { get; set; }

        public static DelimittedStreamReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DelimittedStreamReader();

            value.CanGetNextStream                          = GetBool(new IntPtr(p + 0x010)); // 0270D7C91260 0x10 CanGetNextStream            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CurrentStream                             = GetObject<DelimittedReadStream>(new IntPtr(p + 0x018), ReversePrism.DataModels.DelimittedReadStream.FromPointer); // 0270D7C91280 0x18 CurrentStream               ( 00018659C590 ModelClassType DelimittedReadStream DelimittedReadStream DelimittedReadStream Pointer )
            value.Delimitter                                = GetSByteList(new IntPtr(p + 0x020)); // 0270D7C912A0 0x20 Delimitter                  ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.MatchBuffer                               = GetSByteList(new IntPtr(p + 0x028)); // 0270D7C912C0 0x28 MatchBuffer                 ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Scratch                                   = GetSByteList(new IntPtr(p + 0x030)); // 0270D7C912E0 0x30 Scratch                     ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Stream                                    = GetObject<BufferedReadStream>(new IntPtr(p + 0x038), ReversePrism.DataModels.BufferedReadStream.FromPointer); // 0270D7C91300 0x38 Stream                      ( 00018650CA60 ModelClassType BufferedReadStream BufferedReadStream BufferedReadStream Pointer )

            return value;
        }
    }
}
