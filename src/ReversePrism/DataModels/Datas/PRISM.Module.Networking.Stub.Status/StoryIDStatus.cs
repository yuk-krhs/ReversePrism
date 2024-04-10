using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<StoryIDStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StoryTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 018 StoryType                                0001865B0320 ModelEnumType StoryType StoryType StoryType Int32
    // 000 StoryMstIdFieldNumber                    int IL2CPP_TYPE_I4
    // 01C StoryMstId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class StoryIDStatus : DataModel
    {
        public StoryType                                StoryType                               { get; set; }
        public int                                      StoryMstId                              { get; set; }

        public static StoryIDStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryIDStatus() { Pointer= p0 };

            value.StoryType                                 = (StoryType)GetInt32(new IntPtr(p + 0x018)); // 0246629C0F10 0x18 StoryType                   ( 0001865B0320 ModelEnumType StoryType StoryType StoryType Int32 )
            value.StoryMstId                                = GetInt32(new IntPtr(p + 0x01C)); // 0246629C0F50 0x1C StoryMstId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
