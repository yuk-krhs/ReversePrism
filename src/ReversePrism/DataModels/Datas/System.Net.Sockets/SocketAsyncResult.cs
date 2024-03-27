using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Socket                                   000186521770 ModelClassType Socket Socket Socket Pointer
    // 038 Operation                                000186524130 ModelEnumType SocketOperation SocketOperation SocketOperation Int32
    // 040 DelayedException                         0001865CA820 ModelClassType Exception Exception Exception Pointer
    // 048 EndPoint                                 0001865C65A0 ModelClassType EndPoint EndPoint EndPoint Pointer
    // 050 Buffer                                   Memory`1<sbyte> IL2CPP_TYPE_GENERICINST
    // 060 Offset                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 064 Size                                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 068 SockFlags                                000186523980 ModelEnumType SocketFlags SocketFlags SocketFlags Int32
    // 070 AcceptSocket                             000186521770 ModelClassType Socket Socket Socket Pointer
    // 078 Addresses                                000185B88240 ModelClassListType IPAddress[] IPAddress[] List<IPAddress> Pointer
    // 080 Port                                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 088 Buffers                                  IList`1<ArraySegment`1<sbyte>> IL2CPP_TYPE_GENERICINST
    // 090 ReuseSocket                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 094 CurrentAddress                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 098 AcceptedSocket                           000186521770 ModelClassType Socket Socket Socket Pointer
    // 0A0 Total                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 0A4 Error                                    0001865F2F90 ModelPrimitiveType int int int Int32
    // 0A8 EndCalled                                0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class SocketAsyncResult
    {
        public Socket?                                  Socket                                  { get; set; }
        public SocketOperation                          Operation                               { get; set; }
        public Exception?                               DelayedException                        { get; set; }
        public EndPoint?                                EndPoint                                { get; set; }
        public int                                      Offset                                  { get; set; }
        public int                                      Size                                    { get; set; }
        public SocketFlags                              SockFlags                               { get; set; }
        public Socket?                                  AcceptSocket                            { get; set; }
        public List<IPAddress>?                         Addresses                               { get; set; }
        public int                                      Port                                    { get; set; }
        public bool                                     ReuseSocket                             { get; set; }
        public int                                      CurrentAddress                          { get; set; }
        public Socket?                                  AcceptedSocket                          { get; set; }
        public int                                      Total                                   { get; set; }
        public int                                      Error                                   { get; set; }
        public int                                      EndCalled                               { get; set; }

        public static SocketAsyncResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SocketAsyncResult();

            value.Socket                                    = GetObject<Socket>(new IntPtr(p + 0x030), ReversePrism.DataModels.Socket.FromPointer); // 0270D7AE9858 0x30 Socket                      ( 000186521770 ModelClassType Socket Socket Socket Pointer )
            value.Operation                                 = (SocketOperation)GetInt32(new IntPtr(p + 0x038)); // 0270D7AE9878 0x38 Operation                   ( 000186524130 ModelEnumType SocketOperation SocketOperation SocketOperation Int32 )
            value.DelayedException                          = GetObject<Exception>(new IntPtr(p + 0x040), ReversePrism.DataModels.Exception.FromPointer); // 0270D7AE9898 0x40 DelayedException            ( 0001865CA820 ModelClassType Exception Exception Exception Pointer )
            value.EndPoint                                  = GetObject<EndPoint>(new IntPtr(p + 0x048), ReversePrism.DataModels.EndPoint.FromPointer); // 0270D7AE98B8 0x48 EndPoint                    ( 0001865C65A0 ModelClassType EndPoint EndPoint EndPoint Pointer )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x060)); // 0270D7AE98F8 0x60 Offset                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Size                                      = GetInt32(new IntPtr(p + 0x064)); // 0270D7AE9918 0x64 Size                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SockFlags                                 = (SocketFlags)GetInt32(new IntPtr(p + 0x068)); // 0270D7AE9938 0x68 SockFlags                   ( 000186523980 ModelEnumType SocketFlags SocketFlags SocketFlags Int32 )
            value.AcceptSocket                              = GetObject<Socket>(new IntPtr(p + 0x070), ReversePrism.DataModels.Socket.FromPointer); // 0270D7AE9958 0x70 AcceptSocket                ( 000186521770 ModelClassType Socket Socket Socket Pointer )
            value.Addresses                                 = GetObjectList<IPAddress>(new IntPtr(p + 0x078), ReversePrism.DataModels.IPAddress.FromPointer); // 0270D7AE9978 0x78 Addresses                   ( 000185B88240 ModelClassListType IPAddress[] IPAddress[] List<IPAddress> Pointer )
            value.Port                                      = GetInt32(new IntPtr(p + 0x080)); // 0270D7AE9998 0x80 Port                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ReuseSocket                               = GetBool(new IntPtr(p + 0x090)); // 0270D7AE99D8 0x90 ReuseSocket                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.CurrentAddress                            = GetInt32(new IntPtr(p + 0x094)); // 0270D7AE99F8 0x94 CurrentAddress              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.AcceptedSocket                            = GetObject<Socket>(new IntPtr(p + 0x098), ReversePrism.DataModels.Socket.FromPointer); // 0270D7AE9A18 0x98 AcceptedSocket              ( 000186521770 ModelClassType Socket Socket Socket Pointer )
            value.Total                                     = GetInt32(new IntPtr(p + 0x0A0)); // 0270D7AE9A38 0xA0 Total                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Error                                     = GetInt32(new IntPtr(p + 0x0A4)); // 0270D7AE9A58 0xA4 Error                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.EndCalled                                 = GetInt32(new IntPtr(p + 0x0A8)); // 0270D7AE9A78 0xA8 EndCalled                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
