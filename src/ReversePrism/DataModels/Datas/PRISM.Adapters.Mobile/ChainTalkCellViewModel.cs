using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ChainTalkTextId                          0001865F4260 ModelPrimitiveType int int int Int32
    // 014 ChainGroupId                             0001865F4260 ModelPrimitiveType int int int Int32
    // 018 ChainUserId                              0001865F4260 ModelPrimitiveType int int int Int32
    // 01C NeedsShowIconAndName                     0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 020 PostType                                 00018653E6D0 ModelEnumType PostType PostType PostType Int32
    // 024 TalkerType                               00018653F3E0 ModelEnumType TalkerType TalkerType TalkerType Int32
    // 028 IsEndSeparator                           0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 029 IsIconButtonActive                       0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 02A IsThumbnailButtonActive                  0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class ChainTalkCellViewModel
    {
        public int                                      ChainTalkTextId                         { get; set; }
        public int                                      ChainGroupId                            { get; set; }
        public int                                      ChainUserId                             { get; set; }
        public bool                                     NeedsShowIconAndName                    { get; set; }
        public PostType                                 PostType                                { get; set; }
        public TalkerType                               TalkerType                              { get; set; }
        public bool                                     IsEndSeparator                          { get; set; }
        public bool                                     IsIconButtonActive                      { get; set; }
        public bool                                     IsThumbnailButtonActive                 { get; set; }

        public static ChainTalkCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkCellViewModel();

            value.ChainTalkTextId                           = GetInt32(new IntPtr(p + 0x010)); // 0270D6868CD0 0x10 ChainTalkTextId             ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ChainGroupId                              = GetInt32(new IntPtr(p + 0x014)); // 0270D6868CF0 0x14 ChainGroupId                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ChainUserId                               = GetInt32(new IntPtr(p + 0x018)); // 0270D6868D10 0x18 ChainUserId                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.NeedsShowIconAndName                      = GetBool(new IntPtr(p + 0x01C)); // 0270D6868D30 0x1C NeedsShowIconAndName        ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.PostType                                  = (PostType)GetInt32(new IntPtr(p + 0x020)); // 0270D6868D50 0x20 PostType                    ( 00018653E6D0 ModelEnumType PostType PostType PostType Int32 )
            value.TalkerType                                = (TalkerType)GetInt32(new IntPtr(p + 0x024)); // 0270D6868D70 0x24 TalkerType                  ( 00018653F3E0 ModelEnumType TalkerType TalkerType TalkerType Int32 )
            value.IsEndSeparator                            = GetBool(new IntPtr(p + 0x028)); // 0270D6868D90 0x28 IsEndSeparator              ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsIconButtonActive                        = GetBool(new IntPtr(p + 0x029)); // 0270D6868DB0 0x29 IsIconButtonActive          ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsThumbnailButtonActive                   = GetBool(new IntPtr(p + 0x02A)); // 0270D6868DD0 0x2A IsThumbnailButtonActive     ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
