using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MaximumSpectrumBands                     int IL2CPP_TYPE_I4
    // 020 handle                                   <int> IL2CPP_TYPE_I
    // 028 Player                                   0001866490B0 ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer
    // 030 BusName                                  000186671E00 ModelPrimitiveType string string string String
    // 038 NumBands                                 0001865F3220 ModelPrimitiveType int int int Int32
    // 03C NumCapturedPcmSamples                    0001865F3220 ModelPrimitiveType int int int Int32
    // 040 UserPcmCaptureCallback                   00018654E4D0 ModelClassType PcmCaptureCallback PcmCaptureCallback PcmCaptureCallback Pointer
    // 048 DataL                                    000185B80850 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 050 DataR                                    000185B80850 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 000 pcmCapturerNumMaxData                    int IL2CPP_TYPE_I4
    // 000 InternalCallbackFunctionPointer          <int> IL2CPP_TYPE_I
    // 008 DelegateObject                           InternalPcmCaptureCallback IL2CPP_TYPE_CLASS
    // 010 DataL                                    000185B80B40 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 018 DataR                                    000185B80B40 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 020 UserPcmCaptureCallback                   00018654E790 ModelClassType PcmCaptureCallback PcmCaptureCallback PcmCaptureCallback Pointer
    public partial class CriAtomExOutputAnalyzer : DataModel
    {
        public CriAtomExPlayer?                         Player                                  { get; set; }
        public string                                   BusName                                 { get; set; }
        public int                                      NumBands                                { get; set; }
        public int                                      NumCapturedPcmSamples                   { get; set; }
        public PcmCaptureCallback?                      UserPcmCaptureCallback                  { get; set; }
        public List<float>?                             DataL                                   { get; set; }
        public List<float>?                             DataR                                   { get; set; }

        public static CriAtomExOutputAnalyzer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomExOutputAnalyzer() { Pointer= p0 };

            value.Player                                    = GetObject<CriAtomExPlayer>(new IntPtr(p + 0x028), ReversePrism.DataModels.CriAtomExPlayer.FromPointer); // 024661812B98 0x28 Player                      ( 0001866490B0 ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer )
            value.BusName                                   = GetString(new IntPtr(p + 0x030)); // 024661812BB8 0x30 BusName                     ( 000186671E00 ModelPrimitiveType string string string String )
            value.NumBands                                  = GetInt32(new IntPtr(p + 0x038)); // 024661812BD8 0x38 NumBands                    ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.NumCapturedPcmSamples                     = GetInt32(new IntPtr(p + 0x03C)); // 024661812BF8 0x3C NumCapturedPcmSamples       ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.UserPcmCaptureCallback                    = GetObject<PcmCaptureCallback>(new IntPtr(p + 0x020), ReversePrism.DataModels.PcmCaptureCallback.FromPointer); // 024661812D18 0x20 UserPcmCaptureCallback      ( 00018654E790 ModelClassType PcmCaptureCallback PcmCaptureCallback PcmCaptureCallback Pointer )
            value.DataL                                     = GetSingleList(new IntPtr(p + 0x010)); // 024661812CD8 0x10 DataL                       ( 000185B80B40 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.DataR                                     = GetSingleList(new IntPtr(p + 0x018)); // 024661812CF8 0x18 DataR                       ( 000185B80B40 ModelPrimitiveListType float[] float[] List<float> Pointer )

            return value;
        }
    }
}
