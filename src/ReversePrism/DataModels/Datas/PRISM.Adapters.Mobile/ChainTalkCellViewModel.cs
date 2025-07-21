using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ChainTalkTextId                          ModelPrimitiveType int int int Int32
    // 014 ChainGroupId                             ModelPrimitiveType int int int Int32
    // 018 ChainUserId                              ModelPrimitiveType int int int Int32
    // 01C NeedsShowIconAndName                     ModelPrimitiveType bool bool bool Bool
    // 020 PostType                                 ModelEnumType PostType PostType PostType Int32
    // 024 TalkerType                               ModelEnumType TalkerType TalkerType TalkerType Int32
    // 028 IsEndSeparator                           ModelPrimitiveType bool bool bool Bool
    // 029 IsIconButtonActive                       ModelPrimitiveType bool bool bool Bool
    // 02A IsThumbnailButtonActive                  ModelPrimitiveType bool bool bool Bool
    public partial class ChainTalkCellViewModel : DataModel
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
            var value   = new ChainTalkCellViewModel() { Pointer= p0 };

            value.ChainTalkTextId                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 ChainTalkTextId             ( ModelPrimitiveType int int int Int32 )
            value.ChainGroupId                              = GetInt32(new IntPtr(p + 0x014)); // 0x14 ChainGroupId                ( ModelPrimitiveType int int int Int32 )
            value.ChainUserId                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 ChainUserId                 ( ModelPrimitiveType int int int Int32 )
            value.NeedsShowIconAndName                      = GetBool(new IntPtr(p + 0x01C)); // 0x1C NeedsShowIconAndName        ( ModelPrimitiveType bool bool bool Bool )
            value.PostType                                  = (PostType)GetInt32(new IntPtr(p + 0x020)); // 0x20 PostType                    ( ModelEnumType PostType PostType PostType Int32 )
            value.TalkerType                                = (TalkerType)GetInt32(new IntPtr(p + 0x024)); // 0x24 TalkerType                  ( ModelEnumType TalkerType TalkerType TalkerType Int32 )
            value.IsEndSeparator                            = GetBool(new IntPtr(p + 0x028)); // 0x28 IsEndSeparator              ( ModelPrimitiveType bool bool bool Bool )
            value.IsIconButtonActive                        = GetBool(new IntPtr(p + 0x029)); // 0x29 IsIconButtonActive          ( ModelPrimitiveType bool bool bool Bool )
            value.IsThumbnailButtonActive                   = GetBool(new IntPtr(p + 0x02A)); // 0x2A IsThumbnailButtonActive     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
