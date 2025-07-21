using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SizeType                                 ModelEnumType PopupSizeType PopupSizeType PopupSizeType Int32
    // 014 ButtonType                               ModelEnumType MessagePopupButtonType MessagePopupButtonType MessagePopupButtonType Int32
    // 018 CustomButtonList                         ModelClassListType List`1<ButtonInformation> List`1<ButtonInformation> List<ButtonInformation> Pointer
    // 020 HeaderType                               ModelEnumType PopupHeaderType PopupHeaderType PopupHeaderType Int32
    // 024 FooterType                               ModelEnumType PopupFooterType PopupFooterType PopupFooterType Int32
    // 028 OutOfRangeTouch                          ModelEnumType PopupOutOfRangeTouch PopupOutOfRangeTouch PopupOutOfRangeTouch Int32
    // 030 Title                                    ModelPrimitiveType string string string String
    // 038 Message                                  ModelPrimitiveType string string string String
    // 040 MessageFontSize                          ModelPrimitiveType int int int Int32
    // 048 SubMessages                              Dictionary`2<string, CommonPopupTextInfo> IL2CPP_TYPE_GENERICINST
    // 050 Priority                                 ModelPrimitiveType int int int Int32
    // 058 ContentName                              ModelPrimitiveType string string string String
    // 060 ContentPrefab                            ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 068 OpenSE                                   ModelEnumType SoundKey SoundKey SoundKey Int32
    // 078 CloseSE                                  ModelEnumType SoundKey SoundKey SoundKey Int32
    // 088 IsShowTitleInfoButton                    ModelPrimitiveType bool bool bool Bool
    public partial class CommonPopupParam : DataModel
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
            var value   = new CommonPopupParam() { Pointer= p0 };

            value.SizeType                                  = (PopupSizeType)GetInt32(new IntPtr(p + 0x010)); // 0x10 SizeType                    ( ModelEnumType PopupSizeType PopupSizeType PopupSizeType Int32 )
            value.ButtonType                                = (MessagePopupButtonType)GetInt32(new IntPtr(p + 0x014)); // 0x14 ButtonType                  ( ModelEnumType MessagePopupButtonType MessagePopupButtonType MessagePopupButtonType Int32 )
            value.CustomButtonList                          = GetObjectList<ButtonInformation>(new IntPtr(p + 0x018), ReversePrism.DataModels.ButtonInformation.FromPointer); // 0x18 CustomButtonList            ( ModelClassListType List`1<ButtonInformation> List`1<ButtonInformation> List<ButtonInformation> Pointer )
            value.HeaderType                                = (PopupHeaderType)GetInt32(new IntPtr(p + 0x020)); // 0x20 HeaderType                  ( ModelEnumType PopupHeaderType PopupHeaderType PopupHeaderType Int32 )
            value.FooterType                                = (PopupFooterType)GetInt32(new IntPtr(p + 0x024)); // 0x24 FooterType                  ( ModelEnumType PopupFooterType PopupFooterType PopupFooterType Int32 )
            value.OutOfRangeTouch                           = (PopupOutOfRangeTouch)GetInt32(new IntPtr(p + 0x028)); // 0x28 OutOfRangeTouch             ( ModelEnumType PopupOutOfRangeTouch PopupOutOfRangeTouch PopupOutOfRangeTouch Int32 )
            value.Title                                     = GetString(new IntPtr(p + 0x030)); // 0x30 Title                       ( ModelPrimitiveType string string string String )
            value.Message                                   = GetString(new IntPtr(p + 0x038)); // 0x38 Message                     ( ModelPrimitiveType string string string String )
            value.MessageFontSize                           = GetInt32(new IntPtr(p + 0x040)); // 0x40 MessageFontSize             ( ModelPrimitiveType int int int Int32 )
            value.Priority                                  = GetInt32(new IntPtr(p + 0x050)); // 0x50 Priority                    ( ModelPrimitiveType int int int Int32 )
            value.ContentName                               = GetString(new IntPtr(p + 0x058)); // 0x58 ContentName                 ( ModelPrimitiveType string string string String )
            value.ContentPrefab                             = GetObject<PopupContentBase>(new IntPtr(p + 0x060), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0x60 ContentPrefab               ( ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.OpenSE                                    = (SoundKey)GetInt32(new IntPtr(p + 0x068)); // 0x68 OpenSE                      ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.CloseSE                                   = (SoundKey)GetInt32(new IntPtr(p + 0x078)); // 0x78 CloseSE                     ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.IsShowTitleInfoButton                     = GetBool(new IntPtr(p + 0x088)); // 0x88 IsShowTitleInfoButton       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
