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
    // 010 OnHandleWrite                            ModelClassType AsyncCompletion AsyncCompletion AsyncCompletion Pointer
    // 070 ByteBuffer                               ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 078 ByteOffset                               ModelPrimitiveType int int int Int32
    // 07C ByteCount                                ModelPrimitiveType int int int Int32
    // 080 Writer                                   ModelClassType XmlStreamNodeWriter XmlStreamNodeWriter XmlStreamNodeWriter Pointer
    public partial class WriteBytesAsyncResult : DataModel
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
            var value   = new WriteBytesAsyncResult() { Pointer= p0 };

            value.OnHandleWrite                             = GetObject<AsyncCompletion>(new IntPtr(p + 0x010), ReversePrism.DataModels.AsyncCompletion.FromPointer); // 0x10 OnHandleWrite               ( ModelClassType AsyncCompletion AsyncCompletion AsyncCompletion Pointer )
            value.ByteBuffer                                = GetSByteList(new IntPtr(p + 0x070)); // 0x70 ByteBuffer                  ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.ByteOffset                                = GetInt32(new IntPtr(p + 0x078)); // 0x78 ByteOffset                  ( ModelPrimitiveType int int int Int32 )
            value.ByteCount                                 = GetInt32(new IntPtr(p + 0x07C)); // 0x7C ByteCount                   ( ModelPrimitiveType int int int Int32 )
            value.Writer                                    = GetObject<XmlStreamNodeWriter>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlStreamNodeWriter.FromPointer); // 0x80 Writer                      ( ModelClassType XmlStreamNodeWriter XmlStreamNodeWriter XmlStreamNodeWriter Pointer )

            return value;
        }
    }
}
