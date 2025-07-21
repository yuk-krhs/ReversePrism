using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CommonCellData                           ModelClassType ChainTalkCellCommonData ChainTalkCellCommonData ChainTalkCellCommonData Pointer
    // 018 ChainUserId                              ModelPrimitiveType int int int Int32
    // 01C IsProducer                               ModelPrimitiveType bool bool bool Bool
    // 01D ShowTypingBalloon                        ModelPrimitiveType bool bool bool Bool
    // 020 ThinkingRate                             ModelPrimitiveType int int int Int32
    // 024 TypingRate                               ModelPrimitiveType int int int Int32
    public partial class ChainTalkCellDataForUnreadScroller : DataModel
    {
        public ChainTalkCellCommonData?                 CommonCellData                          { get; set; }
        public int                                      ChainUserId                             { get; set; }
        public bool                                     IsProducer                              { get; set; }
        public bool                                     ShowTypingBalloon                       { get; set; }
        public int                                      ThinkingRate                            { get; set; }
        public int                                      TypingRate                              { get; set; }

        public static ChainTalkCellDataForUnreadScroller? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkCellDataForUnreadScroller() { Pointer= p0 };

            value.CommonCellData                            = GetObject<ChainTalkCellCommonData>(new IntPtr(p + 0x010), ReversePrism.DataModels.ChainTalkCellCommonData.FromPointer); // 0x10 CommonCellData              ( ModelClassType ChainTalkCellCommonData ChainTalkCellCommonData ChainTalkCellCommonData Pointer )
            value.ChainUserId                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 ChainUserId                 ( ModelPrimitiveType int int int Int32 )
            value.IsProducer                                = GetBool(new IntPtr(p + 0x01C)); // 0x1C IsProducer                  ( ModelPrimitiveType bool bool bool Bool )
            value.ShowTypingBalloon                         = GetBool(new IntPtr(p + 0x01D)); // 0x1D ShowTypingBalloon           ( ModelPrimitiveType bool bool bool Bool )
            value.ThinkingRate                              = GetInt32(new IntPtr(p + 0x020)); // 0x20 ThinkingRate                ( ModelPrimitiveType int int int Int32 )
            value.TypingRate                                = GetInt32(new IntPtr(p + 0x024)); // 0x24 TypingRate                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
