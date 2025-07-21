using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Request                                  ModelClassType HttpWebRequest HttpWebRequest HttpWebRequest Pointer
    // 018 Connection                               ModelClassType WebConnection WebConnection WebConnection Pointer
    // 020 ServicePoint                             ModelClassType ServicePoint ServicePoint ServicePoint Pointer
    // 028 WriteBuffer                              ModelClassType BufferOffsetSize BufferOffsetSize BufferOffsetSize Pointer
    // 030 IsNtlmChallenge                          ModelPrimitiveType bool bool bool Bool
    // 038 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 040 requestTask                              WebCompletionSource`1<WebRequestStream> IL2CPP_TYPE_GENERICINST
    // 048 requestWrittenTask                       WebCompletionSource`1<WebRequestStream> IL2CPP_TYPE_GENERICINST
    // 050 responseTask                             WebCompletionSource`1<WebResponseStream> IL2CPP_TYPE_GENERICINST
    // 058 finishedTask                             WebCompletionSource`1<ValueTuple`2<bool, WebOperation>> IL2CPP_TYPE_GENERICINST
    // 060 WriteStream                              ModelClassType WebRequestStream WebRequestStream WebRequestStream Pointer
    // 068 ResponseStream                           ModelClassType WebResponseStream WebResponseStream WebResponseStream Pointer
    // 070 DisposedInfo                             ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer
    // 078 ClosedInfo                               ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer
    // 080 PriorityRequest                          ModelClassType WebOperation WebOperation WebOperation Pointer
    // 088 RequestSent                              ModelPrimitiveType int int int Int32
    // 08C Finished                                 ModelPrimitiveType int int int Int32
    public partial class WebOperation : DataModel
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
            var value   = new WebOperation() { Pointer= p0 };

            value.Request                                   = GetObject<HttpWebRequest>(new IntPtr(p + 0x010), ReversePrism.DataModels.HttpWebRequest.FromPointer); // 0x10 Request                     ( ModelClassType HttpWebRequest HttpWebRequest HttpWebRequest Pointer )
            value.Connection                                = GetObject<WebConnection>(new IntPtr(p + 0x018), ReversePrism.DataModels.WebConnection.FromPointer); // 0x18 Connection                  ( ModelClassType WebConnection WebConnection WebConnection Pointer )
            value.ServicePoint                              = GetObject<ServicePoint>(new IntPtr(p + 0x020), ReversePrism.DataModels.ServicePoint.FromPointer); // 0x20 ServicePoint                ( ModelClassType ServicePoint ServicePoint ServicePoint Pointer )
            value.WriteBuffer                               = GetObject<BufferOffsetSize>(new IntPtr(p + 0x028), ReversePrism.DataModels.BufferOffsetSize.FromPointer); // 0x28 WriteBuffer                 ( ModelClassType BufferOffsetSize BufferOffsetSize BufferOffsetSize Pointer )
            value.IsNtlmChallenge                           = GetBool(new IntPtr(p + 0x030)); // 0x30 IsNtlmChallenge             ( ModelPrimitiveType bool bool bool Bool )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x038), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x38 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.WriteStream                               = GetObject<WebRequestStream>(new IntPtr(p + 0x060), ReversePrism.DataModels.WebRequestStream.FromPointer); // 0x60 WriteStream                 ( ModelClassType WebRequestStream WebRequestStream WebRequestStream Pointer )
            value.ResponseStream                            = GetObject<WebResponseStream>(new IntPtr(p + 0x068), ReversePrism.DataModels.WebResponseStream.FromPointer); // 0x68 ResponseStream              ( ModelClassType WebResponseStream WebResponseStream WebResponseStream Pointer )
            value.DisposedInfo                              = GetObject<ExceptionDispatchInfo>(new IntPtr(p + 0x070), ReversePrism.DataModels.ExceptionDispatchInfo.FromPointer); // 0x70 DisposedInfo                ( ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer )
            value.ClosedInfo                                = GetObject<ExceptionDispatchInfo>(new IntPtr(p + 0x078), ReversePrism.DataModels.ExceptionDispatchInfo.FromPointer); // 0x78 ClosedInfo                  ( ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer )
            value.PriorityRequest                           = GetObject<WebOperation>(new IntPtr(p + 0x080), ReversePrism.DataModels.WebOperation.FromPointer); // 0x80 PriorityRequest             ( ModelClassType WebOperation WebOperation WebOperation Pointer )
            value.RequestSent                               = GetInt32(new IntPtr(p + 0x088)); // 0x88 RequestSent                 ( ModelPrimitiveType int int int Int32 )
            value.Finished                                  = GetInt32(new IntPtr(p + 0x08C)); // 0x8C Finished                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
