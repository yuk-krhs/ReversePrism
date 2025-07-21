using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MaxReadCount                             int IL2CPP_TYPE_I4
    // 000 WaitDelayTime                            int IL2CPP_TYPE_I4
    // 040 IndexUrl                                 ModelPrimitiveType string string string String
    // 048 IsLive                                   ModelPrimitiveType bool bool bool Bool
    // 050 Chunk                                    ModelClassListType RepeatedField`1<ByteString> RepeatedField`1<ByteString> List<ByteString> Pointer
    // 058 dataQueue                                Queue`1<sbyte[]> IL2CPP_TYPE_GENERICINST
    // 060 readedObjectGuids                        HashSet`1<string> IL2CPP_TYPE_GENERICINST
    // 068 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 070 ReadUrlList                              ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 078 CurrentReadIndex                         ModelPrimitiveType int int int Int32
    // 07C IsError                                  ModelPrimitiveType bool bool bool Bool
    // 07D IsPaused                                 ModelPrimitiveType bool bool bool Bool
    // 07E IsChangeTime                             ModelPrimitiveType bool bool bool Bool
    // 07F UseThreadPool                            ModelPrimitiveType bool bool bool Bool
    // 080 IsDisposed                               ModelPrimitiveType bool bool bool Bool
    // 081 IsSetReconnectingEvent                   ModelPrimitiveType bool bool bool Bool
    // 088 BeginDate                                ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 098 SoundView                                ModelClassType SoundView SoundView SoundView Pointer
    // 0A0 WebClient                                ModelClassType WebClient WebClient WebClient Pointer
    public partial class PrismStreamingCDN : DataModel
    {
        public string                                   IndexUrl                                { get; set; }
        public bool                                     IsLive                                  { get; set; }
        public List<ByteString>?                        Chunk                                   { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public List<string>?                            ReadUrlList                             { get; set; }
        public int                                      CurrentReadIndex                        { get; set; }
        public bool                                     IsError                                 { get; set; }
        public bool                                     IsPaused                                { get; set; }
        public bool                                     IsChangeTime                            { get; set; }
        public bool                                     UseThreadPool                           { get; set; }
        public bool                                     IsDisposed                              { get; set; }
        public bool                                     IsSetReconnectingEvent                  { get; set; }
        public DateTime                                 BeginDate                               { get; set; }
        public SoundView?                               SoundView                               { get; set; }
        public WebClient?                               WebClient                               { get; set; }

        public static PrismStreamingCDN? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrismStreamingCDN() { Pointer= p0 };

            value.IndexUrl                                  = GetString(new IntPtr(p + 0x040)); // 0x40 IndexUrl                    ( ModelPrimitiveType string string string String )
            value.IsLive                                    = GetBool(new IntPtr(p + 0x048)); // 0x48 IsLive                      ( ModelPrimitiveType bool bool bool Bool )
            value.Chunk                                     = GetObjectList<ByteString>(new IntPtr(p + 0x050), ReversePrism.DataModels.ByteString.FromPointer); // 0x50 Chunk                       ( ModelClassListType RepeatedField`1<ByteString> RepeatedField`1<ByteString> List<ByteString> Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x068), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x68 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.ReadUrlList                               = GetStringList(new IntPtr(p + 0x070)); // 0x70 ReadUrlList                 ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.CurrentReadIndex                          = GetInt32(new IntPtr(p + 0x078)); // 0x78 CurrentReadIndex            ( ModelPrimitiveType int int int Int32 )
            value.IsError                                   = GetBool(new IntPtr(p + 0x07C)); // 0x7C IsError                     ( ModelPrimitiveType bool bool bool Bool )
            value.IsPaused                                  = GetBool(new IntPtr(p + 0x07D)); // 0x7D IsPaused                    ( ModelPrimitiveType bool bool bool Bool )
            value.IsChangeTime                              = GetBool(new IntPtr(p + 0x07E)); // 0x7E IsChangeTime                ( ModelPrimitiveType bool bool bool Bool )
            value.UseThreadPool                             = GetBool(new IntPtr(p + 0x07F)); // 0x7F UseThreadPool               ( ModelPrimitiveType bool bool bool Bool )
            value.IsDisposed                                = GetBool(new IntPtr(p + 0x080)); // 0x80 IsDisposed                  ( ModelPrimitiveType bool bool bool Bool )
            value.IsSetReconnectingEvent                    = GetBool(new IntPtr(p + 0x081)); // 0x81 IsSetReconnectingEvent      ( ModelPrimitiveType bool bool bool Bool )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x088)); // 0x88 BeginDate                   ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.SoundView                                 = GetObject<SoundView>(new IntPtr(p + 0x098), ReversePrism.DataModels.SoundView.FromPointer); // 0x98 SoundView                   ( ModelClassType SoundView SoundView SoundView Pointer )
            value.WebClient                                 = GetObject<WebClient>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.WebClient.FromPointer); // 0xA0 WebClient                   ( ModelClassType WebClient WebClient WebClient Pointer )

            return value;
        }
    }
}
