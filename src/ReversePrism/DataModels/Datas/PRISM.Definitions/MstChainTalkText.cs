using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstChainTalkId                           ModelPrimitiveType int int int Int32
    // 018 MstChainUserId                           ModelPrimitiveType int int int Int32
    // 01C TextType                                 ModelPrimitiveType int int int Int32
    // 020 StampId                                  ModelPrimitiveType int int int Int32
    // 024 ThumbnailId                              ModelPrimitiveType int int int Int32
    // 028 NextId                                   ModelPrimitiveListType int[] int[] List<int> Pointer
    // 030 ThinkingRate                             ModelPrimitiveType int int int Int32
    // 034 TypingRate                               ModelPrimitiveType int int int Int32
    // 038 HasExtraThumbnail                        ModelPrimitiveType bool bool bool Bool
    public partial class MstChainTalkText : DataModel
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
        public bool                                     HasExtraThumbnail                       { get; set; }

        public static MstChainTalkText? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstChainTalkText() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstChainTalkId                            = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstChainTalkId              ( ModelPrimitiveType int int int Int32 )
            value.MstChainUserId                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstChainUserId              ( ModelPrimitiveType int int int Int32 )
            value.TextType                                  = GetInt32(new IntPtr(p + 0x01C)); // 0x1C TextType                    ( ModelPrimitiveType int int int Int32 )
            value.StampId                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 StampId                     ( ModelPrimitiveType int int int Int32 )
            value.ThumbnailId                               = GetInt32(new IntPtr(p + 0x024)); // 0x24 ThumbnailId                 ( ModelPrimitiveType int int int Int32 )
            value.NextId                                    = GetInt32List(new IntPtr(p + 0x028)); // 0x28 NextId                      ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.ThinkingRate                              = GetInt32(new IntPtr(p + 0x030)); // 0x30 ThinkingRate                ( ModelPrimitiveType int int int Int32 )
            value.TypingRate                                = GetInt32(new IntPtr(p + 0x034)); // 0x34 TypingRate                  ( ModelPrimitiveType int int int Int32 )
            value.HasExtraThumbnail                         = GetBool(new IntPtr(p + 0x038)); // 0x38 HasExtraThumbnail           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
