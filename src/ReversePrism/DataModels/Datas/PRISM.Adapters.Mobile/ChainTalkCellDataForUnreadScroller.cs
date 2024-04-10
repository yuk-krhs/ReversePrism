using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CommonCellData                           00018655C020 ModelClassType ChainTalkCellCommonData ChainTalkCellCommonData ChainTalkCellCommonData Pointer
    // 018 ChainUserId                              0001865F4260 ModelPrimitiveType int int int Int32
    // 01C IsProducer                               0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 01D ShowTypingBalloon                        0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 020 ThinkingRate                             0001865F4260 ModelPrimitiveType int int int Int32
    // 024 TypingRate                               0001865F4260 ModelPrimitiveType int int int Int32
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

            value.CommonCellData                            = GetObject<ChainTalkCellCommonData>(new IntPtr(p + 0x010), ReversePrism.DataModels.ChainTalkCellCommonData.FromPointer); // 0246668C84B8 0x10 CommonCellData              ( 00018655C020 ModelClassType ChainTalkCellCommonData ChainTalkCellCommonData ChainTalkCellCommonData Pointer )
            value.ChainUserId                               = GetInt32(new IntPtr(p + 0x018)); // 0246668C84D8 0x18 ChainUserId                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IsProducer                                = GetBool(new IntPtr(p + 0x01C)); // 0246668C84F8 0x1C IsProducer                  ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.ShowTypingBalloon                         = GetBool(new IntPtr(p + 0x01D)); // 0246668C8518 0x1D ShowTypingBalloon           ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.ThinkingRate                              = GetInt32(new IntPtr(p + 0x020)); // 0246668C8538 0x20 ThinkingRate                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.TypingRate                                = GetInt32(new IntPtr(p + 0x024)); // 0246668C8558 0x24 TypingRate                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
