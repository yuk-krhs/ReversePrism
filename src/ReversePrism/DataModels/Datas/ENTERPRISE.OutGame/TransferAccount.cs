using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DataTransferContent                      000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 028 TransferCheckContent                     000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 030 TransferStopPopupCaller                  0001866A89D0 ModelClassType TransferStopPopupCaller TransferStopPopupCaller TransferStopPopupCaller Pointer
    // 038 TransferInputCodeContent                 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 040 WebViewContentPrefab                     000186552FE0 ModelClassType WebviewContent WebviewContent WebviewContent Pointer
    // 048 ReleasableDate                           000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 058 TakeOverScheme                           000186671910 ModelPrimitiveType string string string String
    // 060 TakeOverUrl                              000186671910 ModelPrimitiveType string string string String
    // 068 IsTakeOverDone                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 06C ConnectionResult                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 070 IsConnectionLogin                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 078 PassPhrase                               000186671910 ModelPrimitiveType string string string String
    // 000 otherReleasableDate                      Nullable`1<DateTime> IL2CPP_TYPE_GENERICINST
    public partial class TransferAccount
    {
        public PopupContentBase?                        DataTransferContent                     { get; set; }
        public PopupContentBase?                        TransferCheckContent                    { get; set; }
        public TransferStopPopupCaller?                 TransferStopPopupCaller                 { get; set; }
        public PopupContentBase?                        TransferInputCodeContent                { get; set; }
        public WebviewContent?                          WebViewContentPrefab                    { get; set; }
        public DateTime                                 ReleasableDate                          { get; set; }
        public string                                   TakeOverScheme                          { get; set; }
        public string                                   TakeOverUrl                             { get; set; }
        public bool                                     IsTakeOverDone                          { get; set; }
        public int                                      ConnectionResult                        { get; set; }
        public bool                                     IsConnectionLogin                       { get; set; }
        public string                                   PassPhrase                              { get; set; }

        public static TransferAccount? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransferAccount();

            value.DataTransferContent                       = GetObject<PopupContentBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0270043753E8 0x20 DataTransferContent         ( 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.TransferCheckContent                      = GetObject<PopupContentBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.PopupContentBase.FromPointer); // 027004375408 0x28 TransferCheckContent        ( 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.TransferStopPopupCaller                   = GetObject<TransferStopPopupCaller>(new IntPtr(p + 0x030), ReversePrism.DataModels.TransferStopPopupCaller.FromPointer); // 027004375428 0x30 TransferStopPopupCaller     ( 0001866A89D0 ModelClassType TransferStopPopupCaller TransferStopPopupCaller TransferStopPopupCaller Pointer )
            value.TransferInputCodeContent                  = GetObject<PopupContentBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.PopupContentBase.FromPointer); // 027004375448 0x38 TransferInputCodeContent    ( 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.WebViewContentPrefab                      = GetObject<WebviewContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.WebviewContent.FromPointer); // 027004375468 0x40 WebViewContentPrefab        ( 000186552FE0 ModelClassType WebviewContent WebviewContent WebviewContent Pointer )
            value.ReleasableDate                            = GetDateTime(new IntPtr(p + 0x048)); // 027004375488 0x48 ReleasableDate              ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.TakeOverScheme                            = GetString(new IntPtr(p + 0x058)); // 0270043754A8 0x58 TakeOverScheme              ( 000186671910 ModelPrimitiveType string string string String )
            value.TakeOverUrl                               = GetString(new IntPtr(p + 0x060)); // 0270043754C8 0x60 TakeOverUrl                 ( 000186671910 ModelPrimitiveType string string string String )
            value.IsTakeOverDone                            = GetBool(new IntPtr(p + 0x068)); // 0270043754E8 0x68 IsTakeOverDone              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ConnectionResult                          = GetInt32(new IntPtr(p + 0x06C)); // 027004375508 0x6C ConnectionResult            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsConnectionLogin                         = GetBool(new IntPtr(p + 0x070)); // 027004375528 0x70 IsConnectionLogin           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PassPhrase                                = GetString(new IntPtr(p + 0x078)); // 027004375548 0x78 PassPhrase                  ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
