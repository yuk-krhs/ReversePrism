using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 onHandleGetBufferComplete                AsyncCompletion IL2CPP_TYPE_CLASS
    // 008 onHandleFlushBufferComplete              AsyncCompletion IL2CPP_TYPE_CLASS
    // 010 OnHandleWrite                            0001866CEB40 ModelClassType AsyncCompletion AsyncCompletion AsyncCompletion Pointer
    // 070 ByteBuffer                               000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 078 ByteOffset                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 07C ByteCount                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 080 Writer                                   0001865CBC80 ModelClassType XmlStreamNodeWriter XmlStreamNodeWriter XmlStreamNodeWriter Pointer
    public partial class WriteBytesAsyncResult
    {
        public AsyncCompletion?                         OnHandleWrite                           { get; set; }
        public List<sbyte>?                             ByteBuffer                              { get; set; }
        public int                                      ByteOffset                              { get; set; }
        public int                                      ByteCount                               { get; set; }
        public XmlStreamNodeWriter?                     Writer                                  { get; set; }

        public static WriteBytesAsyncResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WriteBytesAsyncResult();

            value.OnHandleWrite                             = GetObject<AsyncCompletion>(new IntPtr(p + 0x010), ReversePrism.DataModels.AsyncCompletion.FromPointer); // 0270D7CB1C78 0x10 OnHandleWrite               ( 0001866CEB40 ModelClassType AsyncCompletion AsyncCompletion AsyncCompletion Pointer )
            value.ByteBuffer                                = GetSByteList(new IntPtr(p + 0x070)); // 0270D7CB1C98 0x70 ByteBuffer                  ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.ByteOffset                                = GetInt32(new IntPtr(p + 0x078)); // 0270D7CB1CB8 0x78 ByteOffset                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ByteCount                                 = GetInt32(new IntPtr(p + 0x07C)); // 0270D7CB1CD8 0x7C ByteCount                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Writer                                    = GetObject<XmlStreamNodeWriter>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlStreamNodeWriter.FromPointer); // 0270D7CB1CF8 0x80 Writer                      ( 0001865CBC80 ModelClassType XmlStreamNodeWriter XmlStreamNodeWriter XmlStreamNodeWriter Pointer )

            return value;
        }
    }
}
