using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 errorInvalidHandle                       string IL2CPP_TYPE_STRING
    // 000 errorInvalidBufferLength                 string IL2CPP_TYPE_STRING
    // 000 errorInvalidNumBuffers                   string IL2CPP_TYPE_STRING
    // 000 errorAlreadyInitialized                  string IL2CPP_TYPE_STRING
    // 000 errorNotInitialized                      string IL2CPP_TYPE_STRING
    // 000 <isInitialized>k__BackingField           bool IL2CPP_TYPE_BOOLEAN
    // 020 handle                                   <int> IL2CPP_TYPE_I
    // 028 bufferPointers                           <int>[] IL2CPP_TYPE_SZARRAY
    // 030 GcHandles                                000185B80720 ModelEnumListType GCHandle[] GCHandle[] List<GCHandle> Pointer
    // 038 OutputWriteStream                        00018664EF10 ModelClassType CriAudioWriteStream CriAudioWriteStream CriAudioWriteStream Pointer
    // 004 _initializationCount                     int IL2CPP_TYPE_I4
    public partial class CriAtomExMic : DataModel
    {
        public List<GCHandle>?                          GcHandles                               { get; set; }
        public CriAudioWriteStream?                     OutputWriteStream                       { get; set; }

        public static CriAtomExMic? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomExMic() { Pointer= p0 };

            value.GcHandles                                 = GetEnumList<GCHandle>(new IntPtr(p + 0x030)); // 02466ACDE568 0x30 GcHandles                   ( 000185B80720 ModelEnumListType GCHandle[] GCHandle[] List<GCHandle> Pointer )
            value.OutputWriteStream                         = GetObject<CriAudioWriteStream>(new IntPtr(p + 0x038), ReversePrism.DataModels.CriAudioWriteStream.FromPointer); // 02466ACDE588 0x38 OutputWriteStream           ( 00018664EF10 ModelClassType CriAudioWriteStream CriAudioWriteStream CriAudioWriteStream Pointer )

            return value;
        }
    }
}
