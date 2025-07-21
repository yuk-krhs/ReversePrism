using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 HaveProcessId                            ModelPrimitiveType bool bool bool Bool
    // 02C ProcessId                                ModelPrimitiveType int int int Int32
    // 030 HaveProcessHandle                        ModelPrimitiveType bool bool bool Bool
    // 038 M_processHandle                          ModelClassType SafeProcessHandle SafeProcessHandle SafeProcessHandle Pointer
    // 040 IsRemoteMachine                          ModelPrimitiveType bool bool bool Bool
    // 048 MachineName                              ModelPrimitiveType string string string String
    // 050 M_processAccess                          ModelPrimitiveType int int int Int32
    // 058 Threads                                  ModelClassType ProcessThreadCollection ProcessThreadCollection ProcessThreadCollection Pointer
    // 060 Modules                                  ModelClassType ProcessModuleCollection ProcessModuleCollection ProcessModuleCollection Pointer
    // 068 HaveWorkingSetLimits                     ModelPrimitiveType bool bool bool Bool
    // 069 HavePriorityClass                        ModelPrimitiveType bool bool bool Bool
    // 06A WatchForExit                             ModelPrimitiveType bool bool bool Bool
    // 06B WatchingForExit                          ModelPrimitiveType bool bool bool Bool
    // 070 OnExited                                 ModelClassType EventHandler EventHandler EventHandler Pointer
    // 078 Exited                                   ModelPrimitiveType bool bool bool Bool
    // 07C ExitCode                                 ModelPrimitiveType int int int Int32
    // 080 Signaled                                 ModelPrimitiveType bool bool bool Bool
    // 081 HaveExitTime                             ModelPrimitiveType bool bool bool Bool
    // 082 RaisedOnExited                           ModelPrimitiveType bool bool bool Bool
    // 088 RegisteredWaitHandle                     ModelClassType RegisteredWaitHandle RegisteredWaitHandle RegisteredWaitHandle Pointer
    // 090 WaitHandle                               ModelClassType WaitHandle WaitHandle WaitHandle Pointer
    // 098 SynchronizingObject                      ModelClassType ISynchronizeInvoke ISynchronizeInvoke ISynchronizeInvoke Pointer
    // 0A0 StandardOutput                           ModelClassType StreamReader StreamReader StreamReader Pointer
    // 0A8 StandardInput                            ModelClassType StreamWriter StreamWriter StreamWriter Pointer
    // 0B0 StandardError                            ModelClassType StreamReader StreamReader StreamReader Pointer
    // 0B8 Disposed                                 ModelPrimitiveType bool bool bool Bool
    // 0BC OutputStreamReadMode                     ModelEnumType StreamReadMode StreamReadMode StreamReadMode Int32
    // 0C0 ErrorStreamReadMode                      ModelEnumType StreamReadMode StreamReadMode StreamReadMode Int32
    // 0C4 InputStreamReadMode                      ModelEnumType StreamReadMode StreamReadMode StreamReadMode Int32
    // 0C8 Output                                   ModelClassType AsyncStreamReader AsyncStreamReader AsyncStreamReader Pointer
    // 0D0 Error                                    ModelClassType AsyncStreamReader AsyncStreamReader AsyncStreamReader Pointer
    // 0D8 Process_name                             ModelPrimitiveType string string string String
    public partial class Process : DataModel
    {
        public bool                                     HaveProcessId                           { get; set; }
        public int                                      ProcessId                               { get; set; }
        public bool                                     HaveProcessHandle                       { get; set; }
        public SafeProcessHandle?                       M_processHandle                         { get; set; }
        public bool                                     IsRemoteMachine                         { get; set; }
        public string                                   MachineName                             { get; set; }
        public int                                      M_processAccess                         { get; set; }
        public ProcessThreadCollection?                 Threads                                 { get; set; }
        public ProcessModuleCollection?                 Modules                                 { get; set; }
        public bool                                     HaveWorkingSetLimits                    { get; set; }
        public bool                                     HavePriorityClass                       { get; set; }
        public bool                                     WatchForExit                            { get; set; }
        public bool                                     WatchingForExit                         { get; set; }
        public EventHandler?                            OnExited                                { get; set; }
        public bool                                     Exited                                  { get; set; }
        public int                                      ExitCode                                { get; set; }
        public bool                                     Signaled                                { get; set; }
        public bool                                     HaveExitTime                            { get; set; }
        public bool                                     RaisedOnExited                          { get; set; }
        public RegisteredWaitHandle?                    RegisteredWaitHandle                    { get; set; }
        public WaitHandle?                              WaitHandle                              { get; set; }
        public ISynchronizeInvoke?                      SynchronizingObject                     { get; set; }
        public StreamReader?                            StandardOutput                          { get; set; }
        public StreamWriter?                            StandardInput                           { get; set; }
        public StreamReader?                            StandardError                           { get; set; }
        public bool                                     Disposed                                { get; set; }
        public StreamReadMode                           OutputStreamReadMode                    { get; set; }
        public StreamReadMode                           ErrorStreamReadMode                     { get; set; }
        public StreamReadMode                           InputStreamReadMode                     { get; set; }
        public AsyncStreamReader?                       Output                                  { get; set; }
        public AsyncStreamReader?                       Error                                   { get; set; }
        public string                                   Process_name                            { get; set; }

        public static Process? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Process() { Pointer= p0 };

            value.HaveProcessId                             = GetBool(new IntPtr(p + 0x028)); // 0x28 HaveProcessId               ( ModelPrimitiveType bool bool bool Bool )
            value.ProcessId                                 = GetInt32(new IntPtr(p + 0x02C)); // 0x2C ProcessId                   ( ModelPrimitiveType int int int Int32 )
            value.HaveProcessHandle                         = GetBool(new IntPtr(p + 0x030)); // 0x30 HaveProcessHandle           ( ModelPrimitiveType bool bool bool Bool )
            value.M_processHandle                           = GetObject<SafeProcessHandle>(new IntPtr(p + 0x038), ReversePrism.DataModels.SafeProcessHandle.FromPointer); // 0x38 M_processHandle             ( ModelClassType SafeProcessHandle SafeProcessHandle SafeProcessHandle Pointer )
            value.IsRemoteMachine                           = GetBool(new IntPtr(p + 0x040)); // 0x40 IsRemoteMachine             ( ModelPrimitiveType bool bool bool Bool )
            value.MachineName                               = GetString(new IntPtr(p + 0x048)); // 0x48 MachineName                 ( ModelPrimitiveType string string string String )
            value.M_processAccess                           = GetInt32(new IntPtr(p + 0x050)); // 0x50 M_processAccess             ( ModelPrimitiveType int int int Int32 )
            value.Threads                                   = GetObject<ProcessThreadCollection>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProcessThreadCollection.FromPointer); // 0x58 Threads                     ( ModelClassType ProcessThreadCollection ProcessThreadCollection ProcessThreadCollection Pointer )
            value.Modules                                   = GetObject<ProcessModuleCollection>(new IntPtr(p + 0x060), ReversePrism.DataModels.ProcessModuleCollection.FromPointer); // 0x60 Modules                     ( ModelClassType ProcessModuleCollection ProcessModuleCollection ProcessModuleCollection Pointer )
            value.HaveWorkingSetLimits                      = GetBool(new IntPtr(p + 0x068)); // 0x68 HaveWorkingSetLimits        ( ModelPrimitiveType bool bool bool Bool )
            value.HavePriorityClass                         = GetBool(new IntPtr(p + 0x069)); // 0x69 HavePriorityClass           ( ModelPrimitiveType bool bool bool Bool )
            value.WatchForExit                              = GetBool(new IntPtr(p + 0x06A)); // 0x6A WatchForExit                ( ModelPrimitiveType bool bool bool Bool )
            value.WatchingForExit                           = GetBool(new IntPtr(p + 0x06B)); // 0x6B WatchingForExit             ( ModelPrimitiveType bool bool bool Bool )
            value.OnExited                                  = GetObject<EventHandler>(new IntPtr(p + 0x070), ReversePrism.DataModels.EventHandler.FromPointer); // 0x70 OnExited                    ( ModelClassType EventHandler EventHandler EventHandler Pointer )
            value.Exited                                    = GetBool(new IntPtr(p + 0x078)); // 0x78 Exited                      ( ModelPrimitiveType bool bool bool Bool )
            value.ExitCode                                  = GetInt32(new IntPtr(p + 0x07C)); // 0x7C ExitCode                    ( ModelPrimitiveType int int int Int32 )
            value.Signaled                                  = GetBool(new IntPtr(p + 0x080)); // 0x80 Signaled                    ( ModelPrimitiveType bool bool bool Bool )
            value.HaveExitTime                              = GetBool(new IntPtr(p + 0x081)); // 0x81 HaveExitTime                ( ModelPrimitiveType bool bool bool Bool )
            value.RaisedOnExited                            = GetBool(new IntPtr(p + 0x082)); // 0x82 RaisedOnExited              ( ModelPrimitiveType bool bool bool Bool )
            value.RegisteredWaitHandle                      = GetObject<RegisteredWaitHandle>(new IntPtr(p + 0x088), ReversePrism.DataModels.RegisteredWaitHandle.FromPointer); // 0x88 RegisteredWaitHandle        ( ModelClassType RegisteredWaitHandle RegisteredWaitHandle RegisteredWaitHandle Pointer )
            value.WaitHandle                                = GetObject<WaitHandle>(new IntPtr(p + 0x090), ReversePrism.DataModels.WaitHandle.FromPointer); // 0x90 WaitHandle                  ( ModelClassType WaitHandle WaitHandle WaitHandle Pointer )
            value.SynchronizingObject                       = GetObject<ISynchronizeInvoke>(new IntPtr(p + 0x098), ReversePrism.DataModels.ISynchronizeInvoke.FromPointer); // 0x98 SynchronizingObject         ( ModelClassType ISynchronizeInvoke ISynchronizeInvoke ISynchronizeInvoke Pointer )
            value.StandardOutput                            = GetObject<StreamReader>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.StreamReader.FromPointer); // 0xA0 StandardOutput              ( ModelClassType StreamReader StreamReader StreamReader Pointer )
            value.StandardInput                             = GetObject<StreamWriter>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.StreamWriter.FromPointer); // 0xA8 StandardInput               ( ModelClassType StreamWriter StreamWriter StreamWriter Pointer )
            value.StandardError                             = GetObject<StreamReader>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.StreamReader.FromPointer); // 0xB0 StandardError               ( ModelClassType StreamReader StreamReader StreamReader Pointer )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x0B8)); // 0xB8 Disposed                    ( ModelPrimitiveType bool bool bool Bool )
            value.OutputStreamReadMode                      = (StreamReadMode)GetInt32(new IntPtr(p + 0x0BC)); // 0xBC OutputStreamReadMode        ( ModelEnumType StreamReadMode StreamReadMode StreamReadMode Int32 )
            value.ErrorStreamReadMode                       = (StreamReadMode)GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 ErrorStreamReadMode         ( ModelEnumType StreamReadMode StreamReadMode StreamReadMode Int32 )
            value.InputStreamReadMode                       = (StreamReadMode)GetInt32(new IntPtr(p + 0x0C4)); // 0xC4 InputStreamReadMode         ( ModelEnumType StreamReadMode StreamReadMode StreamReadMode Int32 )
            value.Output                                    = GetObject<AsyncStreamReader>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.AsyncStreamReader.FromPointer); // 0xC8 Output                      ( ModelClassType AsyncStreamReader AsyncStreamReader AsyncStreamReader Pointer )
            value.Error                                     = GetObject<AsyncStreamReader>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.AsyncStreamReader.FromPointer); // 0xD0 Error                       ( ModelClassType AsyncStreamReader AsyncStreamReader AsyncStreamReader Pointer )
            value.Process_name                              = GetString(new IntPtr(p + 0x0D8)); // 0xD8 Process_name                ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
