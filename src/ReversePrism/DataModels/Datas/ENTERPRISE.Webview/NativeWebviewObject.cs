using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OnInitComplete                           0001865F2B40 ModelClassType onInitCompleteDelegate onInitCompleteDelegate onInitCompleteDelegate Pointer
    // 018 OnConsoleMessage                         0001865F2680 ModelClassType onConsoleMessageDelegate onConsoleMessageDelegate onConsoleMessageDelegate Pointer
    // 020 OnLoadResource                           0001865F2FE0 ModelClassType onLoadResourceDelegate onLoadResourceDelegate onLoadResourceDelegate Pointer
    // 028 OnPageStarted                            0001865F3930 ModelClassType onPageStartedDelegate onPageStartedDelegate onPageStartedDelegate Pointer
    // 030 OnPageFinished                           0001865F3450 ModelClassType onPageFinishedDelegate onPageFinishedDelegate onPageFinishedDelegate Pointer
    // 038 OnReceivedError                          0001865F4090 ModelClassType onReceivedErrorDelegate onReceivedErrorDelegate onReceivedErrorDelegate Pointer
    // 000 callFromJS                               callFromJSDelegate IL2CPP_TYPE_CLASS
    // 040 OverrideUrl                              0001865F4530 ModelClassType overrideUrlDelegate overrideUrlDelegate overrideUrlDelegate Pointer
    // 048 Settingparams                            0001867797F0 ModelEnumType Params Params Params Int32
    // 008 webviewobj                               NativeWebviewObject IL2CPP_TYPE_CLASS
    // 049 IsVisibilitylock                         000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class NativeWebviewObject
    {
        public onInitCompleteDelegate?                  OnInitComplete                          { get; set; }
        public onConsoleMessageDelegate?                OnConsoleMessage                        { get; set; }
        public onLoadResourceDelegate?                  OnLoadResource                          { get; set; }
        public onPageStartedDelegate?                   OnPageStarted                           { get; set; }
        public onPageFinishedDelegate?                  OnPageFinished                          { get; set; }
        public onReceivedErrorDelegate?                 OnReceivedError                         { get; set; }
        public overrideUrlDelegate?                     OverrideUrl                             { get; set; }
        public Params                                   Settingparams                           { get; set; }
        public bool                                     IsVisibilitylock                        { get; set; }

        public static NativeWebviewObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeWebviewObject();

            value.OnInitComplete                            = GetObject<onInitCompleteDelegate>(new IntPtr(p + 0x010), ReversePrism.DataModels.onInitCompleteDelegate.FromPointer); // 0270DAFEFCC8 0x10 OnInitComplete              ( 0001865F2B40 ModelClassType onInitCompleteDelegate onInitCompleteDelegate onInitCompleteDelegate Pointer )
            value.OnConsoleMessage                          = GetObject<onConsoleMessageDelegate>(new IntPtr(p + 0x018), ReversePrism.DataModels.onConsoleMessageDelegate.FromPointer); // 0270DAFEFCE8 0x18 OnConsoleMessage            ( 0001865F2680 ModelClassType onConsoleMessageDelegate onConsoleMessageDelegate onConsoleMessageDelegate Pointer )
            value.OnLoadResource                            = GetObject<onLoadResourceDelegate>(new IntPtr(p + 0x020), ReversePrism.DataModels.onLoadResourceDelegate.FromPointer); // 0270DAFEFD08 0x20 OnLoadResource              ( 0001865F2FE0 ModelClassType onLoadResourceDelegate onLoadResourceDelegate onLoadResourceDelegate Pointer )
            value.OnPageStarted                             = GetObject<onPageStartedDelegate>(new IntPtr(p + 0x028), ReversePrism.DataModels.onPageStartedDelegate.FromPointer); // 0270DAFEFD28 0x28 OnPageStarted               ( 0001865F3930 ModelClassType onPageStartedDelegate onPageStartedDelegate onPageStartedDelegate Pointer )
            value.OnPageFinished                            = GetObject<onPageFinishedDelegate>(new IntPtr(p + 0x030), ReversePrism.DataModels.onPageFinishedDelegate.FromPointer); // 0270DAFEFD48 0x30 OnPageFinished              ( 0001865F3450 ModelClassType onPageFinishedDelegate onPageFinishedDelegate onPageFinishedDelegate Pointer )
            value.OnReceivedError                           = GetObject<onReceivedErrorDelegate>(new IntPtr(p + 0x038), ReversePrism.DataModels.onReceivedErrorDelegate.FromPointer); // 0270DAFEFD68 0x38 OnReceivedError             ( 0001865F4090 ModelClassType onReceivedErrorDelegate onReceivedErrorDelegate onReceivedErrorDelegate Pointer )
            value.OverrideUrl                               = GetObject<overrideUrlDelegate>(new IntPtr(p + 0x040), ReversePrism.DataModels.overrideUrlDelegate.FromPointer); // 0270DAFEFDA8 0x40 OverrideUrl                 ( 0001865F4530 ModelClassType overrideUrlDelegate overrideUrlDelegate overrideUrlDelegate Pointer )
            value.Settingparams                             = (Params)GetInt32(new IntPtr(p + 0x048)); // 0270DAFEFDC8 0x48 Settingparams               ( 0001867797F0 ModelEnumType Params Params Params Int32 )
            value.IsVisibilitylock                          = GetBool(new IntPtr(p + 0x049)); // 0270DAFEFE08 0x49 IsVisibilitylock            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
