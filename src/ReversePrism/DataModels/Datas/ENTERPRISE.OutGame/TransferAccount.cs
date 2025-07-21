using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DataTransferContent                      ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 028 TransferCheckContent                     ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 030 TransferStopPopupCaller                  ModelClassType TransferStopPopupCaller TransferStopPopupCaller TransferStopPopupCaller Pointer
    // 038 TransferInputCodeContent                 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 040 WebViewContentPrefab                     ModelClassType WebviewContent WebviewContent WebviewContent Pointer
    // 048 ReleasableDate                           ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 058 TakeOverScheme                           ModelPrimitiveType string string string String
    // 060 TakeOverUrl                              ModelPrimitiveType string string string String
    // 068 IsTakeOverDone                           ModelPrimitiveType bool bool bool Bool
    // 06C ConnectionResult                         ModelPrimitiveType int int int Int32
    // 070 IsConnectionLogin                        ModelPrimitiveType bool bool bool Bool
    // 078 PassPhrase                               ModelPrimitiveType string string string String
    // 000 otherReleasableDate                      Nullable`1<DateTime> IL2CPP_TYPE_GENERICINST
    public partial class TransferAccount : DataModel
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
            var value   = new TransferAccount() { Pointer= p0 };

            value.DataTransferContent                       = GetObject<PopupContentBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0x20 DataTransferContent         ( ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.TransferCheckContent                      = GetObject<PopupContentBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0x28 TransferCheckContent        ( ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.TransferStopPopupCaller                   = GetObject<TransferStopPopupCaller>(new IntPtr(p + 0x030), ReversePrism.DataModels.TransferStopPopupCaller.FromPointer); // 0x30 TransferStopPopupCaller     ( ModelClassType TransferStopPopupCaller TransferStopPopupCaller TransferStopPopupCaller Pointer )
            value.TransferInputCodeContent                  = GetObject<PopupContentBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0x38 TransferInputCodeContent    ( ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.WebViewContentPrefab                      = GetObject<WebviewContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.WebviewContent.FromPointer); // 0x40 WebViewContentPrefab        ( ModelClassType WebviewContent WebviewContent WebviewContent Pointer )
            value.ReleasableDate                            = GetDateTime(new IntPtr(p + 0x048)); // 0x48 ReleasableDate              ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.TakeOverScheme                            = GetString(new IntPtr(p + 0x058)); // 0x58 TakeOverScheme              ( ModelPrimitiveType string string string String )
            value.TakeOverUrl                               = GetString(new IntPtr(p + 0x060)); // 0x60 TakeOverUrl                 ( ModelPrimitiveType string string string String )
            value.IsTakeOverDone                            = GetBool(new IntPtr(p + 0x068)); // 0x68 IsTakeOverDone              ( ModelPrimitiveType bool bool bool Bool )
            value.ConnectionResult                          = GetInt32(new IntPtr(p + 0x06C)); // 0x6C ConnectionResult            ( ModelPrimitiveType int int int Int32 )
            value.IsConnectionLogin                         = GetBool(new IntPtr(p + 0x070)); // 0x70 IsConnectionLogin           ( ModelPrimitiveType bool bool bool Bool )
            value.PassPhrase                                = GetString(new IntPtr(p + 0x078)); // 0x78 PassPhrase                  ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
