using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SizeType                                 000186765160 ModelEnumType PopupSizeType PopupSizeType PopupSizeType Int32
    // 014 ButtonType                               000186609B60 ModelEnumType MessagePopupButtonType MessagePopupButtonType MessagePopupButtonType Int32
    // 018 CustomButtonList                         000185CD0698 ModelClassListType List`1<ButtonInformation> List`1<ButtonInformation> List<ButtonInformation> Pointer
    // 020 HeaderType                               000186763690 ModelEnumType PopupHeaderType PopupHeaderType PopupHeaderType Int32
    // 024 FooterType                               000186762880 ModelEnumType PopupFooterType PopupFooterType PopupFooterType Int32
    // 028 OutOfRangeTouch                          000186764780 ModelEnumType PopupOutOfRangeTouch PopupOutOfRangeTouch PopupOutOfRangeTouch Int32
    // 030 Title                                    0001866722E0 ModelPrimitiveType string string string String
    // 038 Message                                  0001866722E0 ModelPrimitiveType string string string String
    // 040 MessageFontSize                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 048 SubMessages                              Dictionary`2<string, CommonPopupTextInfo> IL2CPP_TYPE_GENERICINST
    // 050 Priority                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 058 ContentName                              0001866722E0 ModelPrimitiveType string string string String
    // 060 ContentPrefab                            000186761CA0 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 068 OpenSE                                   000186536470 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 078 CloseSE                                  000186536470 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 088 IsShowTitleInfoButton                    000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class CommonPopupParam
    {
        public PopupSizeType                            SizeType                                { get; set; }
        public MessagePopupButtonType                   ButtonType                              { get; set; }
        public List<ButtonInformation>?                 CustomButtonList                        { get; set; }
        public PopupHeaderType                          HeaderType                              { get; set; }
        public PopupFooterType                          FooterType                              { get; set; }
        public PopupOutOfRangeTouch                     OutOfRangeTouch                         { get; set; }
        public string                                   Title                                   { get; set; }
        public string                                   Message                                 { get; set; }
        public int                                      MessageFontSize                         { get; set; }
        public int                                      Priority                                { get; set; }
        public string                                   ContentName                             { get; set; }
        public PopupContentBase?                        ContentPrefab                           { get; set; }
        public SoundKey                                 OpenSE                                  { get; set; }
        public SoundKey                                 CloseSE                                 { get; set; }
        public bool                                     IsShowTitleInfoButton                   { get; set; }

        public static CommonPopupParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonPopupParam();

            value.SizeType                                  = (PopupSizeType)GetInt32(new IntPtr(p + 0x010)); // 0270D4C0D2F8 0x10 SizeType                    ( 000186765160 ModelEnumType PopupSizeType PopupSizeType PopupSizeType Int32 )
            value.ButtonType                                = (MessagePopupButtonType)GetInt32(new IntPtr(p + 0x014)); // 0270D4C0D318 0x14 ButtonType                  ( 000186609B60 ModelEnumType MessagePopupButtonType MessagePopupButtonType MessagePopupButtonType Int32 )
            value.CustomButtonList                          = GetObjectList<ButtonInformation>(new IntPtr(p + 0x018), ReversePrism.DataModels.ButtonInformation.FromPointer); // 0270D4C0D338 0x18 CustomButtonList            ( 000185CD0698 ModelClassListType List`1<ButtonInformation> List`1<ButtonInformation> List<ButtonInformation> Pointer )
            value.HeaderType                                = (PopupHeaderType)GetInt32(new IntPtr(p + 0x020)); // 0270D4C0D358 0x20 HeaderType                  ( 000186763690 ModelEnumType PopupHeaderType PopupHeaderType PopupHeaderType Int32 )
            value.FooterType                                = (PopupFooterType)GetInt32(new IntPtr(p + 0x024)); // 0270D4C0D378 0x24 FooterType                  ( 000186762880 ModelEnumType PopupFooterType PopupFooterType PopupFooterType Int32 )
            value.OutOfRangeTouch                           = (PopupOutOfRangeTouch)GetInt32(new IntPtr(p + 0x028)); // 0270D4C0D398 0x28 OutOfRangeTouch             ( 000186764780 ModelEnumType PopupOutOfRangeTouch PopupOutOfRangeTouch PopupOutOfRangeTouch Int32 )
            value.Title                                     = GetString(new IntPtr(p + 0x030)); // 0270D4C0D3B8 0x30 Title                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Message                                   = GetString(new IntPtr(p + 0x038)); // 0270D4C0D3D8 0x38 Message                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.MessageFontSize                           = GetInt32(new IntPtr(p + 0x040)); // 0270D4C0D3F8 0x40 MessageFontSize             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Priority                                  = GetInt32(new IntPtr(p + 0x050)); // 0270D4C0D438 0x50 Priority                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ContentName                               = GetString(new IntPtr(p + 0x058)); // 0270D4C0D458 0x58 ContentName                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ContentPrefab                             = GetObject<PopupContentBase>(new IntPtr(p + 0x060), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0270D4C0D478 0x60 ContentPrefab               ( 000186761CA0 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.OpenSE                                    = (SoundKey)GetInt32(new IntPtr(p + 0x068)); // 0270D4C0D498 0x68 OpenSE                      ( 000186536470 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.CloseSE                                   = (SoundKey)GetInt32(new IntPtr(p + 0x078)); // 0270D4C0D4B8 0x78 CloseSE                     ( 000186536470 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.IsShowTitleInfoButton                     = GetBool(new IntPtr(p + 0x088)); // 0270D4C0D4D8 0x88 IsShowTitleInfoButton       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
