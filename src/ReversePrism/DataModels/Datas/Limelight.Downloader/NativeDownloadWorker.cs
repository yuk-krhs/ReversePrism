using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Quit                                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 Channel                                  0001866EFB30 ModelClassType DownloadCommandChannel DownloadCommandChannel DownloadCommandChannel Pointer
    // 020 SharedCommand                            0001867523A0 ModelClassType SharedDownloadStateCommand SharedDownloadStateCommand SharedDownloadStateCommand Pointer
    // 028 WorkerState                              0001866872A0 ModelClassType NativeDownloadWorkerState NativeDownloadWorkerState NativeDownloadWorkerState Pointer
    // 030 Pause                                    00018672B2C0 ModelClassType PauseController PauseController PauseController Pointer
    // 038 Api                                      000186685A40 ModelClassType NativeDownloadApi NativeDownloadApi NativeDownloadApi Pointer
    // 040 WorkerThread                             000186688A80 ModelClassType Thread Thread Thread Pointer
    // 048 IsDequeingCommand                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 TotalDownloadBytes                       0001865F7700 ModelPrimitiveType long long long Int64
    // 058 DownloadedBytes                          0001865F7700 ModelPrimitiveType long long long Int64
    public partial class NativeDownloadWorker : DataModel
    {
        public bool                                     Quit                                    { get; set; }
        public DownloadCommandChannel?                  Channel                                 { get; set; }
        public SharedDownloadStateCommand?              SharedCommand                           { get; set; }
        public NativeDownloadWorkerState?               WorkerState                             { get; set; }
        public PauseController?                         Pause                                   { get; set; }
        public NativeDownloadApi?                       Api                                     { get; set; }
        public Thread?                                  WorkerThread                            { get; set; }
        public bool                                     IsDequeingCommand                       { get; set; }
        public long                                     TotalDownloadBytes                      { get; set; }
        public long                                     DownloadedBytes                         { get; set; }

        public static NativeDownloadWorker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeDownloadWorker() { Pointer= p0 };

            value.Quit                                      = GetBool(new IntPtr(p + 0x010)); // 0245A3E284E0 0x10 Quit                        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Channel                                   = GetObject<DownloadCommandChannel>(new IntPtr(p + 0x018), ReversePrism.DataModels.DownloadCommandChannel.FromPointer); // 0245A3E28500 0x18 Channel                     ( 0001866EFB30 ModelClassType DownloadCommandChannel DownloadCommandChannel DownloadCommandChannel Pointer )
            value.SharedCommand                             = GetObject<SharedDownloadStateCommand>(new IntPtr(p + 0x020), ReversePrism.DataModels.SharedDownloadStateCommand.FromPointer); // 0245A3E28520 0x20 SharedCommand               ( 0001867523A0 ModelClassType SharedDownloadStateCommand SharedDownloadStateCommand SharedDownloadStateCommand Pointer )
            value.WorkerState                               = GetObject<NativeDownloadWorkerState>(new IntPtr(p + 0x028), ReversePrism.DataModels.NativeDownloadWorkerState.FromPointer); // 0245A3E28540 0x28 WorkerState                 ( 0001866872A0 ModelClassType NativeDownloadWorkerState NativeDownloadWorkerState NativeDownloadWorkerState Pointer )
            value.Pause                                     = GetObject<PauseController>(new IntPtr(p + 0x030), ReversePrism.DataModels.PauseController.FromPointer); // 0245A3E28560 0x30 Pause                       ( 00018672B2C0 ModelClassType PauseController PauseController PauseController Pointer )
            value.Api                                       = GetObject<NativeDownloadApi>(new IntPtr(p + 0x038), ReversePrism.DataModels.NativeDownloadApi.FromPointer); // 0245A3E28580 0x38 Api                         ( 000186685A40 ModelClassType NativeDownloadApi NativeDownloadApi NativeDownloadApi Pointer )
            value.WorkerThread                              = GetObject<Thread>(new IntPtr(p + 0x040), ReversePrism.DataModels.Thread.FromPointer); // 0245A3E285A0 0x40 WorkerThread                ( 000186688A80 ModelClassType Thread Thread Thread Pointer )
            value.IsDequeingCommand                         = GetBool(new IntPtr(p + 0x048)); // 0245A3E285C0 0x48 IsDequeingCommand           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TotalDownloadBytes                        = GetInt64(new IntPtr(p + 0x050)); // 0245A3E285E0 0x50 TotalDownloadBytes          ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.DownloadedBytes                           = GetInt64(new IntPtr(p + 0x058)); // 0245A3E28600 0x58 DownloadedBytes             ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
