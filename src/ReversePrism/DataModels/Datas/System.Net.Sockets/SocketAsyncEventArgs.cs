using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 In_progress                              0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 Remote_ep                                0001865C60E0 ModelClassType EndPoint EndPoint EndPoint Pointer
    // 020 Current_socket                           0001865214F0 ModelClassType Socket Socket Socket Pointer
    // 028 Socket_async_result                      0001865229F0 ModelClassType SocketAsyncResult SocketAsyncResult SocketAsyncResult Pointer
    // 030 AcceptSocket                             0001865214F0 ModelClassType Socket Socket Socket Pointer
    // 038 BytesTransferred                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C LastOperation                            0001865221C0 ModelEnumType SocketAsyncOperation SocketAsyncOperation SocketAsyncOperation Int32
    // 040 SocketError                              000186669A00 ModelEnumType SocketError SocketError SocketError Int32
    // 044 SocketFlags                              0001865236B0 ModelEnumType SocketFlags SocketFlags SocketFlags Int32
    // 048 <UserToken>k__BackingField               <object> IL2CPP_TYPE_OBJECT
    // 050 Completed                                EventHandler`1<SocketAsyncEventArgs> IL2CPP_TYPE_GENERICINST
    // 058 _buffer                                  Memory`1<sbyte> IL2CPP_TYPE_GENERICINST
    // 068 Offset                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 06C Count                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 070 BufferIsExplicitArray                    000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.Disposed                                  = GetBool(new IntPtr(p + 0x010)); // 024667B4D228 0x10 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.In_progress                               = GetInt32(new IntPtr(p + 0x014)); // 024667B4D248 0x14 In_progress                 ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Remote_ep                                 = GetObject<EndPoint>(new IntPtr(p + 0x018), ReversePrism.DataModels.EndPoint.FromPointer); // 024667B4D268 0x18 Remote_ep                   ( 0001865C60E0 ModelClassType EndPoint EndPoint EndPoint Pointer )
            value.Current_socket                            = GetObject<Socket>(new IntPtr(p + 0x020), ReversePrism.DataModels.Socket.FromPointer); // 024667B4D288 0x20 Current_socket              ( 0001865214F0 ModelClassType Socket Socket Socket Pointer )
            value.Socket_async_result                       = GetObject<SocketAsyncResult>(new IntPtr(p + 0x028), ReversePrism.DataModels.SocketAsyncResult.FromPointer); // 024667B4D2A8 0x28 Socket_async_result         ( 0001865229F0 ModelClassType SocketAsyncResult SocketAsyncResult SocketAsyncResult Pointer )
            value.AcceptSocket                              = GetObject<Socket>(new IntPtr(p + 0x030), ReversePrism.DataModels.Socket.FromPointer); // 024667B4D2C8 0x30 AcceptSocket                ( 0001865214F0 ModelClassType Socket Socket Socket Pointer )
            value.BytesTransferred                          = GetInt32(new IntPtr(p + 0x038)); // 024667B4D2E8 0x38 BytesTransferred            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LastOperation                             = (SocketAsyncOperation)GetInt32(new IntPtr(p + 0x03C)); // 024667B4D308 0x3C LastOperation               ( 0001865221C0 ModelEnumType SocketAsyncOperation SocketAsyncOperation SocketAsyncOperation Int32 )
            value.SocketError                               = (SocketError)GetInt32(new IntPtr(p + 0x040)); // 024667B4D328 0x40 SocketError                 ( 000186669A00 ModelEnumType SocketError SocketError SocketError Int32 )
            value.SocketFlags                               = (SocketFlags)GetInt32(new IntPtr(p + 0x044)); // 024667B4D348 0x44 SocketFlags                 ( 0001865236B0 ModelEnumType SocketFlags SocketFlags SocketFlags Int32 )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x068)); // 024667B4D3C8 0x68 Offset                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x06C)); // 024667B4D3E8 0x6C Count                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BufferIsExplicitArray                     = GetBool(new IntPtr(p + 0x070)); // 024667B4D408 0x70 BufferIsExplicitArray       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
