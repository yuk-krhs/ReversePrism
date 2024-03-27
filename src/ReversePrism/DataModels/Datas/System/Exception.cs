using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_EDILock                                <object> IL2CPP_TYPE_OBJECT
    // 010 ClassName                                000186671910 ModelPrimitiveType string string string String
    // 018 Message                                  000186671BA0 ModelPrimitiveType string string string String
    // 020 Data                                     000186750200 ModelClassType IDictionary IDictionary IDictionary Pointer
    // 028 InnerException                           0001865CA820 ModelClassType Exception Exception Exception Pointer
    // 030 HelpURL                                  000186671910 ModelPrimitiveType string string string String
    // 038 _stackTrace                              <object> IL2CPP_TYPE_OBJECT
    // 040 StackTraceString                         000186671910 ModelPrimitiveType string string string String
    // 048 RemoteStackTraceString                   000186671910 ModelPrimitiveType string string string String
    // 050 RemoteStackIndex                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 058 _dynamicMethods                          <object> IL2CPP_TYPE_OBJECT
    // 060 HResult                                  0001865F2F90 ModelPrimitiveType int int int Int32
    // 068 Source                                   000186671910 ModelPrimitiveType string string string String
    // 070 SafeSerializationManager                 0001866BAC30 ModelClassType SafeSerializationManager SafeSerializationManager SafeSerializationManager Pointer
    // 078 Captured_traces                          000185CA6B98 ModelClassListType StackTrace[] StackTrace[] List<StackTrace> Pointer
    // 080 native_trace_ips                         <int>[] IL2CPP_TYPE_SZARRAY
    // 088 Caught_in_unmanaged                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 _COMPlusExceptionCode                    int IL2CPP_TYPE_I4
    public partial class Exception
    {
        public string                                   ClassName                               { get; set; }
        public string                                   Message                                 { get; set; }
        public IDictionary?                             Data                                    { get; set; }
        public Exception?                               InnerException                          { get; set; }
        public string                                   HelpURL                                 { get; set; }
        public string                                   StackTraceString                        { get; set; }
        public string                                   RemoteStackTraceString                  { get; set; }
        public int                                      RemoteStackIndex                        { get; set; }
        public int                                      HResult                                 { get; set; }
        public string                                   Source                                  { get; set; }
        public SafeSerializationManager?                SafeSerializationManager                { get; set; }
        public List<StackTrace>?                        Captured_traces                         { get; set; }
        public int                                      Caught_in_unmanaged                     { get; set; }

        public static Exception? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Exception();

            value.ClassName                                 = GetString(new IntPtr(p + 0x010)); // 0270024B9020 0x10 ClassName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Message                                   = GetString(new IntPtr(p + 0x018)); // 0270024B9040 0x18 Message                     ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Data                                      = GetObject<IDictionary>(new IntPtr(p + 0x020), ReversePrism.DataModels.IDictionary.FromPointer); // 0270024B9060 0x20 Data                        ( 000186750200 ModelClassType IDictionary IDictionary IDictionary Pointer )
            value.InnerException                            = GetObject<Exception>(new IntPtr(p + 0x028), ReversePrism.DataModels.Exception.FromPointer); // 0270024B9080 0x28 InnerException              ( 0001865CA820 ModelClassType Exception Exception Exception Pointer )
            value.HelpURL                                   = GetString(new IntPtr(p + 0x030)); // 0270024B90A0 0x30 HelpURL                     ( 000186671910 ModelPrimitiveType string string string String )
            value.StackTraceString                          = GetString(new IntPtr(p + 0x040)); // 0270024B90E0 0x40 StackTraceString            ( 000186671910 ModelPrimitiveType string string string String )
            value.RemoteStackTraceString                    = GetString(new IntPtr(p + 0x048)); // 0270024B9100 0x48 RemoteStackTraceString      ( 000186671910 ModelPrimitiveType string string string String )
            value.RemoteStackIndex                          = GetInt32(new IntPtr(p + 0x050)); // 0270024B9120 0x50 RemoteStackIndex            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HResult                                   = GetInt32(new IntPtr(p + 0x060)); // 0270024B9160 0x60 HResult                     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Source                                    = GetString(new IntPtr(p + 0x068)); // 0270024B9180 0x68 Source                      ( 000186671910 ModelPrimitiveType string string string String )
            value.SafeSerializationManager                  = GetObject<SafeSerializationManager>(new IntPtr(p + 0x070), ReversePrism.DataModels.SafeSerializationManager.FromPointer); // 0270024B91A0 0x70 SafeSerializationManager    ( 0001866BAC30 ModelClassType SafeSerializationManager SafeSerializationManager SafeSerializationManager Pointer )
            value.Captured_traces                           = GetObjectList<StackTrace>(new IntPtr(p + 0x078), ReversePrism.DataModels.StackTrace.FromPointer); // 0270024B91C0 0x78 Captured_traces             ( 000185CA6B98 ModelClassListType StackTrace[] StackTrace[] List<StackTrace> Pointer )
            value.Caught_in_unmanaged                       = GetInt32(new IntPtr(p + 0x088)); // 0270024B9200 0x88 Caught_in_unmanaged         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
