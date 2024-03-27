using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FileDescriptorSet> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FileFieldNumber                          int IL2CPP_TYPE_I4
    // 008 _repeated_file_codec                     FieldCodec`1<FileDescriptorProto> IL2CPP_TYPE_GENERICINST
    // 018 File                                     000185CD8D78 ModelClassListType RepeatedField`1<FileDescriptorProto> RepeatedField`1<FileDescriptorProto> List<FileDescriptorProto> Pointer
    public partial class FileDescriptorSet
    {
        public List<FileDescriptorProto>?               File                                    { get; set; }

        public static FileDescriptorSet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FileDescriptorSet();

            value.File                                      = GetObjectList<FileDescriptorProto>(new IntPtr(p + 0x018), ReversePrism.DataModels.FileDescriptorProto.FromPointer); // 0270D0BBAE18 0x18 File                        ( 000185CD8D78 ModelClassListType RepeatedField`1<FileDescriptorProto> RepeatedField`1<FileDescriptorProto> List<FileDescriptorProto> Pointer )

            return value;
        }
    }
}
