using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Parent                                   00018662CBA0 ModelClassType MobileAuthenticatedStream MobileAuthenticatedStream MobileAuthenticatedStream Pointer
    // 018 RunSynchronously                         0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 01C UserResult                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 Started                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 RequestedSize                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 WriteRequested                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 locker                                   <object> IL2CPP_TYPE_OBJECT
    public partial class AsyncProtocolRequest
    {
        public MobileAuthenticatedStream?               Parent                                  { get; set; }
        public bool                                     RunSynchronously                        { get; set; }
        public int                                      UserResult                              { get; set; }
        public int                                      Started                                 { get; set; }
        public int                                      RequestedSize                           { get; set; }
        public int                                      WriteRequested                          { get; set; }

        public static AsyncProtocolRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncProtocolRequest();

            value.Parent                                    = GetObject<MobileAuthenticatedStream>(new IntPtr(p + 0x010), ReversePrism.DataModels.MobileAuthenticatedStream.FromPointer); // 0270D790DC70 0x10 Parent                      ( 00018662CBA0 ModelClassType MobileAuthenticatedStream MobileAuthenticatedStream MobileAuthenticatedStream Pointer )
            value.RunSynchronously                          = GetBool(new IntPtr(p + 0x018)); // 0270D790DC90 0x18 RunSynchronously            ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.UserResult                                = GetInt32(new IntPtr(p + 0x01C)); // 0270D790DCB0 0x1C UserResult                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Started                                   = GetInt32(new IntPtr(p + 0x020)); // 0270D790DCD0 0x20 Started                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RequestedSize                             = GetInt32(new IntPtr(p + 0x024)); // 0270D790DCF0 0x24 RequestedSize               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.WriteRequested                            = GetInt32(new IntPtr(p + 0x028)); // 0270D790DD10 0x28 WriteRequested              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
