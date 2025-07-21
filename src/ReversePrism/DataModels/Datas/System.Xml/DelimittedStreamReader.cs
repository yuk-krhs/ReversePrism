using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CanGetNextStream                         ModelPrimitiveType bool bool bool Bool
    // 018 CurrentStream                            ModelClassType DelimittedReadStream DelimittedReadStream DelimittedReadStream Pointer
    // 020 Delimitter                               ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 MatchBuffer                              ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 Scratch                                  ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 038 Stream                                   ModelClassType BufferedReadStream BufferedReadStream BufferedReadStream Pointer
    public partial class DelimittedStreamReader : DataModel
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
            var value   = new DelimittedStreamReader() { Pointer= p0 };

            value.CanGetNextStream                          = GetBool(new IntPtr(p + 0x010)); // 0x10 CanGetNextStream            ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentStream                             = GetObject<DelimittedReadStream>(new IntPtr(p + 0x018), ReversePrism.DataModels.DelimittedReadStream.FromPointer); // 0x18 CurrentStream               ( ModelClassType DelimittedReadStream DelimittedReadStream DelimittedReadStream Pointer )
            value.Delimitter                                = GetSByteList(new IntPtr(p + 0x020)); // 0x20 Delimitter                  ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.MatchBuffer                               = GetSByteList(new IntPtr(p + 0x028)); // 0x28 MatchBuffer                 ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Scratch                                   = GetSByteList(new IntPtr(p + 0x030)); // 0x30 Scratch                     ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Stream                                    = GetObject<BufferedReadStream>(new IntPtr(p + 0x038), ReversePrism.DataModels.BufferedReadStream.FromPointer); // 0x38 Stream                      ( ModelClassType BufferedReadStream BufferedReadStream BufferedReadStream Pointer )

            return value;
        }
    }
}
