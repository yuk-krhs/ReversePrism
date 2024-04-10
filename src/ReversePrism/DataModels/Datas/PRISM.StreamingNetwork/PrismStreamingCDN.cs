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
    // 040 IndexUrl                                 000186671910 ModelPrimitiveType string string string String
    // 048 IsLive                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 Chunk                                    000185CD00F8 ModelClassListType RepeatedField`1<ByteString> RepeatedField`1<ByteString> List<ByteString> Pointer
    // 058 dataQueue                                Queue`1<sbyte[]> IL2CPP_TYPE_GENERICINST
    // 060 readedObjectGuids                        HashSet`1<string> IL2CPP_TYPE_GENERICINST
    // 068 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 070 ReadUrlList                              000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 078 CurrentReadIndex                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 07C IsError                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 07D IsPaused                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 07E IsChangeTime                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 07F UseThreadPool                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 080 IsDisposed                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 081 IsSetReconnectingEvent                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 088 BeginDate                                000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 098 SoundView                                000186538FC0 ModelClassType SoundView SoundView SoundView Pointer
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

        public static PrismStreamingCDN? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrismStreamingCDN() { Pointer= p0 };

            value.IndexUrl                                  = GetString(new IntPtr(p + 0x040)); // 024664F8D4E8 0x40 IndexUrl                    ( 000186671910 ModelPrimitiveType string string string String )
            value.IsLive                                    = GetBool(new IntPtr(p + 0x048)); // 024664F8D508 0x48 IsLive                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Chunk                                     = GetObjectList<ByteString>(new IntPtr(p + 0x050), ReversePrism.DataModels.ByteString.FromPointer); // 024664F8D528 0x50 Chunk                       ( 000185CD00F8 ModelClassListType RepeatedField`1<ByteString> RepeatedField`1<ByteString> List<ByteString> Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x068), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 024664F8D588 0x68 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.ReadUrlList                               = GetStringList(new IntPtr(p + 0x070)); // 024664F8D5A8 0x70 ReadUrlList                 ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.CurrentReadIndex                          = GetInt32(new IntPtr(p + 0x078)); // 024664F8D5C8 0x78 CurrentReadIndex            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsError                                   = GetBool(new IntPtr(p + 0x07C)); // 024664F8D5E8 0x7C IsError                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsPaused                                  = GetBool(new IntPtr(p + 0x07D)); // 024664F8D608 0x7D IsPaused                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsChangeTime                              = GetBool(new IntPtr(p + 0x07E)); // 024664F8D628 0x7E IsChangeTime                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UseThreadPool                             = GetBool(new IntPtr(p + 0x07F)); // 024664F8D648 0x7F UseThreadPool               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsDisposed                                = GetBool(new IntPtr(p + 0x080)); // 024664F8D668 0x80 IsDisposed                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsSetReconnectingEvent                    = GetBool(new IntPtr(p + 0x081)); // 024664F8D688 0x81 IsSetReconnectingEvent      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x088)); // 024664F8D6A8 0x88 BeginDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.SoundView                                 = GetObject<SoundView>(new IntPtr(p + 0x098), ReversePrism.DataModels.SoundView.FromPointer); // 024664F8D6C8 0x98 SoundView                   ( 000186538FC0 ModelClassType SoundView SoundView SoundView Pointer )

            return value;
        }
    }
}
