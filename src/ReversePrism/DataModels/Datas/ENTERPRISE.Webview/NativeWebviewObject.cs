using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OnInitComplete                           ModelClassType onInitCompleteDelegate onInitCompleteDelegate onInitCompleteDelegate Pointer
    // 018 OnConsoleMessage                         ModelClassType onConsoleMessageDelegate onConsoleMessageDelegate onConsoleMessageDelegate Pointer
    // 020 OnLoadResource                           ModelClassType onLoadResourceDelegate onLoadResourceDelegate onLoadResourceDelegate Pointer
    // 028 OnPageStarted                            ModelClassType onPageStartedDelegate onPageStartedDelegate onPageStartedDelegate Pointer
    // 030 OnPageFinished                           ModelClassType onPageFinishedDelegate onPageFinishedDelegate onPageFinishedDelegate Pointer
    // 038 OnReceivedError                          ModelClassType onReceivedErrorDelegate onReceivedErrorDelegate onReceivedErrorDelegate Pointer
    // 000 callFromJS                               callFromJSDelegate IL2CPP_TYPE_CLASS
    // 040 OverrideUrl                              ModelClassType overrideUrlDelegate overrideUrlDelegate overrideUrlDelegate Pointer
    // 048 Settingparams                            ModelEnumType Params Params Params Int32
    // 008 webviewobj                               NativeWebviewObject IL2CPP_TYPE_CLASS
    // 049 IsVisibilitylock                         ModelPrimitiveType bool bool bool Bool
    public partial class NativeWebviewObject : DataModel
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
            var value   = new NativeWebviewObject() { Pointer= p0 };

            value.OnInitComplete                            = GetObject<onInitCompleteDelegate>(new IntPtr(p + 0x010), ReversePrism.DataModels.onInitCompleteDelegate.FromPointer); // 0x10 OnInitComplete              ( ModelClassType onInitCompleteDelegate onInitCompleteDelegate onInitCompleteDelegate Pointer )
            value.OnConsoleMessage                          = GetObject<onConsoleMessageDelegate>(new IntPtr(p + 0x018), ReversePrism.DataModels.onConsoleMessageDelegate.FromPointer); // 0x18 OnConsoleMessage            ( ModelClassType onConsoleMessageDelegate onConsoleMessageDelegate onConsoleMessageDelegate Pointer )
            value.OnLoadResource                            = GetObject<onLoadResourceDelegate>(new IntPtr(p + 0x020), ReversePrism.DataModels.onLoadResourceDelegate.FromPointer); // 0x20 OnLoadResource              ( ModelClassType onLoadResourceDelegate onLoadResourceDelegate onLoadResourceDelegate Pointer )
            value.OnPageStarted                             = GetObject<onPageStartedDelegate>(new IntPtr(p + 0x028), ReversePrism.DataModels.onPageStartedDelegate.FromPointer); // 0x28 OnPageStarted               ( ModelClassType onPageStartedDelegate onPageStartedDelegate onPageStartedDelegate Pointer )
            value.OnPageFinished                            = GetObject<onPageFinishedDelegate>(new IntPtr(p + 0x030), ReversePrism.DataModels.onPageFinishedDelegate.FromPointer); // 0x30 OnPageFinished              ( ModelClassType onPageFinishedDelegate onPageFinishedDelegate onPageFinishedDelegate Pointer )
            value.OnReceivedError                           = GetObject<onReceivedErrorDelegate>(new IntPtr(p + 0x038), ReversePrism.DataModels.onReceivedErrorDelegate.FromPointer); // 0x38 OnReceivedError             ( ModelClassType onReceivedErrorDelegate onReceivedErrorDelegate onReceivedErrorDelegate Pointer )
            value.OverrideUrl                               = GetObject<overrideUrlDelegate>(new IntPtr(p + 0x040), ReversePrism.DataModels.overrideUrlDelegate.FromPointer); // 0x40 OverrideUrl                 ( ModelClassType overrideUrlDelegate overrideUrlDelegate overrideUrlDelegate Pointer )
            value.Settingparams                             = (Params)GetInt32(new IntPtr(p + 0x048)); // 0x48 Settingparams               ( ModelEnumType Params Params Params Int32 )
            value.IsVisibilitylock                          = GetBool(new IntPtr(p + 0x049)); // 0x49 IsVisibilitylock            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
