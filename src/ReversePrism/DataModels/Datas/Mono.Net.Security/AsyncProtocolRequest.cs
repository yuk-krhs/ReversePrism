using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Parent                                   ModelClassType MobileAuthenticatedStream MobileAuthenticatedStream MobileAuthenticatedStream Pointer
    // 018 RunSynchronously                         ModelPrimitiveType bool bool bool Bool
    // 01C UserResult                               ModelPrimitiveType int int int Int32
    // 020 Started                                  ModelPrimitiveType int int int Int32
    // 024 RequestedSize                            ModelPrimitiveType int int int Int32
    // 028 WriteRequested                           ModelPrimitiveType int int int Int32
    // 030 locker                                   <object> IL2CPP_TYPE_OBJECT
    public partial class AsyncProtocolRequest : DataModel
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
            var value   = new AsyncProtocolRequest() { Pointer= p0 };

            value.Parent                                    = GetObject<MobileAuthenticatedStream>(new IntPtr(p + 0x010), ReversePrism.DataModels.MobileAuthenticatedStream.FromPointer); // 0x10 Parent                      ( ModelClassType MobileAuthenticatedStream MobileAuthenticatedStream MobileAuthenticatedStream Pointer )
            value.RunSynchronously                          = GetBool(new IntPtr(p + 0x018)); // 0x18 RunSynchronously            ( ModelPrimitiveType bool bool bool Bool )
            value.UserResult                                = GetInt32(new IntPtr(p + 0x01C)); // 0x1C UserResult                  ( ModelPrimitiveType int int int Int32 )
            value.Started                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 Started                     ( ModelPrimitiveType int int int Int32 )
            value.RequestedSize                             = GetInt32(new IntPtr(p + 0x024)); // 0x24 RequestedSize               ( ModelPrimitiveType int int int Int32 )
            value.WriteRequested                            = GetInt32(new IntPtr(p + 0x028)); // 0x28 WriteRequested              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
