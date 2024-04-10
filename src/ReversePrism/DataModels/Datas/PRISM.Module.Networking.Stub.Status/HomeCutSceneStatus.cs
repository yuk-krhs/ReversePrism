using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<HomeCutSceneStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstHomeCutSceneIdFieldNumber             int IL2CPP_TYPE_I4
    // 018 MstHomeCutSceneId                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ResourceIdFieldNumber                    int IL2CPP_TYPE_I4
    // 020 ResourceId                               000186671910 ModelPrimitiveType string string string String
    public partial class HomeCutSceneStatus : DataModel
    {
        public int                                      MstHomeCutSceneId                       { get; set; }
        public string                                   ResourceId                              { get; set; }

        public static HomeCutSceneStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeCutSceneStatus() { Pointer= p0 };

            value.MstHomeCutSceneId                         = GetInt32(new IntPtr(p + 0x018)); // 024662022D58 0x18 MstHomeCutSceneId           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ResourceId                                = GetString(new IntPtr(p + 0x020)); // 024662022D98 0x20 ResourceId                  ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
