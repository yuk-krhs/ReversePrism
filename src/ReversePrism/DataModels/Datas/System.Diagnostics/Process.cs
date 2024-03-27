using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 HaveProcessId                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02C ProcessId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 HaveProcessHandle                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 M_processHandle                          00018665E660 ModelClassType SafeProcessHandle SafeProcessHandle SafeProcessHandle Pointer
    // 040 IsRemoteMachine                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 MachineName                              000186671910 ModelPrimitiveType string string string String
    // 050 M_processAccess                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 058 Threads                                  000186525180 ModelClassType ProcessThreadCollection ProcessThreadCollection ProcessThreadCollection Pointer
    // 060 Modules                                  000186524CC0 ModelClassType ProcessModuleCollection ProcessModuleCollection ProcessModuleCollection Pointer
    // 068 HaveWorkingSetLimits                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 069 HavePriorityClass                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 06A WatchForExit                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 06B WatchingForExit                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 070 OnExited                                 000186756FD0 ModelClassType EventHandler EventHandler EventHandler Pointer
    // 078 Exited                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 07C ExitCode                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 080 Signaled                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 081 HaveExitTime                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 082 RaisedOnExited                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 088 RegisteredWaitHandle                     000186645260 ModelClassType RegisteredWaitHandle RegisteredWaitHandle RegisteredWaitHandle Pointer
    // 090 WaitHandle                               000186542CB0 ModelClassType WaitHandle WaitHandle WaitHandle Pointer
    // 098 SynchronizingObject                      00018666B910 ModelClassType ISynchronizeInvoke ISynchronizeInvoke ISynchronizeInvoke Pointer
    // 0A0 StandardOutput                           0001865B59B0 ModelClassType StreamReader StreamReader StreamReader Pointer
    // 0A8 StandardInput                            0001865B65B0 ModelClassType StreamWriter StreamWriter StreamWriter Pointer
    // 0B0 StandardError                            0001865B59B0 ModelClassType StreamReader StreamReader StreamReader Pointer
    // 0B8 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0BC OutputStreamReadMode                     0001865BC4D0 ModelEnumType StreamReadMode StreamReadMode StreamReadMode Int32
    // 0C0 ErrorStreamReadMode                      0001865BC4D0 ModelEnumType StreamReadMode StreamReadMode StreamReadMode Int32
    // 0C4 InputStreamReadMode                      0001865BC4D0 ModelEnumType StreamReadMode StreamReadMode StreamReadMode Int32
    // 0C8 Output                                   000186704130 ModelClassType AsyncStreamReader AsyncStreamReader AsyncStreamReader Pointer
    // 0D0 Error                                    000186704130 ModelClassType AsyncStreamReader AsyncStreamReader AsyncStreamReader Pointer
    // 0D8 Process_name                             000186671910 ModelPrimitiveType string string string String
    public partial class Process
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
            var value   = new Process();

            value.HaveProcessId                             = GetBool(new IntPtr(p + 0x028)); // 027004D1C748 0x28 HaveProcessId               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ProcessId                                 = GetInt32(new IntPtr(p + 0x02C)); // 027004D1C768 0x2C ProcessId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HaveProcessHandle                         = GetBool(new IntPtr(p + 0x030)); // 027004D1C788 0x30 HaveProcessHandle           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_processHandle                           = GetObject<SafeProcessHandle>(new IntPtr(p + 0x038), ReversePrism.DataModels.SafeProcessHandle.FromPointer); // 027004D1C7A8 0x38 M_processHandle             ( 00018665E660 ModelClassType SafeProcessHandle SafeProcessHandle SafeProcessHandle Pointer )
            value.IsRemoteMachine                           = GetBool(new IntPtr(p + 0x040)); // 027004D1C7C8 0x40 IsRemoteMachine             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MachineName                               = GetString(new IntPtr(p + 0x048)); // 027004D1C7E8 0x48 MachineName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.M_processAccess                           = GetInt32(new IntPtr(p + 0x050)); // 027004D1C808 0x50 M_processAccess             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Threads                                   = GetObject<ProcessThreadCollection>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProcessThreadCollection.FromPointer); // 027004D1C828 0x58 Threads                     ( 000186525180 ModelClassType ProcessThreadCollection ProcessThreadCollection ProcessThreadCollection Pointer )
            value.Modules                                   = GetObject<ProcessModuleCollection>(new IntPtr(p + 0x060), ReversePrism.DataModels.ProcessModuleCollection.FromPointer); // 027004D1C848 0x60 Modules                     ( 000186524CC0 ModelClassType ProcessModuleCollection ProcessModuleCollection ProcessModuleCollection Pointer )
            value.HaveWorkingSetLimits                      = GetBool(new IntPtr(p + 0x068)); // 027004D1C868 0x68 HaveWorkingSetLimits        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HavePriorityClass                         = GetBool(new IntPtr(p + 0x069)); // 027004D1C888 0x69 HavePriorityClass           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.WatchForExit                              = GetBool(new IntPtr(p + 0x06A)); // 027004D1C8A8 0x6A WatchForExit                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.WatchingForExit                           = GetBool(new IntPtr(p + 0x06B)); // 027004D1C8C8 0x6B WatchingForExit             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OnExited                                  = GetObject<EventHandler>(new IntPtr(p + 0x070), ReversePrism.DataModels.EventHandler.FromPointer); // 027004D1C8E8 0x70 OnExited                    ( 000186756FD0 ModelClassType EventHandler EventHandler EventHandler Pointer )
            value.Exited                                    = GetBool(new IntPtr(p + 0x078)); // 027004D1C908 0x78 Exited                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ExitCode                                  = GetInt32(new IntPtr(p + 0x07C)); // 027004D1C928 0x7C ExitCode                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Signaled                                  = GetBool(new IntPtr(p + 0x080)); // 027004D1C948 0x80 Signaled                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HaveExitTime                              = GetBool(new IntPtr(p + 0x081)); // 027004D1C968 0x81 HaveExitTime                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RaisedOnExited                            = GetBool(new IntPtr(p + 0x082)); // 027004D1C988 0x82 RaisedOnExited              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RegisteredWaitHandle                      = GetObject<RegisteredWaitHandle>(new IntPtr(p + 0x088), ReversePrism.DataModels.RegisteredWaitHandle.FromPointer); // 027004D1C9A8 0x88 RegisteredWaitHandle        ( 000186645260 ModelClassType RegisteredWaitHandle RegisteredWaitHandle RegisteredWaitHandle Pointer )
            value.WaitHandle                                = GetObject<WaitHandle>(new IntPtr(p + 0x090), ReversePrism.DataModels.WaitHandle.FromPointer); // 027004D1C9C8 0x90 WaitHandle                  ( 000186542CB0 ModelClassType WaitHandle WaitHandle WaitHandle Pointer )
            value.SynchronizingObject                       = GetObject<ISynchronizeInvoke>(new IntPtr(p + 0x098), ReversePrism.DataModels.ISynchronizeInvoke.FromPointer); // 027004D1C9E8 0x98 SynchronizingObject         ( 00018666B910 ModelClassType ISynchronizeInvoke ISynchronizeInvoke ISynchronizeInvoke Pointer )
            value.StandardOutput                            = GetObject<StreamReader>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.StreamReader.FromPointer); // 027004D1CA08 0xA0 StandardOutput              ( 0001865B59B0 ModelClassType StreamReader StreamReader StreamReader Pointer )
            value.StandardInput                             = GetObject<StreamWriter>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.StreamWriter.FromPointer); // 027004D1CA28 0xA8 StandardInput               ( 0001865B65B0 ModelClassType StreamWriter StreamWriter StreamWriter Pointer )
            value.StandardError                             = GetObject<StreamReader>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.StreamReader.FromPointer); // 027004D1CA48 0xB0 StandardError               ( 0001865B59B0 ModelClassType StreamReader StreamReader StreamReader Pointer )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x0B8)); // 027004D1CA68 0xB8 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OutputStreamReadMode                      = (StreamReadMode)GetInt32(new IntPtr(p + 0x0BC)); // 027004D1CA88 0xBC OutputStreamReadMode        ( 0001865BC4D0 ModelEnumType StreamReadMode StreamReadMode StreamReadMode Int32 )
            value.ErrorStreamReadMode                       = (StreamReadMode)GetInt32(new IntPtr(p + 0x0C0)); // 027004D1CAA8 0xC0 ErrorStreamReadMode         ( 0001865BC4D0 ModelEnumType StreamReadMode StreamReadMode StreamReadMode Int32 )
            value.InputStreamReadMode                       = (StreamReadMode)GetInt32(new IntPtr(p + 0x0C4)); // 027004D1CAC8 0xC4 InputStreamReadMode         ( 0001865BC4D0 ModelEnumType StreamReadMode StreamReadMode StreamReadMode Int32 )
            value.Output                                    = GetObject<AsyncStreamReader>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.AsyncStreamReader.FromPointer); // 027004D1CAE8 0xC8 Output                      ( 000186704130 ModelClassType AsyncStreamReader AsyncStreamReader AsyncStreamReader Pointer )
            value.Error                                     = GetObject<AsyncStreamReader>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.AsyncStreamReader.FromPointer); // 027004D1CB08 0xD0 Error                       ( 000186704130 ModelClassType AsyncStreamReader AsyncStreamReader AsyncStreamReader Pointer )
            value.Process_name                              = GetString(new IntPtr(p + 0x0D8)); // 027004D1CB28 0xD8 Process_name                ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
