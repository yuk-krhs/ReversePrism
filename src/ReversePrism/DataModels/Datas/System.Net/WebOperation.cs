using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Request                                  0001866E5D00 ModelClassType HttpWebRequest HttpWebRequest HttpWebRequest Pointer
    // 018 Connection                               000186548680 ModelClassType WebConnection WebConnection WebConnection Pointer
    // 020 ServicePoint                             000186738E90 ModelClassType ServicePoint ServicePoint ServicePoint Pointer
    // 028 WriteBuffer                              00018650A4A0 ModelClassType BufferOffsetSize BufferOffsetSize BufferOffsetSize Pointer
    // 030 IsNtlmChallenge                          0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 038 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 040 requestTask                              WebCompletionSource`1<WebRequestStream> IL2CPP_TYPE_GENERICINST
    // 048 requestWrittenTask                       WebCompletionSource`1<WebRequestStream> IL2CPP_TYPE_GENERICINST
    // 050 responseTask                             WebCompletionSource`1<WebResponseStream> IL2CPP_TYPE_GENERICINST
    // 058 finishedTask                             WebCompletionSource`1<ValueTuple`2<bool, WebOperation>> IL2CPP_TYPE_GENERICINST
    // 060 WriteStream                              00018654FDC0 ModelClassType WebRequestStream WebRequestStream WebRequestStream Pointer
    // 068 ResponseStream                           000186550F90 ModelClassType WebResponseStream WebResponseStream WebResponseStream Pointer
    // 070 DisposedInfo                             0001865CBD80 ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer
    // 078 ClosedInfo                               0001865CBD80 ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer
    // 080 PriorityRequest                          00018654C440 ModelClassType WebOperation WebOperation WebOperation Pointer
    // 088 RequestSent                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 08C Finished                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class WebOperation
    {
        public HttpWebRequest?                          Request                                 { get; set; }
        public WebConnection?                           Connection                              { get; set; }
        public ServicePoint?                            ServicePoint                            { get; set; }
        public BufferOffsetSize?                        WriteBuffer                             { get; set; }
        public bool                                     IsNtlmChallenge                         { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public WebRequestStream?                        WriteStream                             { get; set; }
        public WebResponseStream?                       ResponseStream                          { get; set; }
        public ExceptionDispatchInfo?                   DisposedInfo                            { get; set; }
        public ExceptionDispatchInfo?                   ClosedInfo                              { get; set; }
        public WebOperation?                            PriorityRequest                         { get; set; }
        public int                                      RequestSent                             { get; set; }
        public int                                      Finished                                { get; set; }

        public static WebOperation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebOperation();

            value.Request                                   = GetObject<HttpWebRequest>(new IntPtr(p + 0x010), ReversePrism.DataModels.HttpWebRequest.FromPointer); // 0270D7A5D160 0x10 Request                     ( 0001866E5D00 ModelClassType HttpWebRequest HttpWebRequest HttpWebRequest Pointer )
            value.Connection                                = GetObject<WebConnection>(new IntPtr(p + 0x018), ReversePrism.DataModels.WebConnection.FromPointer); // 0270D7A5D180 0x18 Connection                  ( 000186548680 ModelClassType WebConnection WebConnection WebConnection Pointer )
            value.ServicePoint                              = GetObject<ServicePoint>(new IntPtr(p + 0x020), ReversePrism.DataModels.ServicePoint.FromPointer); // 0270D7A5D1A0 0x20 ServicePoint                ( 000186738E90 ModelClassType ServicePoint ServicePoint ServicePoint Pointer )
            value.WriteBuffer                               = GetObject<BufferOffsetSize>(new IntPtr(p + 0x028), ReversePrism.DataModels.BufferOffsetSize.FromPointer); // 0270D7A5D1C0 0x28 WriteBuffer                 ( 00018650A4A0 ModelClassType BufferOffsetSize BufferOffsetSize BufferOffsetSize Pointer )
            value.IsNtlmChallenge                           = GetBool(new IntPtr(p + 0x030)); // 0270D7A5D1E0 0x30 IsNtlmChallenge             ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x038), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D7A5D200 0x38 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.WriteStream                               = GetObject<WebRequestStream>(new IntPtr(p + 0x060), ReversePrism.DataModels.WebRequestStream.FromPointer); // 0270D7A5D2A0 0x60 WriteStream                 ( 00018654FDC0 ModelClassType WebRequestStream WebRequestStream WebRequestStream Pointer )
            value.ResponseStream                            = GetObject<WebResponseStream>(new IntPtr(p + 0x068), ReversePrism.DataModels.WebResponseStream.FromPointer); // 0270D7A5D2C0 0x68 ResponseStream              ( 000186550F90 ModelClassType WebResponseStream WebResponseStream WebResponseStream Pointer )
            value.DisposedInfo                              = GetObject<ExceptionDispatchInfo>(new IntPtr(p + 0x070), ReversePrism.DataModels.ExceptionDispatchInfo.FromPointer); // 0270D7A5D2E0 0x70 DisposedInfo                ( 0001865CBD80 ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer )
            value.ClosedInfo                                = GetObject<ExceptionDispatchInfo>(new IntPtr(p + 0x078), ReversePrism.DataModels.ExceptionDispatchInfo.FromPointer); // 0270D7A5D300 0x78 ClosedInfo                  ( 0001865CBD80 ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer )
            value.PriorityRequest                           = GetObject<WebOperation>(new IntPtr(p + 0x080), ReversePrism.DataModels.WebOperation.FromPointer); // 0270D7A5D320 0x80 PriorityRequest             ( 00018654C440 ModelClassType WebOperation WebOperation WebOperation Pointer )
            value.RequestSent                               = GetInt32(new IntPtr(p + 0x088)); // 0270D7A5D340 0x88 RequestSent                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Finished                                  = GetInt32(new IntPtr(p + 0x08C)); // 0270D7A5D360 0x8C Finished                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
