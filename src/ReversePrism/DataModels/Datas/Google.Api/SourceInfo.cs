using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SourceInfo> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SourceFilesFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_sourceFiles_codec              FieldCodec`1<Any> IL2CPP_TYPE_GENERICINST
    // 018 SourceFiles                              ModelClassListType RepeatedField`1<Any> RepeatedField`1<Any> List<Any> Pointer
    public partial class SourceInfo : DataModel
    {
        public List<Any>?                               SourceFiles                             { get; set; }

        public static SourceInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SourceInfo() { Pointer= p0 };

            value.SourceFiles                               = GetObjectList<Any>(new IntPtr(p + 0x018), ReversePrism.DataModels.Any.FromPointer); // 0x18 SourceFiles                 ( ModelClassListType RepeatedField`1<Any> RepeatedField`1<Any> List<Any> Pointer )

            return value;
        }
    }
}
