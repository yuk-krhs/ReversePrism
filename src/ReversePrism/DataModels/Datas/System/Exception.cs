using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_EDILock                                <object> IL2CPP_TYPE_OBJECT
    // 010 ClassName                                ModelPrimitiveType string string string String
    // 018 Message                                  ModelPrimitiveType string string string String
    // 020 Data                                     ModelClassType IDictionary IDictionary IDictionary Pointer
    // 028 InnerException                           ModelClassType Exception Exception Exception Pointer
    // 030 HelpURL                                  ModelPrimitiveType string string string String
    // 038 _stackTrace                              <object> IL2CPP_TYPE_OBJECT
    // 040 StackTraceString                         ModelPrimitiveType string string string String
    // 048 RemoteStackTraceString                   ModelPrimitiveType string string string String
    // 050 RemoteStackIndex                         ModelPrimitiveType int int int Int32
    // 058 _dynamicMethods                          <object> IL2CPP_TYPE_OBJECT
    // 060 HResult                                  ModelPrimitiveType int int int Int32
    // 068 Source                                   ModelPrimitiveType string string string String
    // 070 SafeSerializationManager                 ModelClassType SafeSerializationManager SafeSerializationManager SafeSerializationManager Pointer
    // 078 Captured_traces                          ModelClassListType StackTrace[] StackTrace[] List<StackTrace> Pointer
    // 080 native_trace_ips                         <int>[] IL2CPP_TYPE_SZARRAY
    // 088 Caught_in_unmanaged                      ModelPrimitiveType int int int Int32
    // 000 _COMPlusExceptionCode                    int IL2CPP_TYPE_I4
    public partial class Exception : DataModel
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
            var value   = new Exception() { Pointer= p0 };

            value.ClassName                                 = GetString(new IntPtr(p + 0x010)); // 0x10 ClassName                   ( ModelPrimitiveType string string string String )
            value.Message                                   = GetString(new IntPtr(p + 0x018)); // 0x18 Message                     ( ModelPrimitiveType string string string String )
            value.Data                                      = GetObject<IDictionary>(new IntPtr(p + 0x020), ReversePrism.DataModels.IDictionary.FromPointer); // 0x20 Data                        ( ModelClassType IDictionary IDictionary IDictionary Pointer )
            value.InnerException                            = GetObject<Exception>(new IntPtr(p + 0x028), ReversePrism.DataModels.Exception.FromPointer); // 0x28 InnerException              ( ModelClassType Exception Exception Exception Pointer )
            value.HelpURL                                   = GetString(new IntPtr(p + 0x030)); // 0x30 HelpURL                     ( ModelPrimitiveType string string string String )
            value.StackTraceString                          = GetString(new IntPtr(p + 0x040)); // 0x40 StackTraceString            ( ModelPrimitiveType string string string String )
            value.RemoteStackTraceString                    = GetString(new IntPtr(p + 0x048)); // 0x48 RemoteStackTraceString      ( ModelPrimitiveType string string string String )
            value.RemoteStackIndex                          = GetInt32(new IntPtr(p + 0x050)); // 0x50 RemoteStackIndex            ( ModelPrimitiveType int int int Int32 )
            value.HResult                                   = GetInt32(new IntPtr(p + 0x060)); // 0x60 HResult                     ( ModelPrimitiveType int int int Int32 )
            value.Source                                    = GetString(new IntPtr(p + 0x068)); // 0x68 Source                      ( ModelPrimitiveType string string string String )
            value.SafeSerializationManager                  = GetObject<SafeSerializationManager>(new IntPtr(p + 0x070), ReversePrism.DataModels.SafeSerializationManager.FromPointer); // 0x70 SafeSerializationManager    ( ModelClassType SafeSerializationManager SafeSerializationManager SafeSerializationManager Pointer )
            value.Captured_traces                           = GetObjectList<StackTrace>(new IntPtr(p + 0x078), ReversePrism.DataModels.StackTrace.FromPointer); // 0x78 Captured_traces             ( ModelClassListType StackTrace[] StackTrace[] List<StackTrace> Pointer )
            value.Caught_in_unmanaged                       = GetInt32(new IntPtr(p + 0x088)); // 0x88 Caught_in_unmanaged         ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
