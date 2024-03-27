using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstChainTalkId                           0001865F4260 ModelPrimitiveType int int int Int32
    // 018 MstChainUserId                           0001865F4260 ModelPrimitiveType int int int Int32
    // 01C TextType                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 020 StampId                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 024 ThumbnailId                              0001865F4260 ModelPrimitiveType int int int Int32
    // 028 NextId                                   000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 030 ThinkingRate                             0001865F4260 ModelPrimitiveType int int int Int32
    // 034 TypingRate                               0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstChainTalkText
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstChainTalkId                          { get; set; }
        public int                                      MstChainUserId                          { get; set; }
        public int                                      TextType                                { get; set; }
        public int                                      StampId                                 { get; set; }
        public int                                      ThumbnailId                             { get; set; }
        public List<int>?                               NextId                                  { get; set; }
        public int                                      ThinkingRate                            { get; set; }
        public int                                      TypingRate                              { get; set; }

        public static MstChainTalkText? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstChainTalkText();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 02700461B1B0 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstChainTalkId                            = GetInt32(new IntPtr(p + 0x014)); // 02700461B1D0 0x14 MstChainTalkId              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstChainUserId                            = GetInt32(new IntPtr(p + 0x018)); // 02700461B1F0 0x18 MstChainUserId              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.TextType                                  = GetInt32(new IntPtr(p + 0x01C)); // 02700461B210 0x1C TextType                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.StampId                                   = GetInt32(new IntPtr(p + 0x020)); // 02700461B230 0x20 StampId                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ThumbnailId                               = GetInt32(new IntPtr(p + 0x024)); // 02700461B250 0x24 ThumbnailId                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.NextId                                    = GetInt32List(new IntPtr(p + 0x028)); // 02700461B270 0x28 NextId                      ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.ThinkingRate                              = GetInt32(new IntPtr(p + 0x030)); // 02700461B290 0x30 ThinkingRate                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.TypingRate                                = GetInt32(new IntPtr(p + 0x034)); // 02700461B2B0 0x34 TypingRate                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
