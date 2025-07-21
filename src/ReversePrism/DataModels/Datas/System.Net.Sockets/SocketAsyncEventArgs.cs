using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Disposed                                 ModelPrimitiveType bool bool bool Bool
    // 014 In_progress                              ModelPrimitiveType int int int Int32
    // 018 Remote_ep                                ModelClassType EndPoint EndPoint EndPoint Pointer
    // 020 Current_socket                           ModelClassType Socket Socket Socket Pointer
    // 028 Socket_async_result                      ModelClassType SocketAsyncResult SocketAsyncResult SocketAsyncResult Pointer
    // 030 AcceptSocket                             ModelClassType Socket Socket Socket Pointer
    // 038 BytesTransferred                         ModelPrimitiveType int int int Int32
    // 03C LastOperation                            ModelEnumType SocketAsyncOperation SocketAsyncOperation SocketAsyncOperation Int32
    // 040 SocketError                              ModelEnumType SocketError SocketError SocketError Int32
    // 044 SocketFlags                              ModelEnumType SocketFlags SocketFlags SocketFlags Int32
    // 048 <UserToken>k__BackingField               <object> IL2CPP_TYPE_OBJECT
    // 050 Completed                                EventHandler`1<SocketAsyncEventArgs> IL2CPP_TYPE_GENERICINST
    // 058 _buffer                                  Memory`1<sbyte> IL2CPP_TYPE_GENERICINST
    // 068 Offset                                   ModelPrimitiveType int int int Int32
    // 06C Count                                    ModelPrimitiveType int int int Int32
    // 070 BufferIsExplicitArray                    ModelPrimitiveType bool bool bool Bool
    // 078 _bufferList                              IList`1<ArraySegment`1<sbyte>> IL2CPP_TYPE_GENERICINST
    public partial class SocketAsyncEventArgs : DataModel
    {
        public bool                                     Disposed                                { get; set; }
        public int                                      In_progress                             { get; set; }
        public EndPoint?                                Remote_ep                               { get; set; }
        public Socket?                                  Current_socket                          { get; set; }
        public SocketAsyncResult?                       Socket_async_result                     { get; set; }
        public Socket?                                  AcceptSocket                            { get; set; }
        public int                                      BytesTransferred                        { get; set; }
        public SocketAsyncOperation                     LastOperation                           { get; set; }
        public SocketError                              SocketError                             { get; set; }
        public SocketFlags                              SocketFlags                             { get; set; }
        public int                                      Offset                                  { get; set; }
        public int                                      Count                                   { get; set; }
        public bool                                     BufferIsExplicitArray                   { get; set; }

        public static SocketAsyncEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SocketAsyncEventArgs() { Pointer= p0 };

            value.Disposed                                  = GetBool(new IntPtr(p + 0x010)); // 0x10 Disposed                    ( ModelPrimitiveType bool bool bool Bool )
            value.In_progress                               = GetInt32(new IntPtr(p + 0x014)); // 0x14 In_progress                 ( ModelPrimitiveType int int int Int32 )
            value.Remote_ep                                 = GetObject<EndPoint>(new IntPtr(p + 0x018), ReversePrism.DataModels.EndPoint.FromPointer); // 0x18 Remote_ep                   ( ModelClassType EndPoint EndPoint EndPoint Pointer )
            value.Current_socket                            = GetObject<Socket>(new IntPtr(p + 0x020), ReversePrism.DataModels.Socket.FromPointer); // 0x20 Current_socket              ( ModelClassType Socket Socket Socket Pointer )
            value.Socket_async_result                       = GetObject<SocketAsyncResult>(new IntPtr(p + 0x028), ReversePrism.DataModels.SocketAsyncResult.FromPointer); // 0x28 Socket_async_result         ( ModelClassType SocketAsyncResult SocketAsyncResult SocketAsyncResult Pointer )
            value.AcceptSocket                              = GetObject<Socket>(new IntPtr(p + 0x030), ReversePrism.DataModels.Socket.FromPointer); // 0x30 AcceptSocket                ( ModelClassType Socket Socket Socket Pointer )
            value.BytesTransferred                          = GetInt32(new IntPtr(p + 0x038)); // 0x38 BytesTransferred            ( ModelPrimitiveType int int int Int32 )
            value.LastOperation                             = (SocketAsyncOperation)GetInt32(new IntPtr(p + 0x03C)); // 0x3C LastOperation               ( ModelEnumType SocketAsyncOperation SocketAsyncOperation SocketAsyncOperation Int32 )
            value.SocketError                               = (SocketError)GetInt32(new IntPtr(p + 0x040)); // 0x40 SocketError                 ( ModelEnumType SocketError SocketError SocketError Int32 )
            value.SocketFlags                               = (SocketFlags)GetInt32(new IntPtr(p + 0x044)); // 0x44 SocketFlags                 ( ModelEnumType SocketFlags SocketFlags SocketFlags Int32 )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x068)); // 0x68 Offset                      ( ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x06C)); // 0x6C Count                       ( ModelPrimitiveType int int int Int32 )
            value.BufferIsExplicitArray                     = GetBool(new IntPtr(p + 0x070)); // 0x70 BufferIsExplicitArray       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
