using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_WebRequestHelper                       00018669BE50 ModelClassType IWebRequestHelper IWebRequestHelper IWebRequestHelper Pointer
    // 018 M_CollectUrl                             000186672F10 ModelPrimitiveType string string string String
    // 000 k_PiplConsentHeaderKey                   string IL2CPP_TYPE_STRING
    // 000 k_PiplExportHeaderKey                    string IL2CPP_TYPE_STRING
    // 000 k_HeaderTrueValue                        string IL2CPP_TYPE_STRING
    // 020 M_DataBuffer                             0001865E17F0 ModelClassType IBuffer IBuffer IBuffer Pointer
    // 028 M_FlushRequest                           00018669B4D0 ModelClassType IWebRequest IWebRequest IWebRequest Pointer
    // 030 ConsecutiveFailedUploadCount             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 FlushInProgress                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 M_FlushBufferIndex                       0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class Dispatcher
    {
        public IWebRequestHelper?                       M_WebRequestHelper                      { get; set; }
        public string                                   M_CollectUrl                            { get; set; }
        public IBuffer?                                 M_DataBuffer                            { get; set; }
        public IWebRequest?                             M_FlushRequest                          { get; set; }
        public int                                      ConsecutiveFailedUploadCount            { get; set; }
        public bool                                     FlushInProgress                         { get; set; }
        public int                                      M_FlushBufferIndex                      { get; set; }

        public static Dispatcher? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Dispatcher();

            value.M_WebRequestHelper                        = GetObject<IWebRequestHelper>(new IntPtr(p + 0x010), ReversePrism.DataModels.IWebRequestHelper.FromPointer); // 0270066C19A0 0x10 M_WebRequestHelper          ( 00018669BE50 ModelClassType IWebRequestHelper IWebRequestHelper IWebRequestHelper Pointer )
            value.M_CollectUrl                              = GetString(new IntPtr(p + 0x018)); // 0270066C19C0 0x18 M_CollectUrl                ( 000186672F10 ModelPrimitiveType string string string String )
            value.M_DataBuffer                              = GetObject<IBuffer>(new IntPtr(p + 0x020), ReversePrism.DataModels.IBuffer.FromPointer); // 0270066C1A40 0x20 M_DataBuffer                ( 0001865E17F0 ModelClassType IBuffer IBuffer IBuffer Pointer )
            value.M_FlushRequest                            = GetObject<IWebRequest>(new IntPtr(p + 0x028), ReversePrism.DataModels.IWebRequest.FromPointer); // 0270066C1A60 0x28 M_FlushRequest              ( 00018669B4D0 ModelClassType IWebRequest IWebRequest IWebRequest Pointer )
            value.ConsecutiveFailedUploadCount              = GetInt32(new IntPtr(p + 0x030)); // 0270066C1A80 0x30 ConsecutiveFailedUploadCount ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FlushInProgress                           = GetBool(new IntPtr(p + 0x034)); // 0270066C1AA0 0x34 FlushInProgress             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_FlushBufferIndex                        = GetInt32(new IntPtr(p + 0x038)); // 0270066C1AC0 0x38 M_FlushBufferIndex          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
