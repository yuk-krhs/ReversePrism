using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ListArchiveIndexResponse> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ArchiveIndicesFieldNumber                int IL2CPP_TYPE_I4
    // 008 _repeated_archiveIndices_codec           FieldCodec`1<ArchiveIndex> IL2CPP_TYPE_GENERICINST
    // 018 ArchiveIndices                           000185CCE8F8 ModelClassListType RepeatedField`1<ArchiveIndex> RepeatedField`1<ArchiveIndex> List<ArchiveIndex> Pointer
    public partial class ListArchiveIndexResponse
    {
        public List<ArchiveIndex>?                      ArchiveIndices                          { get; set; }

        public static ListArchiveIndexResponse? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ListArchiveIndexResponse();

            value.ArchiveIndices                            = GetObjectList<ArchiveIndex>(new IntPtr(p + 0x018), ReversePrism.DataModels.ArchiveIndex.FromPointer); // 0270D4B78490 0x18 ArchiveIndices              ( 000185CCE8F8 ModelClassListType RepeatedField`1<ArchiveIndex> RepeatedField`1<ArchiveIndex> List<ArchiveIndex> Pointer )

            return value;
        }
    }
}
