using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 EnableDebugPrintOnTerminal               000186595960 ModelPrimitiveType bool bool bool Bool
    // 031 EnableForceCrashOnError                  000186595960 ModelPrimitiveType bool bool bool Bool
    // 032 DontDestroyOnLoad                        000186595960 ModelPrimitiveType bool bool bool Bool
    // 000 <errorMessage>k__BackingField            string IL2CPP_TYPE_STRING
    // 008 logPrefix                                string IL2CPP_TYPE_STRING
    // 010 OnCallback                               000186565A80 ModelClassType Callback Callback Callback Pointer
    // 018 Callback                                 000186565CE0 ModelClassType Callback Callback Callback Pointer
    // 034 MessageBufferCounts                      0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 038 unThreadSafeMessages                     ConcurrentQueue`1<string> IL2CPP_TYPE_GENERICINST
    // 020 InitializationCount                      0001865F38E0 ModelPrimitiveType int int int Int32
    public partial class CriWareErrorHandler
    {
        public bool                                     EnableDebugPrintOnTerminal              { get; set; }
        public bool                                     EnableForceCrashOnError                 { get; set; }
        public bool                                     DontDestroyOnLoad                       { get; set; }
        public Callback?                                OnCallback                              { get; set; }
        public Callback?                                Callback                                { get; set; }
        public uint                                     MessageBufferCounts                     { get; set; }
        public int                                      InitializationCount                     { get; set; }

        public static CriWareErrorHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriWareErrorHandler();

            value.EnableDebugPrintOnTerminal                = GetBool(new IntPtr(p + 0x030)); // 0270DACBE148 0x30 EnableDebugPrintOnTerminal  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.EnableForceCrashOnError                   = GetBool(new IntPtr(p + 0x031)); // 0270DACBE168 0x31 EnableForceCrashOnError     ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DontDestroyOnLoad                         = GetBool(new IntPtr(p + 0x032)); // 0270DACBE188 0x32 DontDestroyOnLoad           ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.OnCallback                                = GetObject<Callback>(new IntPtr(p + 0x010), ReversePrism.DataModels.Callback.FromPointer); // 0270DACBE1E8 0x10 OnCallback                  ( 000186565A80 ModelClassType Callback Callback Callback Pointer )
            value.Callback                                  = GetObject<Callback>(new IntPtr(p + 0x018), ReversePrism.DataModels.Callback.FromPointer); // 0270DACBE208 0x18 Callback                    ( 000186565CE0 ModelClassType Callback Callback Callback Pointer )
            value.MessageBufferCounts                       = GetUInt32(new IntPtr(p + 0x034)); // 0270DACBE228 0x34 MessageBufferCounts         ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.InitializationCount                       = GetInt32(new IntPtr(p + 0x020)); // 0270DACBE268 0x20 InitializationCount         ( 0001865F38E0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
